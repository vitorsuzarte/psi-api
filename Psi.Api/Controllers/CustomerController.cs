using Microsoft.AspNetCore.Mvc;
using Psi.Api.Response;
using Psi.Api.Services;

namespace Psi.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
   private readonly ICustomerApplicationService _customerApplicationService;
   private readonly ILogger<CustomerController> _logger;

   public CustomerController(ILogger<CustomerController> logger, ICustomerApplicationService customerService)
   {
      _logger = logger;
      _customerApplicationService = customerService;
   }

   [HttpGet("user")]
   public ActionResult<CustomerResponse> Get(Guid customerId)
   {
      var user = _customerApplicationService.GetCustomer(customerId);

      return Ok(user);
   }
}