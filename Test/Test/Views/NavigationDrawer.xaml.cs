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
                TabbedPage gotoTabbedPage = null;
                switch (e.Item.ToString())
                {
                    case "Home":
                        gotoTabbedPage = new Home();
                        gotoPage = null;
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
                if (gotoTabbedPage != null)
                {
                    Detail = new NavigationPage(gotoTabbedPage);
                }
                else
                {
                      Detail = new NavigationPage(gotoPage);        
                }
                ((ListView)sender).SelectedItem = null;
                this.IsPresented = false;
            };
            Detail = new NavigationPage(new Home());     
        }
    }
}