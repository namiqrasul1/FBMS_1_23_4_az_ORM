using CarShop.Data.Repositories;
using CarShop.Models;
using CarShop.Presentation.Services;
using CarShop.Presentation.Views;
using Lesson15WpfCoding.Commands;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace CarShop.Presentation.ViewModels
{
    public class AllCarsViewModel : ViewModel
    {
        private readonly IRepository<Car> _carRepository;
        private readonly INavigationService _navigationService;

        public ObservableCollection<Car> Cars { get; set; }
        public RelayCommand DeleteCommand { get; set; }
        public RelayCommand EditCommand { get; set; }

        public AllCarsViewModel(IRepository<Car> carRepository, INavigationService navigationService)
        {
            _carRepository = carRepository;
            _navigationService = navigationService;
            Cars = new ObservableCollection<Car>(_carRepository.GetAll()!.Include(c => c.Tags));
            DeleteCommand = new RelayCommand(DeleteCar);
            EditCommand = new(EditCar);
        }

        private void EditCar(object? id)
        {
            var car = _carRepository.Get(Convert.ToInt32(id));
            if (car is not null)
            {
                _navigationService.Navigate<EditView, EditViewModel>();
                var mainVm = App.Current.MainWindow.DataContext as MainViewModel;
                if (mainVm is not null)
                {
                    var vm = mainVm.CurrentPage.DataContext as EditViewModel;
                    vm!.Car = car.Clone();
                }
            }
        }

        private void DeleteCar(object? id)
        {
            var objId = Convert.ToInt32(id);

            var car = _carRepository.Get(objId);
            _carRepository.Delete(car!);
            car = Cars.First(c => c.Id == objId);
            Cars.Remove(car);
            _carRepository.SaveChanges();
        }

    }
}
