using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class EspecialidadNegocio
    {
       AccesoaDatos accesoaDatos = new AccesoaDatos();

       public List<Especialidad> listarEspecialidades()
       {
            List<Especialidad> lista = new List<Especialidad>();    
            
            try
            {
                accesoaDatos.setearConsulta("select id,descripcion from Especialidades");
                accesoaDatos.ejecutarLectura();

                while (accesoaDatos.Lector.Read())
                {
                    Especialidad especialidad = new Especialidad();

                    especialidad.Id = (int)accesoaDatos.Lector["id"];
                    especialidad.Descripcion = (string)accesoaDatos.Lector["descripcion"];
                   
                    lista.Add(especialidad);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoaDatos.cerrarConexion();  
            }
        }
    }
}
