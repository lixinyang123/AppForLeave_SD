using System;
using Xamarin.Forms;

namespace App1.Views
{
    public partial class LeaveList : ContentPage
    {
        private readonly App app;

        public LeaveList(App app)
        {
            this.app = app;
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, System.EventArgs e)
        {
            app.MainPage = new LeaveDetail(app);
        }

        private void ImageButton_Clicked_1(object sender, System.EventArgs e)
        {
            app.MainPage = new MainPage(app);
        }

        private void ImageButton_Clicked_2(object sender, System.EventArgs e)
        {
            app.Name = string.Empty;
            app.Teacher = string.Empty;
            app.Date = DateTime.Now;
            app.MainPage = new Configuration(app);
        }

        protected override bool OnBackButtonPressed()
        {
            app.MainPage = new MainPage(app);
            return true;
        }

    }
}