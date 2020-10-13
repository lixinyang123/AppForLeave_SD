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

        public App()
        {
            InitializeComponent();

            MainPage = new Configuration(this);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
