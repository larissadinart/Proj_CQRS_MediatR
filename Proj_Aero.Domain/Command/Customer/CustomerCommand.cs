using Proj_Aeroporto.Domain.Commands.Address;

namespace Proj_Aeroporto.Domain.Commands.Customer
{
    public class CustomerCommand
    {
        public CustomerCommand() { }
        public CustomerCommand(string name, AddressCommand address,DateTime dtBirth, string phone, DateTime registrationDate, int miles, int numofmiles)
        {
            Name = name;
            Address = address;
            DtBirth = dtBirth;
            Phone = phone;
            RegistrationDate = registrationDate;
            Miles = miles;
        }

        public string Name { get; set; }
        public AddressCommand Address { get; set; }
        public string Cpf { get; set; }
        public DateTime DtBirth { get; set; }
        public string Phone { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int Miles { get; set; }
    }
}
