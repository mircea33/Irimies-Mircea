using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Test.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListAllQuotes : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ListAllQuotes()
        {
            InitializeComponent();
        }

        private IEnumerable<Quotes> GetQuotes(string searchText = null)
        {
            List<Quotes> quotes;
            SQLiteConnection conn = new SQLiteConnection(App.FilePath);
            quotes = conn.Query<Quotes>("SELECT * FROM Quotes");
            Quotes_List.ItemsSource = quotes;
            if (String.IsNullOrWhiteSpace(searchText))
                return quotes;
            return quotes.Where(c => c.Quote.Contains(searchText));
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Quotes_List.ItemsSource = (System.Collections.IEnumerable)GetQuotes();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            Quotes_List.ItemsSource = (System.Collections.IEnumerable)GetQuotes(e.NewTextValue);
        }
        protected async void ItemTapped(object sender, ItemTappedEventArgs args)
        {
            var item = args.Item as Quotes;
            string action;
            if (item.Favorite == "false")
            {
                action = await DisplayActionSheet("Would you like to add this quote to favorites ?", "No", "Yes");
                if (action == "Yes")
                {
                    SQLiteConnection conn = new SQLiteConnection(App.FilePath);
                    conn.Query<Quotes>("UPDATE Quotes SET Favorite = ? WHERE Quote = ?", "true", item.Quote.ToString());
                }
            }
            else
            {
                action = await DisplayActionSheet("Would you like to remove this app from favorites ?", "No", "Yes");
                if (action == "Yes")
                {
                    SQLiteConnection conn = new SQLiteConnection(App.FilePath);
                    conn.Query<Quotes>("UPDATE Quotes SET Favorite = ? WHERE Quote = ?", "false", item.Quote.ToString());
                }
            }
        }
    }
 }