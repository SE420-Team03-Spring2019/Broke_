﻿/*********************************************************************************
 * MainPaige.xaml.cs                                                             *           
 * by Reagan Sensmeier                                                           *                           
 *                                                                               *       
 * This file describes what happens after an action by the user on the Main Page *
 *  Creation of the menu and navigation is done in this file                     *                   
 *  Icons created by Freepik for ww.flaticon.com                                 *
/*********************************************************************************/

using Broke_v01.MenuItem;
using Broke_v01.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Broke_v01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> MenuList { get; set; }
        public MainPage()
        {
            InitializeComponent();
            // Create Menu Item List 
            MenuList = new List<MasterPageItem>();

            // Defines each item in the menu, its icon, and what page is opened when that item is selected.
            // Icons are open source images saved to the android project resource folder
            var page1 = new MasterPageItem() { Title = "Bill Splitter", Icon = " ", TargetType = typeof(BillSplitter) };
            var page2 = new MasterPageItem() { Title = "Budget", Icon = " ", TargetType = typeof(BudgetPlanner) };
            var page3 = new MasterPageItem() { Title = "Tips", Icon = " ", TargetType = typeof(FinanceTips) };
            var page4 = new MasterPageItem() { Title = "Grocery List", Icon = " ", TargetType = typeof(GrocereyList) };
            var page5 = new MasterPageItem() { Title = "Loans", Icon = " ", TargetType = typeof(LoanTracker) };
            var page6 = new MasterPageItem() { Title = "Savings", Icon = " ", TargetType = typeof(SavingsTracker) };

            // Creates the pages that will open after a menu selection
            MenuList.Add(page1);
            MenuList.Add(page2);
            MenuList.Add(page3);
            MenuList.Add(page4);
            MenuList.Add(page5);
            MenuList.Add(page6);

            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = MenuList;

            // initializes page to page navigation in the menu
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ViewMain)));
            this.BindingContext = new
            {
                Header = "",
                Footer = "Welcome To Broke"
            };
        }

        // Function that creates and instance of a page when the page is selected 
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }

    }

}