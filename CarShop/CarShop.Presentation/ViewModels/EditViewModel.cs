using CarShop.Data.Data;
using CarShop.Data.Repositories;
using CarShop.Models;
using CarShop.Presentation.Services;
using CarShop.Presentation.Views;
using Lesson15WpfCoding.Commands;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CarShop.Presentation.ViewModels
{
    public class EditViewModel : ViewModel, INotifyPropertyChanged
    {
        private Car? car;
        private readonly IRepository<Car> repository;
        private readonly INavigationService navigationService;

        public EditViewModel(IRepository<Car> repository, INavigationService navigationService)
        {
            this.repository = repository;
            this.navigationService = navigationService;
            SaveCommand = new RelayCommand(Edit);
            CancelCommand = new RelayCommand(Cancel);
        }
        public Car? Car { get => car; set { car = value; OnPropertyChanged(); } }
        public RelayCommand SaveCommand { get; set; }
        public RelayCommand CancelCommand { get; set; }
        public AppDbContext DbContext { get; set; }

        private void Cancel(object? obj)
        {
            navigationService.Navigate<AllCarsView, AllCarsViewModel>();
        }

        private void Edit(object? obj)
        {
            repository.Update(car!);
            repository.SaveChanges();
            navigationService.Navigate<AllCarsView, AllCarsViewModel>();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? paramName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(paramName));
    }
}
