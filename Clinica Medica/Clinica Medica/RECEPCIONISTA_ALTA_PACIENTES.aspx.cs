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
    public partial class RECEPCIONISTA_ALTA_PACIENTES : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario paciente = new Usuario();
            paciente.Nombre = txtNombre.Text;
            paciente.Apellido = txtApellido.Text;
            
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            if (usuarioNegocio.agregarPaciente(paciente))
            {
                Response.Redirect("GUARDADO_EXITOSO.aspx",false);
            }

        }
    }
}