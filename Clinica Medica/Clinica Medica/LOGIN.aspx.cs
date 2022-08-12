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
                //PREGUNTO QUE Rol TIENE PARA DARLE ACCESO AL FORM QUE
                //CORRESPONDA.
                switch (usuario.Rol.Id)
                {
                    //RECEPCIONISTA
                    
                    case 1:

                        //AGREGO AL USUARIO VALIDO EN Session, PARA NO MOSTRAR
                        //SU PASSWORD
                        
                        Session.Add("recepcionista", usuario);
                        Response.Redirect("RECEPCIONISTA_PRINCIPAL.aspx",false);
                        
                    break;

                    //MEDICO
                    
                    case 2:

                        Session.Add("medico", usuario);
                        Response.Redirect("MEDICO_LISTADO_TURNOS.aspx",false);
                    
                    break;

                    //NO PUEDE USAR UN PACIENTE LA APLICACION
                    //
                    case 4:

                        Response.Redirect("USUARIO_INEXISTENTE.aspx", false);
                    
                    break;

                }
            }
            else
            {
                lblUserOPassInvalido.Text += "El usuario o contraseña son invalidos";
            }
        }
    }
}