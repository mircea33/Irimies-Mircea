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
    public partial class QuestionPage : CarouselPage
    {
        public QuestionPage()
        {
            InitializeComponent();
            SQLiteConnection conn = new SQLiteConnection(App.FilePath);
            ItemsSource = conn.Query<Questions>("SELECT * FROM Questions");
        }
    }
}