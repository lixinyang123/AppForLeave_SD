using App1.Views;
using System;
using Xamarin.Forms;

namespace App1
{
    public partial class App : Application
    {
        public string Name { get; set; }

        public string Teacher { get; set; }

        public DateTime Date { get; set; }

        public Page LastPage { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new Configuration(this);
        }

        protected override void OnStart()
        {
            if (LastPage != null)
            {
                MainPage = LastPage;
                LastPage = null;
            }
        }

        protected override void OnSleep()
        {
            LastPage = MainPage;
        }

        protected override void OnResume() { }
    }
}
