namespace AtividadeLista;

public partial class ListaPersonagemJogoPage : ContentPage
{
	public ListaPersonagemJogoPage()
	{
		List<PersonagemJogo> lista = PersonagemJogo.Lista;

		InitializeComponent();
        lstPersonagemJogo.ItemsSource = lista;

	}

    private void ViewCell_Tapped(object sender, EventArgs e)
    {
		Navigation.PushAsync(new PersonagemJogoPage { BindingContext = (((ViewCell)sender).BindingContext as PersonagemJogo) });
    }
}