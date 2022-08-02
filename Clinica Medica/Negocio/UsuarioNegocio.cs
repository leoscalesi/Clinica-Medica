using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Dominio;



//BIBLIOTECA DE CLASES PARA Negocio
namespace Negocio
{
    
    public class UsuarioNegocio
    {
        AccesoaDatos accesoDatos = new AccesoaDatos();

        public Usuario buscaUsuarioMailPass (string email,string pass)
        {
            try
            {
                accesoDatos.setearConsulta("select id,usuario,pass,nombre,apellido,idRol from Usuarios where usuario = " + "'" + email + "'" + " and pass = " + "'" + pass + "'");
                accesoDatos.ejecutarLectura();

                if (accesoDatos.Lector.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = (int)accesoDatos.Lector["id"];
                    usuario.User = (string)accesoDatos.Lector["usuario"];
                    usuario.Pass = (string)accesoDatos.Lector["pass"];
                    usuario.Nombre = (string)accesoDatos.Lector["nombre"];
                    usuario.Apellido = (string)accesoDatos.Lector["apellido"];
                    usuario.Rol = new Rol();
                    usuario.Rol.Id = (int)accesoDatos.Lector["idRol"];

                    return usuario;
                }
                else
                {
                    return null;
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    
        //SI BIEN EL PACIENTE NO ES UN USUARIO DE ESTA APLICACION
        //QUEDA ESTE METODO DENTRO DE USUARIO
        
        public List<Usuario> listaPacientes()
        {
            List<Usuario> usuarios = new List<Usuario>();
            
            try
            {
                //LOS PACIENTES TENDRAN idRol = 4
                accesoDatos.setearConsulta("select id,usuario,nombre,apellido from Usuarios where idRol = " + 4);
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = (int)accesoDatos.Lector["id"];
                    usuario.User = (string)accesoDatos.Lector["usuario"];
                    usuario.Nombre = (string)accesoDatos.Lector["nombre"];
                    usuario.Apellido = (string)accesoDatos.Lector["apellido"];
                
                    usuarios.Add(usuario);
                }

                return usuarios;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
