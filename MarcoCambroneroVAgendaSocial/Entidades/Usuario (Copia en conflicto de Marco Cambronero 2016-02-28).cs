using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcoCambroneroVAgendaSocial.Entidades
{
    public class Usuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string Contrasenna { get; set; }
        public DateTime FechaEvento { get; set; }
        public DateTime InicioEvento { get; set; }
        public DateTime FinEvento { get; set; }
        public string archivoActividad { get; set; }
    }
}
