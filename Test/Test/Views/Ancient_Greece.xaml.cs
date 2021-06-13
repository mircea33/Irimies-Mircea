using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ancient_Greece : CarouselPage
    {
        public Ancient_Greece()
        {
            InitializeComponent();         
            SQLiteConnection conn = new SQLiteConnection(App.FilePath);
            ItemsSource = conn.Query<Quotes>("SELECT * FROM Quotes where Philosophy = ?","The greeks");
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