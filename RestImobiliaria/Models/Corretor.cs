using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace RestImobiliaria.Models
{
    [DataContract]
    public class Corretor
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "nome")]
        public string Nome { get; set; }

        [DataMember(Name = "cpf")]
        public string Cpf { get; set; }

        [DataMember(Name = "creci")]
        public string Creci { get; set; }


        [DataMember(Name = "ufcreci")]
        public string Ufcreci { get; set; }

        [DataMember(Name = "telefone")]
        public string Telefone { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "visivel")]
        public int Visivel { get; set; }

        [DataMember(Name = "senha")]
        public string Senha { get; set; }
        
    }
}