using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Test.ModelViews
{
    class NavigationDrawer
    {
        public static implicit operator Page(NavigationDrawer v)
        {
            throw new NotImplementedException();
        }
    }
}
