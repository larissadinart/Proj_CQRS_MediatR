using System;

public interface IReservationService
{
    string ReservationCollectionName { get; set; }
    string ConnectionString { get; set; }
    string ReservationDataBaseName { get; set; }
}
