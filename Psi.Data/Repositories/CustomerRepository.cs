using Psi.Domain.Repositories;
using Psi.Domain.Models.Customers;
using Psi.Domain;
using System.Data;
using Dapper;

namespace Psi.Data.Repositories;

public class CustomerRepository : ICustomerRepository
{
   private readonly IDbConnection _connection;

   public CustomerRepository(SqlConnectionProvider connectionProvider)
   {
      _connection = connectionProvider.GetDbConnection;
   }

   public async Task<Customer> GetCustomer(Guid customerId)
   {
      throw new NotImplementedException();
   }

   public async Task<string> CreateCustomer(Customer customer)
   {
      var query = @"INSERT INTO users 
                          (name, birthdate, doc_type, doc_value, email, phone)
                          VALUES
                          (@name, @birthdate, @documentType, @documentValue, @phone)
                          RETURNING Id;";

      return await _connection.QueryFirstAsync<string>(query, param: new
      {
         name = customer.Name,
         birthdate = customer.BirthDate,
         doc_type = customer.Document.Type,
         doc_value = customer.Document.Value,
         email = customer.Email,
         phone = customer.Phone,
      });
   }
}
