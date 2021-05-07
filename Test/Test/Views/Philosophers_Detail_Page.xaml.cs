using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Data;
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
            SQLiteConnection conn = new SQLiteConnection(Constants.DatabasePath);
            ItemsSource = conn.Query<Quotes>("SELECT * FROM Quotes where Philosopher = ?", item.Philosopher);
        }
    }
}