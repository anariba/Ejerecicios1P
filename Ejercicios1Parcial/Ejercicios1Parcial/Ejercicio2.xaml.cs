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
    public partial class Ejercicio2 : ContentPage
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

       async private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            String nombre = TxNombre.Text;
            String apellido = TxApellido.Text;
            String edad = TxEdad.Text;
            String correo = TxCorreo.Text;

            var Contact = new Models.Contacto
            {
                Nombre = nombre,
                Apellidos = apellido,
                Edad = edad,
                Correo = correo

            };

            var pagina = new Result2();
            pagina.BindingContext = Contact;

            await Navigation.PushAsync(pagina);

        }
    }
}