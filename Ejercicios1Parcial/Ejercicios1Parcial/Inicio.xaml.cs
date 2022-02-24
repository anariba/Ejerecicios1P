using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicios1Parcial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Opcion1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ejercicio1());
        }

        private void Opcion2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ejercicio2());
        }

        private void Opcion3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ejercicio3());
        }
    }
}