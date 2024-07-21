using Psi.Api.Requests.Customers;
using Psi.Api.Response;
using Psi.Domain.Repositories;

namespace Psi.Api.Services;

public class CustomerApplicationService : ICustomerApplicationService
{
   ICustomerRepository _customerRepository;

   public CustomerApplicationService(ICustomerRepository customerRepository)
   {
      _customerRepository = customerRepository;
   }

   public async Task<CustomerResponse> LogIn(string username, string password) { throw new NotImplementedException(); }
   public async Task<CustomerResponse> GetCustomer(Guid customerId) { throw new NotImplementedException(); }
   public async Task<CustomerResponse> CreateCustomer(CustomerRequest customerRequest)
   {
      //realizar validação de request

      //verificar se o cliente ja existe

      //criar o cliente
      var customer = customerRequest.ToCustomer();

      var customerId = await _customerRepository.CreateCustomer(customer);
      customer.SetCustomerId(customerId);

      return CustomerResponse.From(customer);
   }
   public Task DeleteCustomer(Guid customerId) { throw new NotImplementedException(); }
   public Task<CustomerResponse> UpdateCustomer(CustomerRequest customerRequest) { throw new NotImplementedException(); }

}
