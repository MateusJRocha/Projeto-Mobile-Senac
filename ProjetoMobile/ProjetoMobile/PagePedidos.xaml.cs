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
	public partial class PagePedidos : ContentPage
	{
		public PagePedidos ()
		{
			InitializeComponent ();
		}

        private void ViewCell_Tapped(object sender, EventArgs e)
        {

        }
    }
}