using Microsoft.AspNetCore.Mvc;

namespace Proj_Aeroporto.Domain.Commands.Customer
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerCommandHandler : ControllerBase
    {
        public void CountMiles(CustomerCommand customer)
        {
            if (customer.Miles > 0)
            {
                double miles = customer.Miles * 0.25;
            }
        }


    }
}
