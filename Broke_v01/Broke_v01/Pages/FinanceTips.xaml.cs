/*********************************************
 * This file handles the finance tips page   *
 * When the button is clicked it generates   *
 * a random finacial tip from a list of tips.*
 * *****************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
// Create the page class.
namespace Broke_v01.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinanceTips : ContentPage
    {
        public FinanceTips()
        {
            InitializeComponent();
        }
        // Make the button and recognize the click.
        protected override void OnAppearing()
        {
            TipButton.Clicked += TipButton_Clicked;

        }
        // What to do when a button is clicked.
        private async void TipButton_Clicked(object sender, EventArgs e)
        {
            // A list of strings that have the tips.
            List<string> mylist = new List<string>(new string[] { "Stop spending money you don't have"
            , "Have a savings plan", "Have a will" , "Don't be dumb and save your money", "Make your meals " +
            "at home", "Stick to a budget", "Pay off your credit card debt", "Have a savings plan","Have a " +
            "savings plan", "Have a no spend day", "List out your debt", "Pay more than the minimum on your" +
            "credit card","Calculate your daily interest", "Automate your savings", " Do an annual review", 
            "Write down your goals", "Create a file for taxes", "Plan fast meals", "Up your retirement contribution",
            "Use cash in certain budget categories","Update your beneficiaries", "Check your credit report", 
            "Calculate your net worth", "Avoid Student Loans (When Possible)", "Spend Less Than You Earn"});
            // Display a message with a random tip.
            await DisplayAlert("Here's a Tip", $" {mylist[RandomTip()]}", "okay");
        }
        // Function that chooses a random number from 10 possible choices.
        public int RandomTip()
        {
            Random random = new Random();
            int num = random.Next(25);
            return num;
        }

    }

}
