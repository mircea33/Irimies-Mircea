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
                favoritequotes = conn.Query<Quotes>("SELECT * FROM Quotes where Favorite = ?", "true");
                Favorites_List.ItemsSource = favoritequotes;
            
            if (String.IsNullOrWhiteSpace(searchText))
                return favoritequotes;
            return favoritequotes.Where(c => c.Quote.StartsWith(searchText));
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Favorites_List.ItemsSource = (System.Collections.IEnumerable)GetFavorites();
        }
        protected async void ItemTapped(object sender, ItemTappedEventArgs args)
        {
            var item = args.Item as Quotes;
            if (item == null) return;
            await Navigation.PushAsync(new Favorites(item));
    //        FavoritesList.SelectedItem = null;
        }
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            Favorites_List.ItemsSource = (System.Collections.IEnumerable)GetFavorites(e.NewTextValue);
        }
    }
}
