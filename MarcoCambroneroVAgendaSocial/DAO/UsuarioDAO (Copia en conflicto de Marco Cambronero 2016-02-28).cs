using MarcoCambroneroVAgendaSocial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MarcoCambroneroVAgendaSocial.DAO
{
   public  class UsuarioDAO
    {

        public List<Usuario> readFile(String archivo)
        {
            Reader lector;
            List<Usuario> datosusu = new List<Usuario>();
            bool header = true;
            try
            {
                lector = new FileReader(archivo);
                BufferedReader contenido = new BufferedReader(lector);
                String linea;
                while ((linea = contenido.readLine()) != null)
                {
                    if (!header)
                    {
                        String datos[ ] = linea.split(",");
                        if (datos[4].equals("transferencia"))
                        {
                            cuentas.add(new Cuenta(datos[0], Double.parseDouble(datos[1]), datos[2], datos[3], datos[4], datos[5]));
                        }

                    }
                    else {
                        header = false;
                    }
                }
            }
            catch (Exception ex)
            {
                JOptionPane.showMessageDialog(null, "No se pudo leer el contenido del Arcihvo", null, JOptionPane.ERROR_MESSAGE);

            }
            return cuentas;
        }


    }
}
