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
    public partial class Philosophers_Detail_Page : CarouselPage
    {
        public Philosophers_Detail_Page(Models.Philosophers item)
        {
            InitializeComponent();
            Title = item.Philosopher;
            SQLiteConnection conn = new SQLiteConnection(App.FilePath);
            ItemsSource = conn.Query<Quotes>("SELECT * FROM Quotes where Philosopher = ?", item.Philosopher);
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