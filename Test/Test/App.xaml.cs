﻿using System;
using Test.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationDrawer();
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
