using CarShop.Presentation.ViewModels;
using System.Windows.Controls;

namespace CarShop.Presentation.Services
{
    public interface INavigationService
    {
        void Navigate<TView, TViewModel>() where TView : Page where TViewModel : ViewModel;
    }
}
