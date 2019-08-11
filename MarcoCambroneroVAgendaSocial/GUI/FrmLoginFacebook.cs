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
using System.Dynamic;
using MarcoCambroneroVAgendaSocial.Entidades;

namespace MarcoCambroneroVAgendaSocial.GUI
{
    public partial class FrmLoginFacebook : Form
    {
        private FacebookClient FBClient;
        public string AccessToken { get; set; }  
        public Usuario usuario { get; set; }
        private string idusuario;
        private string nombre;
        private frmMenu frmMen;
        private bool conecface;
        public FrmLoginFacebook()
        {
            InitializeComponent();                                                         //id de la app Agenda Social                   redireccionamiento a facebook       //obtiene los permisos para postear y publicar              uri hace referencia  a un recurso ej: direccionweb
            wbFacebook.Navigate(new Uri("https://graph.facebook.com/oauth/authorize?client_id=1732665820314032&redirect_uri=http://www.facebook.com/connect/login_success.html&scope=user_posts,publish_actions&type=user_agent&display=popup", UriKind.Absolute));
        }

        private void WBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            //validacion para q el webbroser no entre por segunda vez
            if (conecface == false)
            {
                if (e.Url.ToString().StartsWith("http://www.facebook.com/connect/login_success.html"))
                {
                    //obtenemos el token que nos dara autorizacion para ver los datos del usuario
                    AccessToken = e.Url.Fragment.Split('&')[0].Replace("#access_token=", "");
                    FBClient = new FacebookClient(AccessToken);
                    dynamic me = FBClient.Get("Me");
                    //obtenesmos los datos del usuario
                    nombre = me.name.ToString();
                    idusuario = me.id.ToString();
                    //obtenemos la imagen del perfil del usuario
                    Uri img = new Uri("https://graph.facebook.com/" + me.id.ToString() + "/picture/");
                    //activamos la variable para que no entre por segunda vez
                    conecface = true;
                    //enviamos los datos a la entidad usuario y al frame de menu
                    usuario = new Usuario(idusuario, nombre, img);                   
                    frmMen = new frmMenu(nombre, idusuario, img, conecface, AccessToken);
                    frmMen.Show();
                    this.Hide();
                }

            }
        }


        private void FrmLoginFacebook_FormClosing(object sender, FormClosingEventArgs e)
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

    }
}
