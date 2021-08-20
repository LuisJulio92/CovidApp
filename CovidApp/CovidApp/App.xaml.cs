using CovidApp.PageModels;
using FreshMvvm;
using Xamarin.Forms;

namespace CovidApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = FreshPageModelResolver
            //   .ResolvePageModel<MainViewModel>();


            var tabbed = new FreshTabbedNavigationContainer();
            tabbed.AddTab<MainPageModel>("world", null);
            //tabbed.AddTab<WorldPageModel>("General", null);
            MainPage = tabbed;
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
