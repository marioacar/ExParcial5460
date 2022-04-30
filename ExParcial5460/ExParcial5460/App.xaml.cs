using ExParcial5460.View5460;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExParcial5460
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Register5460());
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
