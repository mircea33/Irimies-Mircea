using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            LoginButton.Clicked += async (sender, args) =>
            {
                await Navigation.PushModalAsync(new NavigationDrawer());
                
            };
            SignupButton_LoginPage.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Signup()); 
            };
        }
    }
}