using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Minutes
{
    public partial class App : Application
    {
        public static IEntryStore Entries { get; set; }

        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new EntriesPage();

            Entries = new MemoryEntryStore();

            Entries.LoadMockData();
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
