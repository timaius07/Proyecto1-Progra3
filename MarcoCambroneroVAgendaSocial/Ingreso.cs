using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MarcoCambroneroVAgendaSocial
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
            
            DateTime thisDay = DateTime.Today;
            lblFecha.Text=(thisDay.ToString("d"));
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
           

        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            string mensaje = "";

            this.validar_masketbox();

            // creamos la variable para guardar la fecha y hora, mas el evento en una variable .
            TextWriter Archivo_Agenda;
            //crea un archivo txt en la compu para almacenar la informacion 
            Archivo_Agenda = new StreamWriter("Archivo_Agenda.txt");
            // guarda el evento, la hora de inicio, hora final en un string
            mensaje = txtevento.ToString() + "\n" + maskedtextfecha.Text + "\n" + masktexHora1.Text + "\n" + masktexHora2.Text;
            Archivo_Agenda.WriteLine(mensaje);
            Archivo_Agenda.Close();  

}

       


       private void validar_masketbox()
        {
            string posicion ;
            string t = maskedtextfecha.Text;
            t = t.Replace("/", "");
            for (int i = 0; i < t.Length; i++)
            {
                posicion = t[i].ToString();
                if (posicion.Equals(" ")|| t.Length<8)
                {
                    MessageBox.Show("Error en los datos de la fecha", 
                   "Verifique los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto Salir;
                }
            } 
            //validamos que la hora inicio sea de formato correcto
            string h = masktexHora1.Text;
            h = h.Replace(":", "");
            for (int i = 0; i < h.Length ; i++)
            {
                posicion = h[i].ToString();
                if (posicion.Equals(" ")|| h.Length < 4)
                {
                    MessageBox.Show("Error en los datos de la hora Inicio",
                   "Verifique los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto Salir;
                }
            }

            //validamos que la hora final sea de formato correcto
            string j = masktexHora2.Text;
            j = j.Replace(":", "");
            for (int i = 0; i < j.Length; i++)
            {
                posicion = j[i].ToString();
                if (posicion.Equals(" ")|| j.Length<4)
                {
                    MessageBox.Show("Error en los datos de la hora Final",
                        "Verifique los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto Salir;
                }
            }
            Salir:;    
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //mostramos la fecha en el masked fecha al dar click
            maskedtextfecha.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            masktexHora1.Focus();
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {

        }
    }
}
