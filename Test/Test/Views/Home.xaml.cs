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

        public  Home()
        {
            InitializeComponent();
            /*
            string DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Data_base.db");
            Assembly assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
            Stream embeddedDatabaseStream = assembly.GetManifestResourceStream("Test.Data_base.db");
            if(!File.Exists(DatabasePath))
            {
                FileStream fileStreamToWrite = File.Create(DatabasePath);
                embeddedDatabaseStream.Seek(0, SeekOrigin.Begin);
                embeddedDatabaseStream.CopyTo(fileStreamToWrite);
                fileStreamToWrite.Close();
            }
            SQLiteAsyncConnection Database = new SQLiteAsyncConnection(DatabasePath);
            ItemsSource = (System.Collections.IEnumerable)Database.Table<Quotes>().ToListAsync();
            //using (var conn = new SQLiteConnection(Constants.DatabasePath))
            //{
             //   ItemsSource = conn.Table<Quotes>().ToList();
            //}
            */
        }
    }
}