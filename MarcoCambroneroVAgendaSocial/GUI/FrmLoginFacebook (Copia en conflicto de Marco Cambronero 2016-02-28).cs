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
using MarcoCambroneroVAgendaSocial.GUI;

namespace MarcoCambroneroVAgendaSocial.GUI
{
    public partial class FrmLoginFacebook : Form
    {
        //atributos iniciales de la clase
        private const string AppId = "1732665820314032";//ID de la aplicacion necesario para acceder desde facebook
        private Uri _loginUrl; //El Uri sirve para iniciar una aplicacion en el frame
        private string client_secret = "a1be56de09252b974a7f2a2a6c72288b"; //Este es el App Secret generado para la aplicacion de FB

       // private const string _ExtendedPermissions = "user_about_me";
        FacebookClient fb = new FacebookClient();

        public FrmLoginFacebook()
        {
            InitializeComponent();
        }
        /// <summary>
        /// /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void FrmLoginFacebook_Load(object sender, EventArgs e)
        {
            Login(); //llamamos al metodo Login
        }
        /// <summary>
        /// este metodo contiene el algoritmo para que un usuario pueda iniciar una session de facebook
        /// </summary>
        private void Login()
        {
            dynamic parameters = new ExpandoObject(); //Creamos un objeto dinamico que pueda almacenar los parametros
            parameters.client_id = AppId; //Al parametro le metemos el app_id
            parameters.redirect_uri = "https://www.facebook.com/connect/login_success.html"; //Al pararemtros lo insertamos la direccion de login
            parameters.client_secret = client_secret;
            /*En este parametro vamos a guardar el tipo de la respuesta, ya sea
             * un token de acceso (token), un codigo de autorizacion (codigo) o
             * ambos (token codigo)
             */
            parameters.response_type = "token";
            parameters.display = "popup"; //Esto se utiliza para mostrar un mensaje en el FB
            //Generar la URL de inicio de sesion
            parameters.scope = "email";
            _loginUrl = fb.GetLoginUrl(parameters);
            wbFacebook.Navigate(_loginUrl.AbsoluteUri); //Ejecuta el inicio de sesion
        }


        /// <summary>
        /// Este metodo lo que hace es medir cuando en el web browser se realiza un cambio en la pagina.
        /// Como la pagina que va a abrir es la del login, luego el va a validar que si lo que digito es correcto
        /// le cargue otra pagina, a la hora que se realiza la carga el cierra el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CambioPagina(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                if (e.Url.AbsolutePath.ToString().Equals("/connect/login_success.html"))
                {
                  
                    String url = e.Url.ToString();
                    String[] array = url.Split(new char[] { '=', '&' });
                    fb.AccessToken = array[1];
                    dynamic informacion = fb.Get("/me");
                    Ingreso frm = new Ingreso( informacion.name, informacion.id);
                    this.Hide();
                    frm.Show(this);
                    //(this.Owner as FrmInicioDeSesion).Dispose();
                }
            }
            catch (FacebookOAuthException)
            {
                throw new Exception("Inicio no válido");
            }
        }






        private void FrmLoginFacebook_FormClosing(object sender, FormClosingEventArgs e)
        {
              
            if (MessageBox.Show("Realmente desea Salir?", "",
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
