using jcabezasS7.Services;
using jcabezasS7.Views;
using jcabezasS7.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jcabezasS7
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
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
