﻿/**********************************************************************
 * MainActivity.cs                                                    *
 * by Reagan Sensmeier                                                *  
 *                                                                    *
 * This file initializes the android implemntation and runs when the  *
 * application is first opened.                                       *
 * The application icon and theme are set here. Thi is where the app  *
 * is loaded onto the Android specific platform.                      *
 * This is code is mostly generated by Xamarin and Visual Studio      *
 **********************************************************************/
﻿
/************************************************/
/* First Activity When the App is opened        */
/*  This sets the application icon, theme,      */
/*  and layout                                  */         
/*  This file loads the app.                     */                
/************************************************/

using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Broke_v01.Droid
{
    [Activity(Label = "Broke_v01", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
    }
}
