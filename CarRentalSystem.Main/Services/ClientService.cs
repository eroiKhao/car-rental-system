using CarRentalSystem.Models;
using CarRentalSystem.Generic.Repositories;

namespace CarRentalSystem.Services
{
    public class ClientService
    {
        private readonly IRepository<Client> _clientRepository;

        private readonly RentalCarContext _context;
        public ClientService(IRepository<Client> clientRepository, RentalCarContext context)
        {
            _clientRepository = clientRepository;
            _context = context;
        }
        public IEnumerable<Client> GetAllClients()
        {
            return _clientRepository.GetAll();
        }
        public void RegisterNewClient(string name, string email, string passportDetails)
        {
            if (_clientRepository.GetAll().Any(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException($"User with name '{name}' already exists.");
            }
            if (string.IsNullOrWhiteSpace(passportDetails))
            {
                throw new ArgumentException("It is necessary to provide passport data.");
            }

            var newClient = new Client
            {
                Name = name,
                Email = email,
                PassportDetails = passportDetails,
            };

            _clientRepository.Add(newClient);
            _context.SaveChanges();
        }
        public void UpdateClientPassport(int clientId, string newPassportDetails)
        {
            var client = _clientRepository.GetById(clientId);

            if (client == null)
            {
                throw new KeyNotFoundException($"Client with ID {clientId} not found.");
            }
            if (client.PassportDetails != newPassportDetails)
            {
                client.PassportDetails = newPassportDetails;
                _clientRepository.Update(client);
                _context.SaveChanges();
            }
        }
    }
}