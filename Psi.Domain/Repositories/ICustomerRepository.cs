using Psi.Domain.Models.Customers;

namespace Psi.Domain.Repositories;

public interface ICustomerRepository
{
   Task<Customer> GetCustomer(Guid customerId);
   Task<string> CreateCustomer(Customer customer);
}
