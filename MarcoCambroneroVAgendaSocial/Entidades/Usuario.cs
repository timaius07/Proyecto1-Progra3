using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;

namespace MarcoCambroneroVAgendaSocial.Entidades
{
   public  class Usuario
    {
        public string horasdia { get; set; }
        public string id { get; set; }
        public string archivoActividad { get; set; }
        public string FechaEvento { get; set; }
        public string InicioEvento { get; set; }
        public string FinEvento { get; set; }
        public string cuenta { get; set; }
        public string  foto { get; set; }
        public Uri fotoface { get; set; }
        public string nombreCuenta { get; set; }
        

        public Usuario(string horas, string idtxt, string eventxt, string fechatxt, string horainitxt, string horafintxt)
        {
            this.horasdia = horas;
            this.id = idtxt;
            this.FechaEvento = (fechatxt);
            this.InicioEvento = (horainitxt);
            this.FinEvento = (horafintxt);
            this.archivoActividad = eventxt;

        }

        public Usuario(string cuentaG, string NOmbre_Cuentag, String URLimagen )
        {
            cuenta = cuentaG;
            nombreCuenta = NOmbre_Cuentag;
            foto = URLimagen;
        }
        public Usuario(string cuentaG, string NOmbre_Cuentag, Uri URLimagen)
        {
            id = cuentaG;
            nombreCuenta = NOmbre_Cuentag;
            fotoface = URLimagen;
        }
      
    }
}
