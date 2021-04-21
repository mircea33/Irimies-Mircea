﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Linq;

namespace Test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Journaling : ContentPage
    {
        public Journaling()
        {
            InitializeComponent();
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            JournalEntry journalentry = new JournalEntry();
            journalentry.Title = TitleEntry.Text;
            journalentry.Writings = WritingsEditor.Text;
                //new JournalEntry(TitleEntry.Text, WritingsEditor.Text);
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<JournalEntry>();
                conn.Insert(journalentry);
            }
            await Navigation.PopModalAsync();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<JournalEntry>();
                var journalentry = conn.Table<JournalEntry>().ToList();
            }
        }
    }
}