using MarcoCambroneroVAgendaSocial.BO;
using MarcoCambroneroVAgendaSocial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nemiro.OAuth;
using Nemiro.OAuth.LoginForms;
using Facebook;

namespace MarcoCambroneroVAgendaSocial.GUI
{
    public partial class frmAgenda : Form
    {
        //invocar metodos del bo usuario
        private UsuarioBO ubo;
        //valida si se conecta con facebook
        private bool publicar;
        //contiene la info del accestoken del usuario
        private string AccesToken;
        //variable que permite la relacion con facebook
        private FacebookClient fbC;
        public frmAgenda(string nombre, string id, string urlImgen)
        {
            //se setean los datos por parametros
            InitializeComponent();
            ubo = new UsuarioBO();
            ///////////////////////////////////////////////
            lblCuenta.Text = nombre;
            lblId.Text = id;
            PicBoxImagen.LoadAsync(urlImgen);
            this.CargarTiempo();
            btnPostear.Enabled = false;



        }
        public frmAgenda(string nombre, string id, Uri urlimge, string accesToken)
        {
            //se setean los datos por parametros
            InitializeComponent();
            ubo = new UsuarioBO();
            lblCuenta.Text = nombre;
            lblId.Text = id;
            PicBoxImagen.LoadAsync(urlimge.ToString());
            AccesToken = accesToken;
            //validamos que la coneccion se de facebook
            publicar = true;
            if (nombre == "Marco Cambronero Vargas")
            {
                btnPostear.Enabled = publicar;
            }
            else
            {
                btnPostear.Enabled = false;
            }
            this.CargarTiempo();
        }
       


        private void CargarTiempo()
        {
            DateTime thisDay = DateTime.Today;
            lblFecha.Text = (thisDay.ToString("d"));
            //se le asigna el token a la variable de asignacion para facebook
            if (publicar == true)
            {
                fbC = new FacebookClient(AccesToken);
            }

            timer1.Enabled = true;
        }

        public void CargarGrid(string fechaevet)
        {
            //carga los datos del usuario del archivo txt segun el id del usuario y la fecha seleccionada
            List<Usuario> datusu = ubo.LeerArchivo("Archivo_Agenda.txt", (lblId.Text), fechaevet);         
            //se cargan los datos del usuario proveniente de la lista al datagrid
            dataGridAgenda.DataSource = datusu;
            //se ocultan las columnas que devuelve el get y que son inecesarias
            this.dataGridAgenda.Columns[1].Visible = false;
            this.dataGridAgenda.Columns[6].Visible = false;
            this.dataGridAgenda.Columns[7].Visible = false;
            this.dataGridAgenda.Columns[8].Visible = false;
            this.dataGridAgenda.Columns[9].Visible = false;
            //se le asignan nuevos nombre a las cabeceras de columnas
            dataGridAgenda.Columns[0].HeaderText = "Hora Dia";
            dataGridAgenda.Columns[2].HeaderText = "Actividades";
            dataGridAgenda.Columns[3].HeaderText = "Fecha";
            dataGridAgenda.Columns[4].HeaderText = "Hora Inicio";
            dataGridAgenda.Columns[5].HeaderText = "Hora Final";
            dataGridAgenda.Columns[2].Width = 290;
        }


        private void frmAgenda_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //permite cargar los datos segun la fecha seleccionada
            CargarGrid(dateTimeConsulta.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //permite postear un evento en el perfil de facebook del usuario
           
            fbC.Post("/me/feed", new { message = lblPost.Text });
            MessageBox.Show("Se ha compartido un evento en su perfil de Facebook",
            "Compartir con Facebook", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //carga la datos de la hora actual
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss  tt");
        }

        private void dataGridAgenda_SelectionChanged(object sender, EventArgs e)
        {
            //obtiene los datos del evento que el usuario quiere compartir y lo asigna  a un textbox
            if (publicar == true)
            {
                string evento = (string)dataGridAgenda.CurrentRow.Cells["archivoActividad"].Value;
                string hora1 = (string)dataGridAgenda.CurrentRow.Cells["InicioEvento"].Value;
                string hora2 = (string)dataGridAgenda.CurrentRow.Cells["FinEvento"].Value;
                lblPost.Text = evento + " " + " " + hora1 + " " + hora2;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmDropBox frm = new frmDropBox();
            this.Hide();
            frm.Show(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
