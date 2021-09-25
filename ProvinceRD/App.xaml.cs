using ProvinceRD.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProvinceRD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ProvincePage();
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
