using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class MedicoNegocio
    {
        AccesoaDatos accesoaDatos = new AccesoaDatos();

        public List<Medico> listarMedicos()
        {
            List<Medico> medicos = new List<Medico>();

            try
            {
                accesoaDatos.setearConsulta("select m.idMedico,m.nroMatricula,u.nombre,u.apellido from medicos as m inner join usuarios as u on m.idUsuario = u.id");
                accesoaDatos.ejecutarLectura();

                while (accesoaDatos.Lector.Read())
                {
                    Medico medico = new Medico();
                    medico.Nombre = (string)accesoaDatos.Lector["nombre"];
                    medico.Apellido = (string)accesoaDatos.Lector["apellido"];
                    medico.NroMatricula = (int)accesoaDatos.Lector["nroMatricula"];
                    medico.IdMedico = (int)accesoaDatos.Lector["idMedico"];

                    medicos.Add(medico);
                }

                return medicos;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                accesoaDatos.cerrarConexion();
            }
        }




    }
}
