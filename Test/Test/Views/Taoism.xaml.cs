using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Test.Data;
using Test.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Taoism : CarouselPage
    {
        public Taoism()
        {
            InitializeComponent();
            SQLiteConnection conn = new SQLiteConnection(Constants.DatabasePath);
            ItemsSource = conn.Query<Quotes>("SELECT * FROM Quotes where Philosophy = ?", "Taoism");
        }
    }
}