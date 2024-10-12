using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Maui.Controls;

namespace Act_2_Real
{
    public partial class Maestro : ContentPage
    {
        public Maestro()
        {
            InitializeComponent();
        }

        public void NavigationToPage(ContentPage nuevaPagina)
        {
            App.FlyoutPage.Detail.Navigation.PushAsync(nuevaPagina);
        }

        
        public void OcultarDetalles()
        {
            App.FlyoutPage.IsPresented = false;
        }

       
    }
}
