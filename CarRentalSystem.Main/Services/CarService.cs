using CarRentalSystem.Models;
using CarRentalSystem.Generic.Repositories;

namespace CarRentalSystem.Services
{
    public class CarService
    {
        private readonly IRepository<Car> _carRepository;
        private readonly RentalCarContext _context;
        public CarService(IRepository<Car> carRepository, RentalCarContext context)
        {
            _carRepository = carRepository;
            _context = context;
        }
        public IEnumerable<Car> GetAllCars()
        {
            return _carRepository.GetAll();
        }

        public void AddNewCar(string brand, string model, decimal price)
        {
            if (string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(model))
            {
                throw new System.Exception("Brand and model cannot be empty.");
            }

            _context.SaveChanges();
        }

        public void UpdateCarPrice(int carId, decimal newPrice)
        {
            var car = _carRepository.GetById(carId);
            if (car != null)
            {
                _carRepository.Update(car);
                _context.SaveChanges();
            }
        }
        public void DeleteCar(int carId)
        {
            var car = _carRepository.GetById(carId);
            if (car != null)
            {
                _carRepository.Delete(car);
                _context.SaveChanges();
            }
        }
    }
}