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
       //     new DataBase_Quotes();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection conn = new SQLiteConnection(Constants.DatabasePath))
            {
                ItemsSource = conn.Table<Quotes>().ToList();
            }
        }   
    }
}