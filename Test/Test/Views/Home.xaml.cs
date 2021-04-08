using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Test.ModelViews; 

namespace Test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : TabbedPage
    {
        public Home()
        {
            InitializeComponent();
            this.ItemsSource = new Filozofii[] {
            new Filozofii ("Stoicism"),
            new Filozofii ("Taoism"),
            new Filozofii ("The greeks"),
            };       
           /*
            .ItemsSource = new Articles[] {
        new Articles {Title = "First", Article="1st item"},
        new Articles {Title = "Second", Article="2nd item"},
        new Articles {Title = "Third", Article="3rd item"}
        };

    }
    protected async void ItemTapped(object sender, ItemTappedEventArgs args)
    {
        var item = args.Item as Articles;
        if (item == null) return;
        await Navigation.PushAsync(new ArticlePage(item));
        ArticleList.SelectedItem = null;
    } */
        }
    }
}