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
        static int idBorrar;
     
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["recepcionista"] == null)
            {
                Response.Redirect("ERROR.aspx", false);
            }
            if(!IsPostBack)
            {
                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                List<Usuario> usuarios = new List<Usuario>();
                usuarios = usuarioNegocio.listaPacientes(); 
                gvListadoPacientes.DataSource = usuarios;
                gvListadoPacientes.DataBind();
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("RECEPCIONISTA_PRINCIPAL.aspx",false);
        }

        protected void gvListadoPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvListadoPacientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            panelBorrar.Visible = true;
            var id = gvListadoPacientes.Rows[e.RowIndex].Cells[0].Text;
            
            //AL SER idBorrar static,EL VALOR SEGUIRA VIVO POR FUERA
            //DE LAS LLAVES.
            idBorrar = int.Parse(id);
        }

        //BOTON aceptar DEL PANEL (ELIMINARA EL REGISTRO)
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

            if (usuarioNegocio.eliminaPaciente(idBorrar))
            {
                //LLAMO NUEVAMENTE A bd PARA LISTAR
                //POCO PERFORMANTE
                gvListadoPacientes.DataSource = usuarioNegocio.listaPacientes();
                gvListadoPacientes.DataBind();
                panelBorrar.Visible = false;
            }
        }   
    }
}