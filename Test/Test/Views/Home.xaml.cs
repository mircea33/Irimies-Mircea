using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.IO;
using System.Reflection;

namespace Test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : CarouselPage
    {
        public Home()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            List<Quotes> quotes_list;
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                quotes_list = conn.Table<Quotes>().ToList();
                var rnd = new Random();
                var randomized = quotes_list.OrderBy(item => rnd.Next());
                ItemsSource = randomized;
            }
        }
        private void Add_to_Favorites_Button_Clicked(object sender, EventArgs e)
        {
            var mi = ((Button)sender);
            var item = (Quotes)mi.CommandParameter;
            if (item.Favorite == "false")
            {
                SQLiteConnection conn = new SQLiteConnection(App.FilePath);
                conn.Query<Quotes>("UPDATE Quotes SET Favorite = ? WHERE Quote = ?", "true", item.Quote.ToString());
            }
        }
    }
}