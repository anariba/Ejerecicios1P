using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//using Ejercicios1Parcial.Models;

namespace Ejercicios1Parcial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ejercicio3 : ContentPage
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private  void ToolbarItem_Clicked(object sender, EventArgs e)
        {
          

           Navigation.PushAsync( new Agregar());

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ListaEmpleados.ItemsSource = await App.DB.listaempleados();
        }

        private async void ListaEmpleados_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Contact2 item = (Contact2)e.SelectedItem;
            var newpage = new Agregar();
            newpage.BindingContext = item;
            await Navigation.PushAsync(newpage);
        }
    }
}