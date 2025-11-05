using CarRentalSystem.Models;
using CarRentalSystem.Generic.Repositories;

namespace CarRentalSystem.Services
{
    public class OrderService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<Car> _carRepository;
        private readonly IRepository<Client> _clientRepository;

        private readonly RentalCarContext _context;

        public OrderService(
            IRepository<Order> orderRepository,
            IRepository<Car> carRepository,
            IRepository<Client> clientRepository,
            RentalCarContext context)
        {
            _orderRepository = orderRepository;
            _carRepository = carRepository;
            _clientRepository = clientRepository;
            _context = context;
        }
        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.GetAll();
        }
        public IEnumerable<Order> GetOrdersForClient(int clientId)
        {
            return _orderRepository.GetAll();
        }
        public void CreateNewOrder(int clientId, int carId, DateTime startDate, DateTime endDate)
        {
        }
        public void CancelOrder(int orderId)
        {
        }
    }
}
