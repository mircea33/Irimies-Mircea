using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Test.ModelViews; 

namespace Test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : TabbedPage
    {
        public Home()
        {
            InitializeComponent();
            this.ItemsSource = new Filozofii[] {
            new Filozofii ("Stoicism"),
            new Filozofii ("Taoism"),
            new Filozofii ("The greeks"),
            };
        }
    }
}