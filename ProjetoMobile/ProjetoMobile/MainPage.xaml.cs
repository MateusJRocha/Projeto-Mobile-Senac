using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjetoMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonLogin_Clicked(object sender, EventArgs e)
        {
            if (entryEmail.Text == "admin" && entrySenha.Text == "admin")
            {
                var page = new PagePrincipal();
                await Navigation.PushModalAsync(page);
                
            }
            else
            {
                await DisplayAlert("Ops...", "Login e/ou senha incorreto", "ok");
            }
        }

        private async void ButtonCadastro_Clicked(object sender, EventArgs e)
        {
            var Cadastro = new PageCadastro();
            await Navigation.PushModalAsync(Cadastro);
        }

        private async void ButtonRecuperarSenha_Clicked(object sender, EventArgs e)
        {
            var RecuperarSenha = new RecuperarSenha();
            await Navigation.PushModalAsync(RecuperarSenha);
        }
    }
}
