using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Test.Models;
namespace Test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationDrawer : MasterDetailPage
    {
        public NavigationDrawer()
        {
            InitializeComponent();
            var template = new DataTemplate(typeof(TextCell));
            template.SetValue(TextCell.TextColorProperty, Color.White);
            template.SetBinding(TextCell.TextProperty, ".");
            string[] myPageNames = {"Home", "Taoism","Stoicism","Ancient Greece","Philosophers","Journaling","Self-Measuring Questions", "Favorites","Quotes"};
            menu.ItemTemplate = template;
            menu.ItemsSource = myPageNames;  
            menu.ItemTapped += (sender, e) =>
            {
                ContentPage gotoPage = null;
                CarouselPage gotoCarrouselPage = null;
                switch (e.Item.ToString())
                {
                    case "Home":
                        gotoCarrouselPage = new Home();
                        break;
                    case "Taoism":
                        gotoCarrouselPage = new Taoism();
                        break;
                    case "Stoicism":
                        gotoCarrouselPage = new Stoicism();
                        break;
                    case "Ancient Greece":
                        gotoCarrouselPage = new Ancient_Greece();
                        break;
                    case "Meditation time":
                        gotoPage = new JournalEntries();
                        break;
                    case "Journaling":
                        gotoPage = new JournalEntries();
                        break;
                    case "Philosophers":
                        gotoPage = new PhilosophersPage();
                        break;
                    case "Self-Measuring Questions":
                        gotoCarrouselPage = new QuestionPage();
                        break;
                    case "Favorites":
                        gotoPage = new FavoritesList();
                        break;
                    case "Quotes":
                        gotoPage = new ListAllQuotes();
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