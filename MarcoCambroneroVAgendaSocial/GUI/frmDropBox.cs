using Nemiro.OAuth;
using Nemiro.OAuth.LoginForms;
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
using System.Net;

namespace MarcoCambroneroVAgendaSocial.GUI
{
    public partial class frmDropBox : Form
    {
        string CurretPath = "/";
        public frmDropBox()
        {
            InitializeComponent();
        }
        /// <summary>
        /// inicia la autenticacion con dropbox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frmDropBox_Load(object sender, EventArgs e)
        {
            this.GetAccessToken();
            this.GetFiles();
        }
        /// <summary>
        /// obtiene los archivos que estan en dropbox en la api creada 
        /// </summary>
        private void GetFiles()
        {

            OAuthUtility.GetAsync(

       "https://api.dropbox.com/1/metadata/auto/",
            new HttpParameterCollection
            {
                {"path", this.CurretPath },
                {"access_token", Properties.Settings.Default.AccessToken  }

            },
                callback: GetFiles_Resul
            );

        }
        /// <summary>
        /// Carga los datos encontrados en el api de dropbox, cargandolos con un formato univalue en el lisbox 
        /// </summary>
        /// <param name="result"></param>
        private void GetFiles_Resul(RequestResult result)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<RequestResult>(GetFiles_Resul), result);
                return;
            }
            // si la consulta es exitosa devulve un 200, y carga los datos encontrados en la nube de dropbox
            if (result.StatusCode == 200)
            {
                DropBox.Items.Clear();

                DropBox.DisplayMember = "path";
                foreach (UniValue file in result["contents"])
                {
                    // añade los archivos encontrados en el lisbox
                    DropBox.Items.Add(file);

                }
                if(this.CurretPath != "/")
                {
                    DropBox.Items.Insert(0,"...");
                }

            }
            else
            {
                MessageBox.Show("Error..");
            }


        }
        /// <summary>
        /// metodo que obtiene la autenticacion del ususraio para poder obtener los datos guardados y 
        /// tamnien poder importarlos.
        /// </summary>
        private void GetAccessToken()
        {
            // 
            var login = new DropboxLogin("hq3o0ux7v7piyg8", "5fabnss64uofy9r");
            login.Owner = this;
            login.ShowDialog();
            if (login.IsSuccessfully)
            {
                // se igula es acces toke a la varible que se utiliza en toda la clase
                Properties.Settings.Default.AccessToken = login.AccessToken.Value;
               // se guarda en memoria
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Error..");
            }



        }
        
       
           ///  con el doble clik importa el archivo lo guarda donde el usuario lo desea
        private void listBox_Doubleclik(object sender, EventArgs e)
        {
            if (DropBox.SelectedItem == null) { return; }
            //esta variable obtiene un el item que le dan click, un lo combierte 
            UniValue file = (UniValue) DropBox.SelectedItem;
       
            if (file["path"] == "...")
            {
                if (this.CurretPath !="/")
                {
                    this.CurretPath = Path.GetDirectoryName(this.CurretPath).Replace("\\", "/");
                }
            }
            else
            {

                if (file["is_dir"] == 1)
                {
                    this.CurretPath = file["path"].ToString();
                }
                else
                {
                    saveFileDialog1.FileName = Path.GetFileName(file["path"].ToString());
                    if (saveFileDialog1.ShowDialog()!=System.Windows.Forms.DialogResult.OK)
                    {
                        return;
                    }

                    var web = new WebClient();
                    web.DownloadFile(string.Format("https://api-content.dropbox.com/1/files/auto{0}?access_token={1}",file["path"], Properties.Settings.Default.AccessToken), saveFileDialog1.FileName);
                }

            }
            this.GetFiles();

        }
 /// <summary>
 /// abre el openDialog para agregar un archivo al dropbox 
 /// </summary>
 /// <param name="sender"></param>
 /// <param name="e"></param>
        private void btnUpFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK) { return; }
            OAuthUtility.PutAsync
               (
             // url que nos dirige al disco virtual de dropbox para poder almacenar la actividad 
               "https://api-content.dropbox.com/1/files_put/auto/",
               new HttpParameterCollection
               {
                    {"access_token", Properties.Settings.Default.AccessToken },
                    {"path", Path.Combine(this.CurretPath, Path.GetFileName(openFileDialog1.FileName)).Replace("\\", "/") },
                   {"autorename","true" },
                   {openFileDialog1.OpenFile() }

               }, callback: Upload_Resul
                );

        }

        private void Upload_Resul(RequestResult result)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<RequestResult>(Upload_Resul), result);
                return;
            }
            if (result.StatusCode == 200)
            {

                this.GetFiles();
            }
            else
            {
                if (result["error"].HasValue)
                {
                    MessageBox.Show(result["Error"].ToString());
                }
                else
                {
                    MessageBox.Show(result.ToString());
                }
            }
        }

        private void frmDropBox_FormClosing(object sender, FormClosingEventArgs e)
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
    }
    }
