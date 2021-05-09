using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Test.Data;
using Test.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavoritesList : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public FavoritesList()
        {
            InitializeComponent();
        }
        private IEnumerable<Quotes> GetFavorites(string searchText = null)
        {
            List<Quotes> favoritequotes;   
                SQLiteConnection conn = new SQLiteConnection(Constants.DatabasePath);
                favoritequotes = conn.Query<Quotes>("SELECT * FROM Quotes WHERE Favorite = ?", "true");
                Favorites_List.ItemsSource = favoritequotes;
            if (String.IsNullOrWhiteSpace(searchText))
                return favoritequotes;
            return favoritequotes.Where(c => c.Quote.Contains(searchText));
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Favorites_List.ItemsSource = (System.Collections.IEnumerable)GetFavorites();
        }
  
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            Favorites_List.ItemsSource = (System.Collections.IEnumerable)GetFavorites(e.NewTextValue);
        }
        public async void RemoveClicked(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var item = (Quotes)mi.CommandParameter;
            SQLiteConnection conn = new SQLiteConnection(Constants.DatabasePath);
            conn.Query<Quotes>("UPDATE Quotes SET Favorite = ? WHERE Quote = ?", "false", item.Quote.ToString());
        }
        private void End_refreshing(object sender, EventArgs e)
        {
            GetFavorites();
            Favorites_List.ItemsSource = (System.Collections.IEnumerable)GetFavorites();
            Favorites_List.EndRefresh();
        }
    }
}
