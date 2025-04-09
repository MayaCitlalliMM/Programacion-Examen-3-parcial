using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_Examen_3_parcial
{
    internal class Consola
    {
        public Consola() { }
        public Consola(int iD, string name, DateTime fecha, bool activo)
        {
            ID = iD;
            Name = name;
            Fecha = fecha;
            Activo = activo;
        }

        public int ID {  get; set; }
        public string Name { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }
    }
}
