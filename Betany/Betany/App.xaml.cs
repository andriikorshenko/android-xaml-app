using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Betany
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new NavigationPageView());
            MainPage = new TabbedPageView();
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
