using Microsoft.AspNetCore.Mvc;
using Proj_Aeroporto.Domain.Commands.Customer;

namespace Proj_Aeroporto.Controllers
{
    public class CustomerController : Controller
    {
        [HttpPost]
        public ActionResult<CustomerCommand> PostCustomer(CustomerCommand customer)
        {

        }
    }
}
