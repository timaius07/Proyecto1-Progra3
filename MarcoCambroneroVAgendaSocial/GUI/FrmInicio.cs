using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcoCambroneroVAgendaSocial.GUI
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }
        public FrmInicio(string nom, string cuenta)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLoginFacebook frmfcb = new FrmLoginFacebook();
            frmfcb.Show(this);
            this.Hide();

        }
        /// <summary>
        /// btn sirve para comenzar el proceso de comprobacion de la cuenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormGmail m = new FormGmail();
            m.ShowDialog(this);

        }
         private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
