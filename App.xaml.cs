using CVApp.Views;
using Xamarin.Forms;

namespace CVApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new FormularioCV())
            {
                BarBackgroundColor = Color.FromHex("#2196F3"),
                BarTextColor = Color.White
            };
        }
    }
}