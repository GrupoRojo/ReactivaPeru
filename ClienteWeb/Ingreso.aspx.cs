using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//para autenticar 
using System.Web.Security;

namespace ClienteWeb
{
    public partial class Ingreso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            //Autenticar sin base
            String usuario = Login1.UserName;
            string contras = Login1.Password;
            if (usuario == "juan" && contras == "123")
            {
                FormsAuthentication.RedirectFromLoginPage(usuario, false);
            }
            else
            {
                Login1.FailureText = "Usuario y/o Contraseña Incorrecto";
            }
        }
    }
}