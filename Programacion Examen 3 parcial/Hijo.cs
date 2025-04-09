using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_Examen_3_parcial
{
    internal class Hijo:Consola
    {
        public Hijo() { }
        public Hijo(int iD, string name, DateTime fecha, bool activo,string colorInterfaz)
             : base(iD, name, fecha, activo)
        {
            ColorInterfaz = colorInterfaz;
        }

        public string ColorInterfaz {  get; set; }
    }
}
