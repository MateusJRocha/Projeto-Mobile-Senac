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
	public partial class PagePedidos : ContentPage
	{
		public PagePedidos ()
		{
			InitializeComponent ();
		}

        private async void ViewCell_Tapped(object sender, EventArgs e)
        {
            var Livro1 = new PageLivro1();
            await Navigation.PushModalAsync(Livro1);
        }

        private async void ViewCell_Tapped_1(object sender, EventArgs e)
        {
            var Livro2 = new PageLivro2();
            await Navigation.PushModalAsync(Livro2);
        }

        private async void ViewCell_Tapped_2(object sender, EventArgs e)
        {
            var Livro3 = new PageLivro3();
            await Navigation.PushModalAsync(Livro3);
        }
    }
}