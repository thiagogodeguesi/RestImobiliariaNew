using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace RestImobiliaria.Models
{
    [DataContract]
    public class Testeinfo
    {
        [DataMember ( Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "valor")]
        public string Valor{ get; set; }

    }
}