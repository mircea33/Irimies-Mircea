using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Test.Services;
using System.Linq;

namespace Test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JournalEntries : ContentPage
    {
        public JournalEntries()
        {
            InitializeComponent();
            //var connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            //connection.CreateTableAsync<JournalEntry>();
         //   itemList.ItemsSource = new JournalEntry[] {
 //new JournalEntry ("First", "1st item"),
 ///new JournalEntry ("Second", "2nd item"),
 //new JournalEntry ("Third", "3rd item")
 //};            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<JournalEntry>();
                var journalentry = conn.Table<JournalEntry>().ToList();
                JournalEntriesList.ItemsSource = journalentry;
            }
        }
        protected async void ItemTapped(object sender, ItemTappedEventArgs args)
        {
            var item = args.Item as JournalEntry;
           if (item == null) return;
            await Navigation.PushAsync(new DetailPageJournalEntries(item));
            JournalEntriesList.SelectedItem = null;
        }
        private async void gotojournaling(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Journaling());
        }
    }
}