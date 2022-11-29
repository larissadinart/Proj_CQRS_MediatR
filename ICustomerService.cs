using System;

public interface ICustomerService
{
    string CustomerCollectionName { get; set; }
    string ConnectionString { get; set; }
    string CustomerDataBaseName { get; set; }
}
