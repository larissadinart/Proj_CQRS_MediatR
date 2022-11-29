using System;

public interface IFlightService
{
    string FlightCollectionName { get; set; }
    string ConnectionString { get; set; }
    string FlightDataBaseName { get; set; }
}
