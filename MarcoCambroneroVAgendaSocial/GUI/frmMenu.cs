using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;

namespace MarcoCambroneroVAgendaSocial.GUI
{
    public partial class frmMenu : Form
    {
        public string nomUsu;
        public string idUsu = "";
        public string urlimagen = "";
        public Uri imgFace;
        public bool logface;
        public string accesToken;



        private void btnConsulta_Click(object sender, EventArgs e)
        {
            //validamos que si se conecto con facebook para entrar al frmAgenda
            if (logface == true)
            {
                frmAgenda frm = new frmAgenda(nomUsu, idUsu, imgFace, accesToken);
                this.Hide();
                frm.Show(this);
            }
            //se conectoo con gmail
            else
            {
                frmAgenda frm = new frmAgenda(nomUsu, idUsu, urlimagen);
                this.Hide();
                frm.Show(this);
            }

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            //validamos que si se conecto con facebook para entrar al frmIngreso
            if (logface == true)
            {
                Ingreso frm = new Ingreso(nomUsu, idUsu, imgFace);
                this.Hide();
                frm.Show(this);
            }
            //se conectoo con gmail
            else
            {
                Ingreso frm = new Ingreso(nomUsu, idUsu, urlimagen);
                this.Hide();
                frm.Show(this);
            }
        }
        /// <summary>
        /// cierra las opciones de la agenda y inicia el el frm menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Realmente desea Salir de la Agenda?", " Salir",
         MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                FrmInicio frn = new FrmInicio();
                WebBrowser web = new WebBrowser();
                // web.Navigate("https://www.facebook.com/logout.php", accesToken);
                frn.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

        //recibe los datos si conecta mediante gmail
        public frmMenu(string nombre, string id, String urlimge)
        {
            InitializeComponent();
            nomUsu = nombre;
            lblNombre.Text = nombre;
            idUsu = id;
            urlimagen = urlimge;
        }
        //recibe los datos si se conecta mediante facebook
        public frmMenu(string nombre, string id, Uri urlimge, bool conecface, string accessTok)
        {
            InitializeComponent();
            nomUsu = nombre;
            lblNombre.Text = nombre;
            idUsu = id;
            imgFace = urlimge;
            logface = conecface;
            accesToken = accessTok;
        }



    }
}
