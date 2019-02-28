using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoMobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageLivro2 : ContentPage
	{
        public static string Nome { get; set; } = "";
		public PageLivro2 ()
		{
			InitializeComponent ();
		}

        private void ButtonConfirmar_Clicked(object sender, EventArgs e)
        {
            Nome = labelNome.Text;
            DisplayAlert(null, "Alugado", "Ok");
        }
    }
}