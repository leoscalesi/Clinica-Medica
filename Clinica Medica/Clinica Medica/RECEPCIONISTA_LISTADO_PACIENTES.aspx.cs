using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Clinica_Medica
{
    public partial class RECEPCIONISTA_LISTADO_PACIENTES : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["recepcionista"] == null)
            {
                Response.Redirect("ERROR.aspx", false);
            }
            else
            {
                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                List<Usuario> usuarios = new List<Usuario>();
                usuarios = usuarioNegocio.listaPacientes(); 
                gvListadoPacientes.DataSource = usuarios;
                gvListadoPacientes.DataBind();
            
            }
        }
    }
}