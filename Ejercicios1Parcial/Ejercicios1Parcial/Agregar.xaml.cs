using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ejercicios1Parcial.Models;

namespace Ejercicios1Parcial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Agregar : ContentPage
    {
        public Agregar()
        {
            InitializeComponent();
        }

      

        private async void Add_Clicked(object sender, EventArgs e)
        {
            var contac = new Contact2

            {
                Nombre = Nombre.Text,
                Apellido = apellido.Text,
                Edad = Convert.ToInt32(Edad.Text),
                Correo = correo.Text,
                Direccion = direccion.Text



            };

           var resultado = await App.DB.guardar(contac);

            if(resultado != 0)
                await DisplayAlert("Aviso","Ingresado con exito","OK");
            else
                await DisplayAlert("Aviso", "Error", "OK");

            await Navigation.PopAsync();
        }

        private async void btnEliminar_Clicked(object sender, EventArgs e)
        {
            var contac = new Contact2

            {
                codigo = Convert.ToInt32(codigo.Text),
       



            };
            var Resultado = await App.DB.borrar(contac);

            if (Resultado != 0)
            
                await DisplayAlert("Aviso", "Borrado con exito", "OK");
            else 
                await DisplayAlert("Aviso", "Error", "OK");

            await Navigation.PopAsync();

        }
    }
}