﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;




namespace Login_Kit
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Splash_screen());
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