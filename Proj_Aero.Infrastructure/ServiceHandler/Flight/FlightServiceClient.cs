using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Proj_Aeroporto.Domain.Commands.Fly;

namespace Proj_Aero.Infrastructure.ServiceHandler.Flight
{
    public class FlightServiceClient
    {
        private readonly IMongoCollection<FlightCommand> _flight;
        public FlightServiceClient(IFlightService settings)
        {
            var flight = new MongoClient(settings.ConnectionString);
            var database = flight.GetDatabase(settings.FlightDataBaseName); ;
            _flight = database.GetCollection<FlightCommand>(settings.FlightCollectionName);

        }
        public FlightCommand CreateFlight(FlightCommand flight)
        {
            string fly = flight.FlightNumber;
            _flight.InsertOne(flight);
            return flight;
        }
        public FlightCommand GetFlight(string flightnumber) =>
            _flight.Find<FlightCommand>(flight => flight.FlightNumber == flightnumber).FirstOrDefault();

        public List<FlightCommand> GetAllFlights() =>
            _flight.Find<FlightCommand>(flight => true).ToList();

        public void UpdateFlight(string flightnumber, FlightCommand flight)
        {
            string updateflight = flight.FlightNumber;
            _flight.ReplaceOne(flight => flight.FlightNumber == flightnumber, flight);
        }

        public void RemoveFlight(FlightCommand flight)
        {
            string removeflight = flight.FlightNumber;
            _flight.DeleteOne(flight => flight.FlightNumber == removeflight);
        }
    }
}
