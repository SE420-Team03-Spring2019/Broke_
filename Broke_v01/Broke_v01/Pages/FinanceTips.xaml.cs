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
            List<string> mylist = new List<string>(new string[] { "Stop spending money you don't have", "Have a savings plan", "Have a will" });
            await DisplayAlert("Here's a Tip", $" {mylist[0]}", "okay");
        }
        public int randomTip()
        {
            return;
        }

    }

}
