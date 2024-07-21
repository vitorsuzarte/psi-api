using Psi.Api.Requests.Documents;
using Psi.Domain.Enums;
using Psi.Domain.Models.Customers;

namespace Psi.Api.Requests.Customers;

public class CustomerRequest
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public DocumentRequest Document { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    internal Customer ToCustomer()
    {
        return new Customer()
        {
            Name = Name,
            BirthDate = BirthDate,
            Document = Document.ToDocument(),
            Email = Email,
            Phone = Phone
        };
    }
}