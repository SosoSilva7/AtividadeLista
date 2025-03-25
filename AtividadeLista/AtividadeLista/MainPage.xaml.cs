namespace AtividadeLista
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        private void btnListaPersonagem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaPersonagemJogoPage());
        }

    }

}
