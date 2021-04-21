using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Test.ModelViews;
using Test.Data;
using SQLite;
using Test.Data;
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

            using (var conn = new SQLiteConnection(Constants.DatabasePath))
            {
                ItemsSource = conn.Table<Philosophers>().ToList();
            }
            // this.ItemsSource = (System.Collections.IEnumerable)baza_de_date.Database.Table<Quotes>().ToListAsync();
             

            // private void Button_Clicked(object sender, EventArgs e)
            // {
            //      string[] a = new string[] { "this is the first quote", "second quote","third quote" };

            // }
        }
    }
}