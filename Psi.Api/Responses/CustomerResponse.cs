using Psi.Domain.Models.Customers;

namespace Psi.Api.Response;

public class CustomerResponse
{
   public Guid Id { get; set; }
   public string Name { get; set; }
   public DateTime BirthDate { get; set; }
   public string Email { get; set; }
   public string Phone { get; set; }

   public static CustomerResponse From(Customer customer) =>
      new CustomerResponse()
      {
         Id = customer.Id,
         Name = customer.Name,
         BirthDate = customer.BirthDate,
         Email = customer.Email,
         Phone = customer.Phone
      };
}