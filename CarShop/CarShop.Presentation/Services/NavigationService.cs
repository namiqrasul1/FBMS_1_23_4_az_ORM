using CarShop.Presentation.ViewModels;
using System.Windows.Controls;

namespace CarShop.Presentation.Services
{
    public class NavigationService : INavigationService
    {
        public void Navigate<TView, TViewModel>() where TView : Page where TViewModel : ViewModel
        {
            var mainVm = App.Current.MainWindow.DataContext as MainViewModel;
            if (mainVm is not null)
            {
                mainVm.CurrentPage = (App.Container.GetInstance<TView>())!;
                mainVm.CurrentPage.DataContext = App.Container.GetInstance<TViewModel>();
            }
        }
    }
}
