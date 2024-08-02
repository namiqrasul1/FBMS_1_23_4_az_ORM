using CarShop.Data;
using CarShop.Presentation.ViewModels;
using CarShop.Presentation.Views;
using CarShop.Presentation.Services;
using SimpleInjector;
using System.Windows;


namespace CarShop.Presentation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container Container { get; set; }

        public App()
        {
            Container = new Container();
            Container.RegisterDataLayer();
            AddOtherServices();
            AddViewModels();
            AddViews();

            Container.Verify();
        }
        private void AddOtherServices()
        {
            Container.RegisterSingleton<INavigationService, NavigationService>();
        }

        private void AddViewModels()
        {
            Container.RegisterSingleton<AllCarsViewModel>();
            Container.RegisterSingleton<MainViewModel>();
            Container.RegisterSingleton<EditViewModel>();
        }

        private void AddViews()
        {
            Container.RegisterSingleton<MainView>();
            Container.RegisterSingleton<AllCarsView>();
            //Container.RegisterSingleton<AddProductView>();
            Container.RegisterSingleton<EditView>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var mainView = Container.GetInstance<MainView>();
            mainView.DataContext = Container.GetInstance<MainViewModel>();
            mainView.Show();
            base.OnStartup(e);
        }
    }

}
