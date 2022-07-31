using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

//Al crear el proyecto: Proyecto ASP.NET Framework Web Vacio

namespace Clinica_Medica
{
    public partial class LOGIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pass = txtPassword.Text;
            Usuario usuario = new Usuario();    
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

            usuario = usuarioNegocio.buscaUsuarioMailPass(user, pass);

            if (usuario != null)
            {

            }
            else
            {
                lblUserOPassInvalido.Text += "El usuario o contraseña son invalidos";
            }
        }
    }
}