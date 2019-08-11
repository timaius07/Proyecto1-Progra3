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
      public string idUsu="";
      public string urlimagen = "";
      private FacebookClient FaceBClient;


        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmAgenda frm = new frmAgenda(nomUsu, idUsu);
            frmAgenda frm2 = new frmAgenda(FaceBClient);
            this.Hide();
            frm.Show(this);
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            Ingreso frm = new Ingreso(nomUsu, idUsu,urlimagen);
            Ingreso frm2 = new Ingreso(FaceBClient);
            this.Hide();
            frm.Show(this);
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Realmente desea Salir?", " Salir",
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

      

        public frmMenu(string nombre, string id,String urlimge)

        {
            InitializeComponent();
            nomUsu = nombre;
            idUsu = id;
            urlimagen = urlimge;
        }
        public frmMenu(FacebookClient FBClient)
        {
            //InitializeComponent();
            FaceBClient = FBClient;
        }

        
    }
}
