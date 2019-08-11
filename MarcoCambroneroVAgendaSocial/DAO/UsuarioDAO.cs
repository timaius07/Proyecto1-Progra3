using MarcoCambroneroVAgendaSocial.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcoCambroneroVAgendaSocial.DAO
{
  public  class UsuarioDAO
    {
   
        public List<Usuario> LeerArchivo(String archivo, string idusuario, string fecha)
        {
            StreamReader lector = new StreamReader(archivo);
            //muestra los datos de las actividades en data grid        
            List<Usuario> datosusu = new List<Usuario>();
            //ordena los datos de unicamente las fechas de las actividades
            List<Usuario> datosusu2 = new List<Usuario>();
            //ordena los datos por fecha del dia
            List<Usuario> datosusu3 = new List<Usuario>();
            string horavect="";
            string horatxt="";
            int contdatusu = 0;

       

            //vector que contiene todas las horas del dia
            string[] horas = new string[] { "12:00 am", "01:00 am", "02:00 am","03:00 am", "04:00 am",
                                            "05:00 am", "06:00 am", "07:00 am","08:00 am", "09:00 am",
                                            "10:00 am", "11:00 am", "12:00 pm","01:00 pm", "02:00 pm",
                                            "03:00 pm", "04:00 pm", "05:00 pm","06:00 pm", "07:00 pm",
                                            "08:00 pm", "09:00 pm", "10:00 pm","11:00 pm"};
            string linea = "";
            string[] datos;
            datos = new string[5];
            //ciclo que lee cada linea del archivo de texto y las agraga al vector de datos 
            //separandolos los datos mediante las comas
            while ((linea = lector.ReadLine()) != null)
            {
                datos = linea.Split(',');
           //agrega datos al list solo cuando la fecha del evento y el id del usuario coinciden
                if (datos[1].Equals(idusuario) & datos[3].Equals(fecha))
                {
                    datosusu2.Add(new Usuario((horavect), (datos[1]), datos[2], datos[3], datos[4], datos[5]));
                  
                }
         
            }
            //ordena la lista de datos del usuario segun la horaInicial del evento
            datosusu2 = datosusu2.OrderBy(o => o.FechaEvento).ToList();
            //lista que recorre los eventos agregados para agregar la hora de del dia
            //en la que se inicia cada evento 


            for (int i = 0; i < horas.Length; i++)
                {

                if (contdatusu < datosusu2.Count)
                {

                    horavect = horas[i].ToString();
                    horatxt = datosusu2[contdatusu].InicioEvento;
                    if (horavect[0].Equals(horatxt[0]))
                    {
                        if (horavect[1].Equals(horatxt[1]))
                        {
                            if (horavect[6].Equals(horatxt[6]))
                            {
                                if (horavect[7].Equals(horatxt[7]))
                                {

                                    datosusu3.Add(new Usuario((horas[i]), (datosusu2[contdatusu].id),
                                    (datosusu2[contdatusu].archivoActividad), (datosusu2[contdatusu].FechaEvento),
                                    (datosusu2[contdatusu].InicioEvento), (datosusu2[contdatusu].FinEvento)));
                                    contdatusu++;
                                    i = -1;

                                }
                            }
                        }
                    }
                }
              
            }

       
            //se recorre todo el vector de las horas, verificando las horas del vector 
            //con las horas de los inicio de los eventos si coinciden se agregan los datos de
            //dichos eventos, de lo contrario solo se agregara la hora de inicio
            contdatusu = 0;
            for (int i = 0; i < horas.Length; i++)
                {
                if (contdatusu < datosusu3.Count)
                {

                    //validar que la hora sea 12 am y 12pm luego ordenar
                    horavect = horas[i].ToString();
                    horatxt = datosusu3[contdatusu].InicioEvento;
                
                    //verificamos si la hora inicial del evento el archivo txt, sea 
                    //la misma que esta en la en el vector horas
                    if (horavect[0].Equals(horatxt[0]))
                    {
                        if (horavect[1].Equals(horatxt[1]))
                        {
                            //verificamos la hora del dia en la que se hace el evento 
                            //sean am ó pm
                            if (horavect[6].Equals(horatxt[6]))
                            {
                                if (horavect[7].Equals(horatxt[7]) )
                                {
                                //si cumplen con las condiciones de los if anteriores se agregan en el datausu que es una lista 
                                //de los atributos del Usuario
                                datosusu.Add(new Usuario((datosusu3[contdatusu].horasdia), (datosusu3[contdatusu].id),
                                (datosusu3[contdatusu].archivoActividad), (datosusu3[contdatusu].FechaEvento),
                                (datosusu3[contdatusu].InicioEvento), (datosusu3[contdatusu].FinEvento)));
                                contdatusu++;
                                }
                                else                           
                                {
                                datosusu.Add(new Usuario((horas[i]), (" "), (" "), (" "), (" "), (" ")));
                                }
                            }
                            else
                            {
                                datosusu.Add(new Usuario((horas[i]), (" "), (" "), (" "), (" "), (" ")));
                            }

                       }
                        else
                        {
                            datosusu.Add(new Usuario((horas[i]), (" "), (" "), (" "), (" "), (" ")));
                        }

                    }
                    else
                    {
                        datosusu.Add(new Usuario((horas[i]), (" "), (" "), (" "), (" "), (" ")));
                    }
                }
                else
                {
                    datosusu.Add(new Usuario((horas[i]), (" "), (" "), (" "), (" "), (" ")));
                }
            }
            return datosusu;
       }

        public bool IngresoEvento(string evento)
        {

            try
            {
                // creamos la variable para guardar la fecha y hora, mas el evento en una variable .
                //llamamos  a la clase streamWriter para escribir en el archivo
                StreamWriter Archivo_Agenda = File.AppendText("Archivo_Agenda.txt");
                StringBuilder n = new StringBuilder();
                //hace un salto de linea en el archivo txt
                n.AppendLine("Archivo_Agenda.txt");
                // guarda el evento, la hora de inicio, hora final en un string
                //escribe en un archivo txt el mensaje del evento para almacenar la informacion 
                Archivo_Agenda.WriteLine(evento);
                //cierra el archivo para poder editarlo nuevamente
                Archivo_Agenda.Close();
                return true;
            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString(),
                    "Evento agregado exitosamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
           
        }

    }


}








