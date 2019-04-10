using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Broke_v01.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinanceTips : ContentPage
    {
        public FinanceTips()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            TipButt.Clicked += TipButt_Clicked;

        }
        private async void TipButt_Clicked(object sender, EventArgs e)
        {

            List<string> mylist = new List<string>(new string[] { "Stop spending money you don't have", "Have a savings plan", "Have a will" , "Don't be a dumbass", "Make your meals at home", "Stick to a budget", "Pay off your credit card debt", "Have a savings plan","Have a savings plan", "Have a no spend day"});
            await DisplayAlert("Here's a Tip", $" {mylist[randomTip()]}", "okay");
        }
        public int RandomTip()
        {
            Random random = new Random();
            int num = random.Next(10);
            return num;
        }

    }

}
