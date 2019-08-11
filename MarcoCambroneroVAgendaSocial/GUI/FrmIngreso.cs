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
using MarcoCambroneroVAgendaSocial.BO;
using MarcoCambroneroVAgendaSocial.Entidades;
using Facebook;
using MarcoCambroneroVAgendaSocial.GUI;

namespace MarcoCambroneroVAgendaSocial
{
    public partial class Ingreso : Form
    {

       
        private UsuarioBO ubo;
        public Usuario usuario { get; set; }
  
        //carga datos si ingreso con gmail
        public Ingreso(string nombre, string id, string urlImgen)
        {

            InitializeComponent();
            PicBoxImagen.LoadAsync(urlImgen);
            ////////////////////////////////////////////
            lblCuenta.Text = nombre;
            lblId.Text = id;
            this.cargarInicio();
           

        }

        //carga los datos si inicio co facebook
        public Ingreso(string nombre, string id, Uri urlimge)
        {
            InitializeComponent();
            lblCuenta.Text = nombre;
            lblId.Text = id;
            PicBoxImagen.LoadAsync(urlimge.ToString());
            this.cargarInicio();
        }

        //se inicia los cargan las fechas y horas
        public void cargarInicio()
        {
            
            DateTime thisDay = DateTime.Today;
            lblFecha.Text = (thisDay.ToString("d"));
            timer1.Enabled = true;
            //se crea la instancia BO
            ubo = new UsuarioBO();
            cmbHoraI.SelectedIndex = 0;
            cmbHoraF.SelectedIndex = 0;

        }


        private void btnAgendar_Click(object sender, EventArgs e)
        {
            bool error;
            error = this.Validar_Masketbox();
            if (error == false)
            {
                string mensaje = "";
               
                mensaje = " "+","+lblId.Text+","+txtevento.Text+","+maskedtextfecha.Text+","+masktexHora1.Text+" "+cmbHoraI.Text+","+masktexHora2.Text+" "+cmbHoraF.Text;
    
                if (ubo.IngresoEvento(mensaje) == true)
                {
                    txtevento.Text = "";
                    maskedtextfecha.Text = "";
                    masktexHora1.Text = "";
                    masktexHora2.Text = "";
                    txtevento.Focus();
                    MessageBox.Show("Evento agregado exitosamente!",
                    "Evento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el evento!",
                   "Evento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             
            }

        }

        private bool Validar_Masketbox()
        {
            string posicion;
            bool malo = false;
            string t = maskedtextfecha.Text;
            t = t.Replace("/", "");
            for (int i = 0; i < t.Length; i++)
            {
                posicion = t[i].ToString();
                if (posicion.Equals(" ") || t.Length < 8)
                {
                    MessageBox.Show("Error en los datos de la fecha",
                   "Verifique los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    malo = true;
                    goto Salir;
                }
            }
            //validamos que la hora inicio sea de formato correcto
            string h = masktexHora1.Text;
            h = h.Replace(":", "");

            for (int i = 0; i < h.Length; i++)
            {
                posicion = h[i].ToString();
                if (posicion.Equals(" ") || h.Length < 4)
                {
                    MessageBox.Show("Error en los datos de la hora Inicio",
                   "Verifique los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    malo = true;
                    goto Salir;
                }
            }

            //validamos que la hora final sea de formato correcto
            string j = masktexHora2.Text;
            j = j.Replace(":", "");
            for (int i = 0; i < j.Length; i++)
            {
                posicion = j[i].ToString();
                if (posicion.Equals(" ") || j.Length < 4)
                {
                    MessageBox.Show("Error en los datos de la hora Final",
                        "Verifique los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    malo = true;
                    goto Salir;
                }
            }

            if (txtevento.Text.Equals(""))
            {
                MessageBox.Show("Error en los datos del Evento",
                       "Verifique los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                malo = true;
                goto Salir;
            }
            Salir:;
            return malo;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //mostramos la fecha en el masked fecha al dar click
            maskedtextfecha.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            masktexHora1.Focus();
        }

        private void Ingreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Realmente desea Salir?", " Salir a Menu",
              MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //llama al formulario padre que fue quien lo invoco para volverlo a mostrar
                this.Owner.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss  tt");
        }

  
    }
}

