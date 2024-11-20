using CVApp.Models;
using System;
using System.Linq;
using Xamarin.Forms;

namespace CVApp.Views
{
    public partial class FormularioCV : ContentPage
    {
        private CurriculumModel cv;

        public FormularioCV()
        {
            InitializeComponent();
            cv = new CurriculumModel();
            BindingContext = cv;
        }

        private void OnNivelInglesChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                var radio = (RadioButton)sender;
                cv.NivelIngles = radio.Content.ToString();
            }
        }

        private void OnLenguajeChanged(object sender, CheckedChangedEventArgs e)
        {
            var checkBox = (CheckBox)sender;
            var lenguaje = ((Label)((StackLayout)checkBox.Parent).Children
                .First(x => x is Label)).Text;

            if (e.Value)
                cv.LenguajesProgramacion.Add(lenguaje);
            else
                cv.LenguajesProgramacion.Remove(lenguaje);
        }

        private void OnHabilidadChanged(object sender, CheckedChangedEventArgs e)
        {
            var checkBox = (CheckBox)sender;
            var habilidad = ((Label)((StackLayout)checkBox.Parent).Children
                .First(x => x is Label)).Text;

            if (e.Value)
                cv.Habilidades.Add(habilidad);
            else
                cv.Habilidades.Remove(habilidad);
        }

        private async void OnEnviarClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cv.Nombre) || string.IsNullOrEmpty(cv.Apellido))
            {
                await DisplayAlert("Error", "Por favor complete los campos nombre y apellido", "OK");
                return;
            }
            await Navigation.PushAsync(new VisualizacionCV(cv));
        }
    }
}
