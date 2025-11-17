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
        public Client GetOrCreateClient(string name, string email, string passportDetails)
        {
            var existingClient = _context.Clients
                                         .FirstOrDefault(c => c.Email == email);

            if (existingClient != null)
            {
                existingClient.Name = name;
                existingClient.PassportDetails = passportDetails;
                _clientRepository.Update(existingClient);
                _context.SaveChanges();
                return existingClient;
            }
            else
            {
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
                return newClient;
            }
        }

        public void UpdateClientPassport(Guid clientId, string newPassportDetails)
        {
            var client = _context.Set<Client>().Find(clientId);

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