/*********************************************************************************
 * MasterPageItem.cs                                                             *           
 * by Reagan Sensmeier                                                           *                           
 *                                                                               *       
 * Menu Page Class Definition                                                    *
/*********************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace Broke_v01.MenuItem
{
    public class MasterPageItem
    {
        // Used in MainPage.xaml.cs to define each menu item
        public string Title { get; set; }           // Name shown on menu
        public string Icon { get; set; }            // Icon on side of menu title
        public Type TargetType { get; set; }        // What opens when a menu optioni is selected
    }
}
