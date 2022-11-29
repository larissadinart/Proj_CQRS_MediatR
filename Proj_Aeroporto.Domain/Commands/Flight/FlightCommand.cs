namespace Proj_Aeroporto.Domain.Commands.Fly
{
    public class FlightCommand
    {
        public int FlightNumber { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public String Origin { get; set; }
        public String Destination { get; set; }
        public int Distance { get; set; }

    }
}
