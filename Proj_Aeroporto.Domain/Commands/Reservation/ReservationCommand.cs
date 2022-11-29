using Proj_Aeroporto.Domain.Commands.Customer;
using Proj_Aeroporto.Domain.Commands.Fly;

namespace Proj_Aeroporto.Domain.Commands.Reservation
{
    public class ReservationCommand
    {
        public FlightCommand Flight { get; set; }
        public double Value { get; set; }
        public CustomerCommand Customer { get; set; }
        public int FormOfPayment { get; set; }
    }
}
