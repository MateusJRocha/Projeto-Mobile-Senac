using ProjetoMobile.Droid;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoMobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageCadastro : ContentPage
	{
        private SQLiteAsyncConnection conexao;
        private ObservableCollection<Usuarios> usuarios;
		public PageCadastro ()
		{
			InitializeComponent ();
            conexao = DependencyService.Get<ISQLite>().AcessarDB();
		}

        private void ButtonNovoCadastro_Clicked(object sender, EventArgs e)
        {
            string senha1 = entrySenha.Text;
            string senha2 = entrySenha2.Text;

            if (senha1 == senha2)
            {
                if (String.IsNullOrEmpty(entryNomeCompleto.Text) ||
                    String.IsNullOrEmpty(entryEndereco.Text) ||
                    String.IsNullOrEmpty(entryEmail.Text) ||
                    String.IsNullOrEmpty(entrySenha.Text) ||
                    String.IsNullOrEmpty(entrySenha2.Text) ||
                    String.IsNullOrEmpty(entryTelefone.Text))
                {
                    DisplayAlert(null, "Não deixe os campos em branco", "OK");
                }
                else
                {
                    var u = new Usuarios
                    {
                        ID = new Guid(),
                        Nome = entryNomeCompleto.Text,
                        Endereco = entryEndereco.Text,
                        Email = entryEmail.Text,
                        Senha = entrySenha.Text,
                        Senha2 = entrySenha2.Text,
                        Telefone = entryTelefone.Text
                    };

                    conexao.InsertAsync(usuarios);
                    usuarios.Add(u);

                    DisplayAlert(null, "Cadastro efetuado com secesso", "OK");
                }
            }
            else
            {
                DisplayAlert(null, "SENHAS DIFERENTES", "OK");
            }
        }
    }
}