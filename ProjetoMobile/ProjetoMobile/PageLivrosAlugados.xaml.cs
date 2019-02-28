﻿using System;
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
        }
    }
}