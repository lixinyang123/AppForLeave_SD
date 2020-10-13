using System;
using Xamarin.Forms;

namespace App1.Views
{
    public partial class MainPage : ContentPage
    {
        private readonly App app;

        public MainPage(App app)
        {
            this.app = app;
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            app.MainPage = new LeaveList(app);
        }
    }
}
