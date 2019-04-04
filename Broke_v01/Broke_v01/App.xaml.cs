/**********************************************************************/
/* This file sets up the Main Page of the App                         */
/* This file will also decribe what the App will do on the following: */
/*      App Start Up, Sleep, and Resume                               */
/**********************************************************************/
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Broke_v01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Broke_v01.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
