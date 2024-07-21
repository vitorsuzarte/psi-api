using Psi.Domain.Enums;
using Psi.Domain.Models.Documents;

namespace Psi.Domain.Models.Customers;

public class Customer
{
   public Guid Id { get; private set; }
   public string Name { get; set; }
   public DateTime BirthDate { get; set; }
   public Document Document { get; set; }
   public string Email { get; set; }
   public string Phone { get; set; }

   public void SetCustomerId(string customerId)
   {
      Id = new Guid(customerId);
   }
}
