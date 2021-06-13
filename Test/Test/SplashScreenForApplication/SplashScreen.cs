using System;
using System.Collections.Generic;
using System.Text;
using Test.Views;
using Xamarin.Forms;

namespace Test.SplashScreenForApplication
{
    public class SplashScreen : ContentPage
    {
        Image splashImage;
        public SplashScreen()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                   Source = "SplashScreenImage.jpg",
                   WidthRequest = 100,
                   HeightRequest = 100
            };
            AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            sub.Children.Add(splashImage);
            this.Content = sub;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await splashImage.ScaleTo(1, 2000);
            await splashImage.ScaleTo(0.9, 1500, Easing.Linear);
            await splashImage.ScaleTo(0.9, 1500, Easing.Linear);
            Application.Current.MainPage = new NavigationDrawer();
        }
    }
}
