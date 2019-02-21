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
	public partial class PagePrincipal : ContentPage
	{
		public PagePrincipal ()
		{
			InitializeComponent ();
		}

        private async void ButtonFacaPedidos_Clicked(object sender, EventArgs e)
        {
            var FacaPedidos = new PagePedidos();
            await Navigation.PushModalAsync(FacaPedidos);
        }

        private void ButtonAlugados_Clicked(object sender, EventArgs e)
        {

        }

        private async void ButtonSobre_Clicked(object sender, EventArgs e)
        {
            var Sobre = new Sobre();
            await Navigation.PushModalAsync(Sobre);
        }
    }
}