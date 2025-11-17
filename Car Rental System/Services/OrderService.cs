using CarRentalSystem.Models;
using CarRentalSystem.Generic.Repositories;
using Microsoft.EntityFrameworkCore;

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

        public async Task<(IEnumerable<Order> Orders, int TotalCount)> GetOrdersPaged(int page, int pageSize)
        {
            var totalOrders = await _context.Orders
                                            .TagWith("Get Total Order Count")
                                            .AsNoTracking()
                                            .CountAsync();

            var orders = await _context.Orders
                                    .TagWith("Load all orders paged")
                                    .AsNoTracking()
                                    .Include(o => o.Client)
                                    .Include(o => o.RentedCar)
                                    .OrderByDescending(o => o.CreatedAt)
                                    .Skip((page - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();

            return (orders, totalOrders);
        }

        public async Task<IEnumerable<Order>> SearchOrders(string searchTerm)
        {
            return await _context.Orders
               .AsNoTracking()
               .Include(o => o.Client)
               .Include(o => o.RentedCar)
               .Where(o =>
                   o.Client.Name.ToLower().Contains(searchTerm) ||
                   o.RentedCar.Model.ToLower().Contains(searchTerm))
               .OrderByDescending(o => o.CreatedAt)
               .ToListAsync();
        }

        public void CreateNewOrder(Client client, Guid carId, int rentalDays)
        {
            var selectedCar = _context.Set<Car>().Find(carId);

            if (selectedCar == null || selectedCar.Status != "Available")
            {
                throw new InvalidOperationException("Car is not available for rental.");
            }
            if (rentalDays <= 0)
            {
                throw new ArgumentException("Rental days must be a positive number.");
            }

            var newOrder = new Order
            {
                ClientID = client.Id,
                Client = client,
                CarID = selectedCar.Id,
                RentedCar = selectedCar,
                RentalDays = rentalDays,
                TotalPrice = selectedCar.PricePerDay * rentalDays,
                Status = "Pending"
            };

            selectedCar.Status = "Rented";
            _orderRepository.Add(newOrder);
            _carRepository.Update(selectedCar);
            _context.SaveChanges();
        }

        public IEnumerable<Order> GetPendingOrders()
        {
            return _context.Orders
                           .Where(o => o.Status == "Pending")
                           .Include(o => o.Client)
                           .Include(o => o.RentedCar)
                           .ToList();
        }

        public async Task PayOrder(Guid orderId, decimal enteredAmount)
        {
            var order = await _context.Orders.FindAsync(orderId);

            if (order == null)
            {
                throw new KeyNotFoundException($"Order with ID {orderId} not found.");
            }

            if (enteredAmount != order.TotalPrice)
            {
                throw new InvalidOperationException("Entered amount does not match the order total.");
            }

            order.Status = "Paid";
            await _context.SaveChangesAsync();
        }

        public async Task DeleteOrder(Guid orderId)
        {
            var orderToDelete = await _context.Orders
                                              .TagWith($"Delete order by ID {orderId}")
                                              .FirstOrDefaultAsync(o => o.Id == orderId);

            if (orderToDelete == null)
            {
                throw new KeyNotFoundException($"Order with ID {orderId} not found.");
            }

            _orderRepository.Delete(orderToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task ApproveOrder(Guid orderId)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var orderToApprove = await _context.Orders
                                                   .TagWith($"Approve Order ID {orderId}")
                                                   .FirstOrDefaultAsync(o => o.Id == orderId);

                if (orderToApprove == null)
                {
                    throw new KeyNotFoundException($"Order with ID {orderId} not found.");
                }

                if (orderToApprove.Status != "Paid")
                {
                    throw new InvalidOperationException($"Order ID {orderId} cannot be approved. Current status is '{orderToApprove.Status}'. Only orders with 'Paid' status can be approved.");
                }

                orderToApprove.Status = "Approved";
                await _context.SaveChangesAsync();

                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task RejectOrder(Guid orderId, string rejectionReason)
        {
            if (string.IsNullOrWhiteSpace(rejectionReason))
            {
                throw new ArgumentException("Rejection reason cannot be empty.");
            }

            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var orderToReject = await _context.Orders
                                                  .TagWith($"Reject Order ID {orderId}")
                                                  .FirstOrDefaultAsync(o => o.Id == orderId);

                if (orderToReject == null)
                {
                    throw new KeyNotFoundException($"Order with ID {orderId} not found.");
                }

                if (orderToReject.Status == "Rejected")
                {
                    throw new InvalidOperationException($"Order ID {orderId} is already rejected.");
                }

                orderToReject.Status = "Rejected";
                orderToReject.RejectionReason = rejectionReason;

                await _context.SaveChangesAsync();

                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }
}