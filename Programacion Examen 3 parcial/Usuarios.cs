using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_Examen_3_parcial
{
    internal class Usuarios
    {
        private static List<Usuarios> usuarios = new List<Usuarios>
        {
            new Usuarios{NombreUsuario = "Admin", Contrasenia = "1234"},
            new Usuarios{NombreUsuario = "Juan", Contrasenia = "3333"},
            new Usuarios{NombreUsuario = "Adrian", Contrasenia = "2548"}
        };
        public Usuarios(string nombreUsuario, string contrasenia)
        {
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
        }
        public List<Usuarios> ObtenerUsuario()
        {
            return usuarios;
        }
        public Usuarios() { }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
    }

}

