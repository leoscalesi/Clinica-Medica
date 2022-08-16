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
    public partial class RECEPCIONISTA_ALTA_MEDICOS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //CARGAR EL ddl

            if (Session["recepcionista"] == null)
            {
                Response.Redirect("ERROR.aspx",false);
            }
            if (!IsPostBack)
            {
                EspecialidadNegocio especialidadNegocio = new EspecialidadNegocio();
                ddlEspecialidades.DataTextField = "descripcion";
                ddlEspecialidades.DataSource = especialidadNegocio.listarEspecialidades();
                ddlEspecialidades.DataBind();
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("RECEPCIONISTA_PRINCIPAL.aspx",false );
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        protected void btnEliminarEspecialidades_Click(object sender, EventArgs e)
        {
            lbEspecialidades.Items.Clear();
        }

        protected void ddlEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccionado = ddlEspecialidades.SelectedValue;
            lbEspecialidades.Items.Add(seleccionado);
        }
    }
}