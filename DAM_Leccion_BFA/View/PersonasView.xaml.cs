namespace DAM_Leccion_BFA.View;
using DAM_Leccion_BFA.ViewModel;

public partial class PersonasView : ContentPage
{
	public PersonasView()
	{
		InitializeComponent();
		BindingContext = new PersonasViewModel();
	}
}