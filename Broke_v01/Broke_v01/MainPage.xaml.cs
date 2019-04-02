﻿using Broke_v01.MenuItem;
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
            MenuList = new List<MasterPageItem>();

            //this are for android Icons you can download from android asset studio and include in Your Project Resources Folder
            // Creating our pages for menu navigation
            // Here you can define title for item, 
            // icon on the left side, and page that you want to open after selection
            var page1 = new MasterPageItem() { Title = "Bill Splitter", Icon = "ic_local_shipping_black_24dp.png", TargetType = typeof(BillSplitter) };
            var page2 = new MasterPageItem() { Title = "Budget", Icon = "ic_restaurant_black_24dp", TargetType = typeof(BudgetPlanner) };
            var page3 = new MasterPageItem() { Title = "Tips", Icon = "ic_local_pizza_black_24dp.png", TargetType = typeof(FinanceTips) };
            var page4 = new MasterPageItem() { Title = "Grocery List", Icon = "ic_local_dining_black_24dp.png", TargetType = typeof(GrocereyList) };
            var page5 = new MasterPageItem() { Title = "Loans", Icon = "ic_local_parking_black_24dp.png", TargetType = typeof(LoanTracker) };
            var page6 = new MasterPageItem() { Title = "Savings", Icon = "ic_my_location_black_24dp.png", TargetType = typeof(SavingsTracker) };

            // Adding menu items to MenuList
            MenuList.Add(page1);
            MenuList.Add(page2);
            MenuList.Add(page3);
            MenuList.Add(page4);
            MenuList.Add(page5);
            MenuList.Add(page6);

            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = MenuList;

            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ViewMain)));
            this.BindingContext = new
            {
                Header = "",
                Image = "http://www3.hilton.com/resources/media/hi/GSPSCHF/en_US/img/shared/full_page_image_gallery/main/HH_food_22_675x359_FitToBoxSmallDimension_Center.jpg",
                //Footer = "         -------- Welcome To HotelPlaza --------           "
                Footer = "Welcome To Broke"
            };
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }

    }

}