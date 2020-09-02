using Prism;
using Prism.Ioc;
using Onsale.Prism.ViewModels;
using Onsale.Prism.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using Xamarin.Forms;
using OnSale.Common.Services;
using Syncfusion.Licensing;

namespace Onsale.Prism
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            SyncfusionLicenseProvider.RegisterLicense("MzEyMjQzQDMxMzgyZTMyMmUzMGpMS1JPMjJxWG8vaWZualhSd2pkYVBLYzNSQy9nanFjUk8xdTR1d2pTRzA9");
            InitializeComponent();
            await NavigationService.NavigateAsync($"NavigationPage/{nameof(ProductsPage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.Register<IApiService, ApiService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<ProductsPage, ProductsPageViewModel>();
        }
    }
}
