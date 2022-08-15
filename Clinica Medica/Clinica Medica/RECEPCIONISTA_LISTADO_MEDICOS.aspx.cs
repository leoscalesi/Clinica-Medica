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
    public partial class RECEPCIONISTA_LISTADO_MEDICOS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["recepcionista"] == null)
            {
                Response.Redirect("ERROR.aspx", false);
            }
            if (!IsPostBack)
            {
                MedicoNegocio medicoNegocio = new MedicoNegocio();
                List<Medico> medicos = new List<Medico>();
                medicos = medicoNegocio.listarMedicos();
                gvListadoMedicos.DataSource = medicos;
                gvListadoMedicos.DataBind();
            }
        }

        protected void gvListadoMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvListadoMedicos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("RECEPCIONISTA_PRINCIPAL.aspx", false);
        }
    }
}