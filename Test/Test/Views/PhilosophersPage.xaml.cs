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
    public partial class PhilosophersPage : ContentPage
    {
        public PhilosophersPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            PhilosophersList.ItemsSource = (System.Collections.IEnumerable)GetPhilosophers();
        }
        private IEnumerable<Philosophers> GetPhilosophers(string searchText = null)
        {
            List<Philosophers> philosopherentry;
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                philosopherentry = conn.Table<Philosophers>().ToList();
                PhilosophersList.ItemsSource = philosopherentry;
            }
            if (String.IsNullOrWhiteSpace(searchText))
                return (IEnumerable<Philosophers>)philosopherentry;
            return philosopherentry.Where(c => c.Philosopher.StartsWith(searchText));
        }
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            PhilosophersList.ItemsSource = (System.Collections.IEnumerable)GetPhilosophers(e.NewTextValue);
        }
        protected async void ItemTapped(object sender, ItemTappedEventArgs args)
        {
            var item = args.Item as Philosophers;
            if (item == null) return;
            await Navigation.PushAsync(new Philosophers_Detail_Page(item));
            PhilosophersList.SelectedItem = null;
        }
    }
}