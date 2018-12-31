using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsCustomToolbar.Controls;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinForms_CustomToolbar
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Padding = new Thickness(50),
                    Children = {
                       new Button
                       {
                           Text = "My Button",
                           BackgroundColor = Color.DodgerBlue,
                           TextColor = Color.White
                       },
                       new RoundCornersButton()
                       {
                           Text = "Round Corner Button",
                           BorderWidth  =2,
                           BorderColor = Color.Black,
                           BackgroundColor=Color.White,
                           TextColor=Color.Black
                       },
                       new Label
                       {
                           Text = "First Label"
                       }
                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
