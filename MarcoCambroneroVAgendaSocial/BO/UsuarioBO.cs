using MarcoCambroneroVAgendaSocial.DAO;
using MarcoCambroneroVAgendaSocial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcoCambroneroVAgendaSocial.BO
{
    public class UsuarioBO
    {

        private UsuarioDAO udao;

        public UsuarioBO()
        {
            udao = new UsuarioDAO();
        }

        public List<Usuario> LeerArchivo(string archivo, string idusu,string fecha)
        {
            return udao.LeerArchivo(archivo, idusu, fecha);
        }

        public bool IngresoEvento (string evento)
        {
            return udao.IngresoEvento(evento);
        }

    }
}
