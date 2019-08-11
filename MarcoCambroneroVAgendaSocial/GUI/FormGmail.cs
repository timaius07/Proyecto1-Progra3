using MarcoCambroneroVAgendaSocial.BO;
using MarcoCambroneroVAgendaSocial.Entidades;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcoCambroneroVAgendaSocial.GUI
{
    public partial class FormGmail : Form
    {
        private int cont = 0;// contador que sirve para que solo una vez obtenga el accres token
        string idUsuario = "";// almamcena el id del usuario 
        string nombreGmail = "";// almacena el nombre de la cuenta
        string urlImagen = "";// almacena el url de la imagen de la cuenta

        private frmMenu frmMen;
        public Usuario usuario { get; set; }

        public AuthResponse access = new AuthResponse();
        public FormGmail()
        {
            InitializeComponent();
            //Display the authenticationRequest to the user.
            webBrowser1.Navigate(AuthResponse.GetAutenticationURI(clientId, redirectURI));
        }
        /// <summary>
        /// variables con los datos de la aplicacion de que se crea en google Developers
        /// </summary>
        public const string clientId = "954532276731-2t9a2lr37a54lvb6spnh4gvch5ktc1st.apps.googleusercontent.com";
        public const string clientSecret = "-LL3O3P7BuuRjJRFmGZy-SwW";
        public const string redirectURI = "urn:ietf:wg:oauth:2.0:oob";

        /// <summary>
        /// The authentication code is returned in the webbrowser.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

            


        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string Mytitle = ((WebBrowser)sender).DocumentTitle.ToLower();
            if (Mytitle.IndexOf("success code=") > -1)
            {
                if (cont == 0)
                {
                    webBrowser1.Visible = false;


                    // extrae el autentificador del usuario del webBrowser 
                    string AuthCode = webBrowser1.DocumentTitle.Replace("Success code=", "").Split('&')[0];

                    // extrae el access token del usuario para poder ver sus datos 
                    access = AuthResponse.Exchange(AuthCode, clientId, clientSecret, redirectURI);
                    // cierra la venta frm del webBrower
        //            processAccess();
                    GetDatos();
                    //obtiene los datos con el access token, con el json covert
                    // Abre el frm de menu con los datos del usuario
                    OpenMenu();
                    cont++;
                }
              //  this.Hide();
            }
        }



        public void GetDatos()
        {  //get access token to use in profile image request
            Uri apiRequestUri = new Uri("https://www.googleapis.com/oauth2/v2/userinfo?access_token=" + access.Access_token);


            //request profile image
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(apiRequestUri);
                dynamic result = JsonConvert.DeserializeObject(json);
                // datos necesarios del usuario
                idUsuario = result.id;
                urlImagen = result.picture;
                nombreGmail = result.name;
                // set de los datos 
                usuario = new Usuario(idUsuario, nombreGmail, urlImagen);
                frmMen = new frmMenu(nombreGmail, idUsuario, urlImagen);

                this.Visible = false;
            }
        }


        /// <summary>
        /// metodo que abre el frm menu para seleccionar lo que uno desea hacer 
        /// </summary>
        public void OpenMenu()
        {
            this.Hide();
            frmMen.Show();
        }
    }
}
