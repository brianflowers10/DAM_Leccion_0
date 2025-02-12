using DAM_Leccion_BFA.View;

namespace DAM_Leccion_BFA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new PersonasView();
        }
    }
}
