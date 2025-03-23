namespace AtividadeLista
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
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

        private void btnListaPersonagem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaPersonagemJogoPage());
        }

        private void btnPersonagem_Clicked(object sender, EventArgs e)
        {
            PersonagemJogo personagemJogo = new PersonagemJogo();

            personagemJogo.Nome = "leef";
            personagemJogo.Historia = "ffe";
            personagemJogo.Poder = "kf";
            personagemJogo.Caracteristicas = "orefer";
            personagemJogo.Origem = "erfje";

            Navigation.PushAsync(new PersonagemJogoPage() { BindingContext = personagemJogo });
        }
    }

}
