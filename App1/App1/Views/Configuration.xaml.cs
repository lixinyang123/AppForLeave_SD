using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Configuration : ContentPage
    {
        private readonly App app;

        public Configuration(App app)
        {
            this.app = app;
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(student.Text == null || teacher.Text == null)
            {
                return;
            }

            if(autoTime.IsChecked)
            {
                app.Date = DateTime.Now;
            }
            else
            {
                app.Date = datePicker.Date;
            }

            app.Name = student.Text;
            app.Teacher = teacher.Text;

            app.MainPage = new MainPage(app);
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            datePicker.IsVisible = !e.Value;
        }
    }
}