using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DemoTTS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Paginas.PaginaTextoVoz();
        }
    }
}
