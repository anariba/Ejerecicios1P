using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ejercicios1Parcial.Models;
using System.IO;

namespace Ejercicios1Parcial
{
    public partial class App : Application
    {

        static DataBase basedatos;

        public static DataBase DB
        {
            get
            {
                if (basedatos == null)
                {
                    basedatos = new DataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DataBase.db3"));
                }
                return basedatos;
            }
        }





        public App()
        {
            InitializeComponent();

           
            MainPage = new NavigationPage(new Inicio());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
