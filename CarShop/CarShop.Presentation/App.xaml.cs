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
            Container.Register<INavigationService, NavigationService>();
        }

        private void AddViewModels()
        {
            Container.Register<AllCarsViewModel>();
            Container.Register<MainViewModel>();
            Container.Register<EditViewModel>();
        }

        private void AddViews()
        {
            Container.Register<MainView>();
            Container.Register<AllCarsView>();
            //Container.RegisterSingleton<AddProductView>();
            Container.Register<EditView>();
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
