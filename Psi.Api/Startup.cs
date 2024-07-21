using Psi.Api.Services;
using Psi.Data.Repositories;
using Psi.Domain;
using Psi.Domain.Repositories;

namespace Psi.Api
{
   internal static class Startup
   {
      public static void RegisterServices(this WebApplicationBuilder builder)
      {
         builder.Services.AddScoped<ICustomerApplicationService, CustomerApplicationService>();
         builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
         builder.Services.AddScoped((_) => new SqlConnectionProvider(builder.Configuration.GetConnectionString("PostGres_StringConnection") ?? "PostgresConnection"));
      }
   }
}
