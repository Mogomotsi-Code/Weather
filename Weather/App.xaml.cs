using Prism;
using Prism.Ioc;
using Prism.Unity;
using Weather.Constants;
using Weather.Services;
using Weather.Services.Interfaces;
using Weather.ViewModels;
using Weather.Views;
using Xamarin.Forms;

namespace Weather
{
    public partial class App  : PrismApplication
    {
        public App(IPlatformInitializer initializer = null)
           : base(initializer)
        {
        }

        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await  NavigationService.NavigateAsync(new System.Uri($"/{Pages.NAVIGATION_PAGE}/{Pages.MAIN_PAGE}"));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IWeatherService, WeatherService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
           
            containerRegistry.RegisterForNavigation<MainPage, MainPageviewModel>();
            containerRegistry.RegisterForNavigation<ForeCastDetailsPage, ForeCastDetailsPageViewModel>();
        }

    }
}
