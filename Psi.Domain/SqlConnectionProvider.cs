using Npgsql;
using System.Data;

namespace Psi.Domain;

public class SqlConnectionProvider
{
   private readonly IDbConnection _connection;
   private IDbTransaction? _transaction;

   public SqlConnectionProvider(string connectionString)
   {
      _connection = new NpgsqlConnection(connectionString);
   }

   public IDbConnection GetDbConnection => _connection;

   public IDbTransaction? GetTransaction => _transaction;
   
   /// <summary>
   /// Creates a new transaction for the current database connection.
   /// If the connection is closed, it will be opened before starting the transaction.
   /// </summary>
   /// <returns>The newly created transaction.</returns>
   public IDbTransaction CreateTransaction()
   {
      if (_connection.State == ConnectionState.Closed)
      {
         _connection.Open();
      }

      _transaction = _connection.BeginTransaction();

      return _transaction;
   }

}

