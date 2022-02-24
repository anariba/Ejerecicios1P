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
    public partial class Ejercicio1 : ContentPage
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

    



       async private void btnsuma_Clicked(object sender, EventArgs e)
        {

              var num1 = Convert.ToInt32(txnum1.Text);
               var num2 = Convert.ToInt32(txnum1.Text);
               var Result = 0;

              // int V = int.Parse(num1.ToString());

               Result = num1 + num2;



            var Contact = new Models.FuncionesMatematicas
            {

                suma = Result

            };

            var pagina = new Result();
            pagina.BindingContext = Contact;

            await Navigation.PushAsync(pagina);

        }

        async private void btnresta_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(txnum1.Text);
            var num2 = Convert.ToInt32(txnum1.Text);
            var Result = 0;
           
            // int V = int.Parse(num1.ToString());

            Result = num1 - num2;



            var Contact = new Models.FuncionesMatematicas
            {

                suma = Result

            };

            var pagina = new Result();
            pagina.BindingContext = Contact;

            await Navigation.PushAsync(pagina);

        }

       async private void btndivision_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(txnum1.Text);
            var num2 = Convert.ToInt32(txnum1.Text);
            var Result = 0;

            // int V = int.Parse(num1.ToString());

            Result = num1 / num2;



            var Contact = new Models.FuncionesMatematicas
            {

                suma = Result

            };

            var pagina = new Result();
            pagina.BindingContext = Contact;

            await Navigation.PushAsync(pagina);

        }

       async private void btnmuntiplicacion_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(txnum1.Text);
            var num2 = Convert.ToInt32(txnum1.Text);
            var Result = 0;

            // int V = int.Parse(num1.ToString());

            Result = num1 * num2;



            var Contact = new Models.FuncionesMatematicas
            {

                suma = Result

            };

            var pagina = new Result();
            pagina.BindingContext = Contact;

            await Navigation.PushAsync(pagina);

        }
    }

}