using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUsersJsonPlaceHolderApi.Models
{
    public class Usuario
    {
        public int? id { get; set; }
        public string? name { get; set; }
        public Endereco? address { get; set; }
        public Empresa? company { get; set; }
    }

    public class Endereco
    {
        public string? city { get; set; }
    }

    public class Empresa
    {
        public string? name { get; set; }
    }
}

