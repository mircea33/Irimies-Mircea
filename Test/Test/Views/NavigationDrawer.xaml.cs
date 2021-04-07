using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationDrawer : MasterDetailPage
    {
        public NavigationDrawer()
        {
            InitializeComponent();
            string[] myPageNames = { "Home", "Meditation time", "Journaling","Journal Entries", "Questions","Log out" };
            menu.ItemsSource = myPageNames;
            menu.ItemTapped += (sender, e) =>
            {
                ContentPage gotoPage;
                switch (e.Item.ToString())
                {
                    case "Home":
                        gotoPage = new Login();
                        break;
                    case "Meditation time":
                        gotoPage = new Login();
                        break;
                    case "Journaling":
                        gotoPage = new Journaling();
                        break;
                    case "Journal Entries":
                        gotoPage = new JournalEntries();
                        break;
                    case "Questions":
                        gotoPage = new Questions();
                        break;
                    case "Log out":
                        gotoPage = new Login();
                        break;
                    default:
                        gotoPage = new Login();
                        break;
                }
                Detail = new NavigationPage(gotoPage)
                {
                    BarBackgroundColor = Color.SaddleBrown

                };
                ((ListView)sender).SelectedItem = null;
                this.IsPresented = false;
            };
            Detail = new NavigationPage(new Home())
            {
                BarBackgroundColor = Color.SaddleBrown
            };
        }
    }
}