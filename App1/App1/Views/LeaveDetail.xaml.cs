using System;
using Xamarin.Forms;

namespace App1.Views
{
    public partial class LeaveDetail : ContentPage
    {
        private readonly App app;

        public LeaveDetail(App app)
        {
            this.app = app;
            InitializeComponent();

            startTime.Text = app.Date.AddDays(-1)
                .ToString("MM-dd 06:00").ToString();

            endTime.Text = app.Date.AddDays(1)
                .ToString("MM-dd 21:00").ToString();

            name.Text = app.Name;
            teacherName.Text = $"一级：[辅导员]{app.Teacher} - 审批";

            applyTime.Text = app.Date
                .AddDays(-3)
                .AddHours(new Random().Next(10,15))
                .AddMinutes(new Random().Next(59))
                .ToString("MM-dd HH:mm").ToString();

            passTime.Text = app.Date
                .AddDays(-3)
                .AddHours(new Random().Next(15, 20))
                .AddMinutes(new Random().Next(59))
                .ToString("MM-dd HH:mm").ToString();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            app.MainPage = new LeaveList(app);
        }
    }
}