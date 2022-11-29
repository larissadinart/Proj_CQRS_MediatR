using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Proj_Aeroporto.Domain.Commands.Customer;

namespace Proj_Aero.Infrastructure.ServiceHandler.Customer
{
    public class CustomerServiceClient
    {
        private readonly IMongoCollection<CustomerCommand> _customer;

        public CustomerServiceClient(ICustomerService settings)
        {
            var customer = new MongoClient(settings.ConnectionString);
            var database = customer.GetDatabase(settings.CustomerCollectionName);
            _customer = database.GetCollection<CustomerCommand>(settings.CustomerCollectionName);
        }
        public CustomerCommand CreateCustomer(CustomerCommand customer)
        {
            _customer.InsertOne(customer);
            return customer;
        }
        public List<CustomerCommand> GetAllCustomers() => 
            _customer.Find<CustomerCommand>(Customer => true).ToList();

        public CustomerCommand GetCustomer(string cpf) => 
            _customer.Find<CustomerCommand>(customer => customer.Cpf == cpf).FirstOrDefault();

    }
}
