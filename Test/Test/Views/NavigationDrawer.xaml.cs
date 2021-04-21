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
            string[] myPageNames = { "Home", "Taoism","Stoicism","Ancient Greece", "Journaling","Questions"};
            menu.ItemsSource = myPageNames;
            menu.ItemTapped += (sender, e) =>
            {
                ContentPage gotoPage = null;
                CarouselPage gotoCarrouselPage = null;
                switch (e.Item.ToString())
                {
                    case "Taoism":
                        gotoCarrouselPage = new Home();
                        break;
                    case "Stoicism":
                        gotoPage = new MeditationTimer();
                        break;
                    case "Ancient Greece":
                        gotoPage = new MeditationTimer();
                        break;
                    case "Meditation time":
                        gotoPage = new MeditationTimer();
                        break;
                    case "Journaling":
                        gotoPage = new JournalEntries();
                        break;
                    case "Questions":
                        gotoPage = new Questions();
                        break;
                    default:
                        gotoCarrouselPage = new Home();
                        break;
                }
                if (gotoCarrouselPage != null)
                {
                    Detail = new NavigationPage(gotoCarrouselPage);
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