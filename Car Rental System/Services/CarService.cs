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

        public IEnumerable<Car> GetAllAvailableCars()
        {
            return _carRepository.GetAll().Where(c => c.Status == "Available").OrderBy(c => c.Model);
        }

        public void AddNewCar(string model, decimal price)
        {
            if (string.IsNullOrWhiteSpace(model) || price <= 0)
            {
                throw new ArgumentException("Model and a positive price are required.");
            }

            var newCar = new Car
            {
                Model = model,
                PricePerDay = price,
                Status = "Available"
            };

            _carRepository.Add(newCar);
            _context.SaveChanges();
        }

        public void UpdateCarPrice(Guid carId, decimal newPrice)
        {
            var car = _context.Set<Car>().Find(carId);

            if (car == null)
            {
                throw new KeyNotFoundException($"Car with ID {carId} not found.");
            }
            if (newPrice <= 0)
            {
                throw new ArgumentException("Price per day must be a positive number.");
            }

            car.PricePerDay = newPrice;
            _carRepository.Update(car);
            _context.SaveChanges();
        }

        public void DeleteCar(Guid carId)
        {
            var car = _context.Set<Car>().Find(carId);

            if (car != null)
            {
                _carRepository.Delete(car);
                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException($"Car with ID {carId} not found.");
            }
        }
        public void MarkCarStatus(Guid carId, string newStatus)
        {
            if (string.IsNullOrWhiteSpace(newStatus))
            {
                throw new ArgumentException("New status cannot be empty.");
            }

            var car = _context.Set<Car>().Find(carId);

            if (car == null)
            {
                throw new KeyNotFoundException($"Car with ID {carId} not found.");
            }

            car.Status = newStatus;
            _carRepository.Update(car);
            _context.SaveChanges();
        }
    }
}