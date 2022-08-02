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
    public partial class RECEPCIONISTA_PRINCIPAL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //RECUPERO EL NOMBRE Y APELLIDO DE LA RECEPCIONISTA
            //SI NO HAY NADA EN Session REDIRECCIONO A UNA PAGINA
            //DE ERROR.

            if (Session["recepcionista"] == null)
            {
                Response.Redirect("ERROR.aspx",false);
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario = (Usuario)Session["recepcionista"];
                
                lblHolaRecepcionista.Text += usuario.Nombre + " " + usuario.Apellido; 
            }

        }

        protected void btnCargarAgenda_Click(object sender, EventArgs e)
        {

        }

        protected void btnBrindarTurnos_Click(object sender, EventArgs e)
        {

        }

        protected void btnPacientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("RECEPCIONISTA_LISTADO_PACIENTES.aspx",false);
        }

        protected void btnAltaPacientes_Click(object sender, EventArgs e)
        {

        }

        protected void btnMedicos_Click(object sender, EventArgs e)
        {

        }

        protected void btnAltaMedicos_Click(object sender, EventArgs e)
        {

        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("LOGIN.aspx",false);
        }
    }
}