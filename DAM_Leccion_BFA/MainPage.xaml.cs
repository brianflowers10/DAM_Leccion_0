using DAM_Leccion_BFA.Model;
using DAM_Leccion_BFA.ViewModel;


namespace DAM_Leccion_BFA
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        MainPageViewModel mainPageViewModel = new MainPageViewModel();
        
    

        public MainPage()
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        // Evento Guardar
        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Asistente del sistema", "Cargando los nuevos datos", "Aceptar");
            // Cambiamos los valores en el modelo, y la UI se actualizará automáticamente
            //PersonaModel.Nombre = "Alondra";
            //PersonaModel.Apellido = "Montalvo";
            //PersonaModel.Edad = 19;
        }
    }
}
