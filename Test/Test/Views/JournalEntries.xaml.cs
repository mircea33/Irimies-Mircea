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
    public partial class JournalEntries : ContentPage
    {
        public JournalEntries()
        {
            InitializeComponent();
            itemList.ItemsSource = new JournalEntry[] {
 new JournalEntry {Title = "First", Writings="1st item"},
 new JournalEntry {Title = "Second", Writings="2nd item"},
 new JournalEntry {Title = "Third", Writings="3rd item"}
 };
        }
        protected async void ItemTapped(object sender, ItemTappedEventArgs args)
        {
            var item = args.Item as JournalEntry;
            if (item == null) return;
            await Navigation.PushAsync(new DetailPageJournalEntries(item));
            itemList.SelectedItem = null;
        }
    }
}