using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Proj_Aeroporto.Domain.Commands.Address
{
    public class AddressCommand
    {
        [Required]
        [StringLength(9, ErrorMessage = "Cep inválido!")]
        [JsonProperty("cep")]
        public String ZipCode { get; set; }

        [StringLength(100, ErrorMessage = "Logradouro inválido!")]
        [JsonProperty("logradouro")]
        public String Street { get; set; }

        [StringLength(30)]
        [JsonProperty("bairro")]
        public String District { get; set; }

        [Required]
        public int Number { get; set; }

        [StringLength(10)]
        public String? Complement { get; set; }

        [StringLength(30)]
        [JsonProperty("localidade")]
        public String City { get; set; }

        [StringLength(2)]
        [JsonProperty("uf")]
        public String State { get; set; }
    }
}
