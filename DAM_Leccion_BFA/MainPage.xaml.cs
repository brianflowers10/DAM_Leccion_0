using DAM_Leccion_BFA.Model;

namespace DAM_Leccion_BFA
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        // Propiedad pública para que el binding funcione correctamente
        public PersonaModel PersonaModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            PersonaModel = new PersonaModel()
            {
                Nombre = "Lupita",
                Apellido = "Olvera",
                Edad = 25
            };

            BindingContext = PersonaModel;
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
            DisplayAlert("Asistente del sistema", "Cargando los nuevos datos", "Aceptar");

            // Cambiamos los valores en el modelo, y la UI se actualizará automáticamente
            PersonaModel.Nombre = "Alondra";
            PersonaModel.Apellido = "Montalvo";
            PersonaModel.Edad = 19;
        }
    }
}
