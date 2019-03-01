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
	public partial class PageLivrosAlugados : ContentPage
	{
		public PageLivrosAlugados ()
		{
			InitializeComponent ();

            
            var label = new Label
            {
                Text = PageLivro2.Nome,
                TextColor = Color.White,
                FontSize = 18
                
                
            };

            Content = label;

            var label1 = new Label
            {
                Text = PageLivro1.Nome,
                TextColor = Color.White,
                FontSize = 18


            };

            Content = label1;

            var label2 = new Label
            {
                Text = PageLivro3.Nome,
                TextColor = Color.White,
                FontSize = 18


            };

            Content = label2;
        }
    }
}