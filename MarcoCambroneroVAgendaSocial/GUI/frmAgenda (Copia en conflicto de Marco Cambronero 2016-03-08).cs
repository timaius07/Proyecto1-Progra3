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
        //#region Class members
        //readonly FacebookService fbService = new FacebookService();

        //private ScreenShotFormatter screenShotFormatter;

        //private List<long> friendsUids;

        //private List<Point> friendsPositions;
        //#endregion
        private UsuarioBO ubo;
                        //
        public frmAgenda(string nombre, string id)
        {
            InitializeComponent();
            ubo = new UsuarioBO();
            lbUsuario.Text = nombre;
            lbId.Text = id;

        //    // The application key of the Facebook application used
        //    fbService.ApplicationKey = "";
        //    // Add all needed permissions
        //    List<Enums.ExtendedPermissions> perms = new List<Enums.ExtendedPermissions>
        //                 {
        //                         Enums.ExtendedPermissions.none
        //                  };
        //    fbService.ConnectToFacebook(perms);
        }


        public void CargarGrid(string fechaevet)
        {
           
            List<Usuario> datusu = ubo.readFile("Archivo_Agenda.txt", (lbId.Text), fechaevet);


            dataGridAgenda.DataSource = datusu;
           // this.dataGridAgenda.Columns[0].Visible = false;
            this.dataGridAgenda.Columns[1].Visible = false;
            //this.dataGridAgenda.Columns[3].Visible = false;
            //this.dataGridAgenda.Columns[4].Visible = false;
            //this.dataGridAgenda.Columns[5].Visible = false;
            this.dataGridAgenda.Columns[6].Visible = false;
            this.dataGridAgenda.Columns[7].Visible = false;
            this.dataGridAgenda.Columns[8].Visible = false;



            dataGridAgenda.Columns[0].HeaderText = "Hora Dia";
            dataGridAgenda.Columns[2].HeaderText = "Actividades";
            dataGridAgenda.Columns[3].HeaderText = "Fecha";
            dataGridAgenda.Columns[4].HeaderText = "Hora Inicio";
            dataGridAgenda.Columns[5].HeaderText = "Hora Final";
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            // this.CargarGrid(dateTimeConsulta.Text);


            if (string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            {
                this.GetAccessToken();

            }
            else
            {
                this.GetFiles();
            }


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

        private void GetFiles()
        {
            throw new NotImplementedException();
        }

        private void GetAccessToken()
        {
            var login = new DropboxLogin("hq3o0ux7v7piyg8", "5fabnss64uofy9r");
            login.Owner = this;
            login.ShowDialog();
            if (login.IsSuccessfully)
            {
                Properties.Settings.Default.AccessToken = login.AccessToken.Value;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Error..");
            }



        }

        private void dataGridAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CargarGrid(dateTimeConsulta.Text);
        }
    }
}
