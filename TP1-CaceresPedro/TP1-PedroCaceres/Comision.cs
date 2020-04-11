using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_PedroCaceres
{
   public class Comision
    {
        public int IdComision { get; set; }
        public int LegajoAlumno { get; set; }
        public string Horario { get; set; }
        public string Aula { get; set; }
        public int LegProfesor { get; set; }
        public int LegAyudante { get; set; }
    }
}
