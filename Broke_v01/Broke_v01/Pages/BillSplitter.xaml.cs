/****************************************************/
/* Bill Splitter Feature                            */
/* By Sabrina Nunn                                  */
/*                                                  */
/* Below are the inputs from the user for this code */
/*  The total cost of the bill (positive float)     */
/*  The number of people (positive integer)         */
/*  The tip percentage (integer from slider scale   */
/*                                                  */
/* Outputs the amount each person owes              */
/****************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Broke_v01.Pages
{
    public partial class BillSplitter : ContentPage
    {

        public BillSplitter()
        {
            InitializeComponent();
        }

        // When the button is clicked go to CalculateButtonClicked()
        protected override void OnAppearing()
        {
            CalculateButton.Clicked += CalculateButtonClicked;
        }

        // When the slider position is changed, print it's value
        private void SliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = Math.Floor(args.NewValue);
            SliderLabel.Text = String.Format("{0}", value);
        }

        // When the button is clicked
        private void CalculateButtonClicked(object sender, EventArgs e)
        {
            // Get the values the user input
            string billText = InputBillCost.Text;
            string tipText = SliderLabel.Text;
            string numPeopleText = InputNumPeople.Text;

            float billCost;
            float tip;
            int numPeople;

            // If the Bill Cost is a float and greater than 0
            if (float.TryParse(billText, out billCost) && billCost > 0)
            {
                // Clear the input error message for bill cost
                ErrorBill.Text = " ";

                // If the Number of people is a positive integer
                if (int.TryParse(numPeopleText, out numPeople) && numPeople > 0)
                {
                    // Clear the input error message for the number of people
                    ErrorPeople.Text = " ";

                    // Get the tip percentage
                    float.TryParse(tipText, out tip);
                    float owedAmount;
                    float tipPercent = tip / 100;

                    // Calculate the amount owed per person
                    owedAmount = ((tipPercent * billCost) + billCost) / numPeople;

                    // Display the result
                    IntroForValue.Text = "Amount Owed Per Person: ";
                    OutputAmountOwed.Text = owedAmount.ToString("C");
                }

                // Error message if the number of people entered was not a positive whole number
                else
                {
                    ErrorPeople.Text = "Error: Number of people must be a positive whole number. ";
                }
            }

            // If the valu efor the cost of the bill was not a positive float
            else
            {
                // Error message
                ErrorBill.Text = "Error: Bill Amount must be a positive value. ";

                // Check if there is an error with the input for number of people 
                if (int.TryParse(numPeopleText, out numPeople) && numPeople > 0)
                {
                    // If no error, clear the error message
                    ErrorPeople.Text = " ";
                }

                // Error for the number of people, display error message
                else
                {
                    ErrorPeople.Text = "Error: Number of people must be a positive whole number.";
                }
            }
        }
    }
}
