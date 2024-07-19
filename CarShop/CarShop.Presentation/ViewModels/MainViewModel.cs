using CarShop.Presentation.Services;
using CarShop.Presentation.Views;
using Lesson15WpfCoding.Commands;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace CarShop.Presentation.ViewModels;


public class MainViewModel : ViewModel, INotifyPropertyChanged
{
    //public RelayCommand AddCommand { get; set; }
    public RelayCommand AllCarsCommand { get; set; }
    

    private Page currentPage;
    private readonly INavigationService navigationService;

    public Page CurrentPage
    {
        get { return currentPage; }
        set { currentPage = value; OnPropertyChanged(); }
    }

    public MainViewModel( INavigationService navigationService)
    {
        //AddCommand = new RelayCommand(Add);
        AllCarsCommand = new(All);
        currentPage = App.Container.GetInstance<AllCarsView>();
        currentPage.DataContext = App.Container.GetInstance<AllCarsViewModel>();
        this.navigationService = navigationService;
    }

    private void All(object? obj)
    {
        navigationService.Navigate<AllCarsView, AllCarsViewModel>();
    }

    //public void Add(object? parameter)
    //{
    //    navigationService.Navigate<AddProductView, AddProductViewModel>();
    //}

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? paramName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(paramName));
}