using Microsoft.AspNetCore.Mvc;
using Proj_Aeroporto.Domain.Commands.Customer;

namespace Proj_Aeroporto.Domain.Commands.Reservation
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationCommandHandler
    {
        public void MileCounter(CustomerCommand customer)
        {
            if(customer.Miles > 0 )
            {
               double totalofmiles =  customer.Miles * 0.25;
            }
        }

        [HttpPost]
        public ActionResult<ReservationCommand> CreateReservation()
        {

        }


    }
}
