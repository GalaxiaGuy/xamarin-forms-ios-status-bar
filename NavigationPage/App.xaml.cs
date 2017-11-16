using System;

using Xamarin.Forms;

namespace NavigationPageBug
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var blackPage = new NavigationPage(new ContentPage { Title = "Black Bar - White Text"})
            {
                BarTextColor = Color.White,
                BarBackgroundColor = Color.Black,
            };
            var whitePage = new NavigationPage(new ContentPage { Title = "White Bar - Black Text"} )
            {
                BarTextColor = Color.Black,
                BarBackgroundColor = Color.White,
            };

            var pushButton = new Button { Text = "Push Modal", Command = new Command(async _ => await MainPage.Navigation.PushModalAsync(whitePage)) };
            var popButton = new Button { Text = "Pop Modal", Command = new Command(async _ => await MainPage.Navigation.PopModalAsync()) };

            ((ContentPage)blackPage.CurrentPage).Content = pushButton;
            ((ContentPage)whitePage.CurrentPage).Content = popButton;

            MainPage = blackPage;
        }
    }
}
