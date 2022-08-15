using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Medico : Usuario
    {
        public int IdMedico { get; set; }
        public int IdUsuario { get; set; }
        public int NroMatricula { get; set; }
        public Especialidad Especialidad{ get; set; }

    }
}
