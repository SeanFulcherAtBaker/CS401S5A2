using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DistinguishingViewsWithID
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new SimplestKeypadPage();
        }

       
    }
}
