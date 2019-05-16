using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPatronRepo.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

    }
}