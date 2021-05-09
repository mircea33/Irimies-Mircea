﻿using System;
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
    public partial class DetailPageJournalEntries : ContentPage
    {
        public string nume;
        public DetailPageJournalEntries(JournalEntry item)
        {
            InitializeComponent();
            this.BindingContext = item;
            Title = item.Title;
        }

        private void ToolbarItem_Edit_Clicked(object sender, EventArgs e)
        {

        }

        private void ToolbarItem_Delete_Clicked(object sender, EventArgs e)
        {

        }
    }
}