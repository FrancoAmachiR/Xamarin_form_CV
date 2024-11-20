using CVApp.Models;
using System.Linq;
using Xamarin.Forms;

namespace CVApp.Views
{
    public partial class VisualizacionCV : ContentPage
    {
        public string NombreCompleto { get; set; }
        public string LenguajesString { get; set; }
        public string HabilidadesString { get; set; }

        public VisualizacionCV(CurriculumModel cv)
        {
            InitializeComponent();

            NombreCompleto = $"{cv.Nombre} {cv.Apellido}";
            LenguajesString = string.Join(", ", cv.LenguajesProgramacion);
            HabilidadesString = string.Join(", ", cv.Habilidades);

            BindingContext = new
            {
                NombreCompleto,
                cv.Ocupacion,
                cv.FechaNacimiento,
                cv.Telefono,
                cv.Email,
                cv.Nacionalidad,
                cv.NivelIngles,
                LenguajesString,
                cv.Aptitudes,
                HabilidadesString,
                cv.Perfil
            };
        }
    }
}