using AppUserProfile.Views.Menu;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppUserProfile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

#if DEBUG
#pragma warning disable CS0618 // Type or member is obsolete
            HotReloader.Current.Start(this);
#pragma warning restore CS0618 // Type or member is obsolete
#endif

            MainPage = new MenuPage();
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
