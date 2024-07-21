using Psi.Api.Requests.Customers;
using Psi.Api.Response;

namespace Psi.Api.Services;

public interface ICustomerApplicationService
{
   Task<CustomerResponse> LogIn(string username, string password);
   Task<CustomerResponse> GetCustomer(Guid customerId);
   Task<CustomerResponse> CreateCustomer(CustomerRequest customerRequest);
   Task DeleteCustomer(Guid customerId);
   Task<CustomerResponse> UpdateCustomer(CustomerRequest customerRequest);
}
