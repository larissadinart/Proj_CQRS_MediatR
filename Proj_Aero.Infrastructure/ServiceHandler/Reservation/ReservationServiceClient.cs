using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Proj_Aeroporto.Domain.Commands.Fly;
using Proj_Aeroporto.Domain.Commands.Reservation;

namespace Proj_Aero.Infrastructure.ServiceHandler.Reservation
{
    public class ReservationServiceClient
    {
        private readonly IMongoCollection<ReservationCommand> _reservation;
        public ReservationServiceClient(IReservationService settings)
        {
            var reservation = new MongoClient(settings.ConnectionString);
            var database = reservation.GetDatabase(settings.ReservationDataBaseName); ;
            _reservation = database.GetCollection<ReservationCommand>(settings.ReservationCollectionName);

        }
        public ReservationCommand CreateFlight(ReservationCommand reservation)
        {
            string reserv = reservation.NumberOfReservation;
            _reservation.InsertOne(reservation);
            return reservation;
        }
        public ReservationCommand GetReservation(string reservationnumber) =>
            _reservation.Find<ReservationCommand>(reservation => reservation.NumberOfReservation == reservationnumber).FirstOrDefault();

        public List<ReservationCommand> GetAllReservation() =>
            _reservation.Find<ReservationCommand>(reservation => true).ToList();

        public void UpdateReservation(string reservationnumber, ReservationCommand reservation)
        {
            string updatereservation = reservation.NumberOfReservation;
            _reservation.ReplaceOne(reservation => reservation.NumberOfReservation == reservationnumber,reservation);
        }

        public void RemoveReservation(ReservationCommand reservation)
        {
            string removereservation = reservation.NumberOfReservation;
            _reservation.DeleteOne(reservation => reservation.NumberOfReservation == removereservation);
        }
    }
}
