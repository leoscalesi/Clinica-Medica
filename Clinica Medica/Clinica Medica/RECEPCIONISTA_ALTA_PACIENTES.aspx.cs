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
            //SI RECIBO UN id, ES PORQUE QUIERO MODIFICAR, 
            //POR LO TANTO, DEBO CARGAR TODOS SUS DATOS.
            if (Session["recepcionista"] == null)
            {
                Response.Redirect("ERROR.aspx", false);
            }
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    btnAgregar.Text = "";
                    btnAgregar.Text = "Modificar";
                    
                    int id = int.Parse(Request.QueryString["id"].ToString());
                    UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                    Usuario usuario = new Usuario();
                    //BUSCAR EL PACIENTE CON ESE id
                    usuario = usuarioNegocio.buscaUsuarioId(id);
                    
                    if(usuario != null)
                    {
                        txtNombre.Text = usuario.Nombre;
                        txtApellido.Text = usuario.Apellido;
                        txtUsuario.Text = usuario.User;
                    }
                }    
            }
           
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            btnAgregar.Text = "";
            btnAgregar.Text = "Agregar";
            
            Usuario paciente = new Usuario();
            paciente.Nombre = txtNombre.Text;
            paciente.Apellido = txtApellido.Text;
            paciente.User = txtUsuario.Text;
            

            //SI PUEDO RECUPERARUN Id, ES PORQUE QUIERO MODIFICAR
            //Y NO AGREGAR
            
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            
            //MODIFICAR
            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                paciente.Id = id;   
                
                if (usuarioNegocio.modificarPaciente(paciente))
                {
                    Response.Redirect("GUARDADO_EXITOSO.aspx", false);
                }
                else
                {
                    Response.Redirect("ERROR.aspx", false);
                }
            }
            else
            {
                //AGREGAR
                if (usuarioNegocio.agregarPaciente(paciente))
                {
                    Response.Redirect("GUARDADO_EXITOSO.aspx", false);
                }
                else
                {
                    Response.Redirect("ERROR.aspx", false);
                }
            }
            
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("RECEPCIONISTA_LISTADO_PACIENTES.aspx",false);
        }
    }
}