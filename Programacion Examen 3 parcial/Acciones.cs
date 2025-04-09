using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_Examen_3_parcial
{
    internal class Acciones
    {
        Hijo a = new Hijo();


        List<Hijo> PersonasJugando = new List<Hijo>
        {
            new Hijo(1129,"Nintendo",DateTime.Now,true,"Rojo"),
            new Hijo(2901,"PSD 4",DateTime.Now,false,"Rosa")
            

        };
        public List<Hijo> MostrarJugador()
        {
            return PersonasJugando;
        }
        public bool ActualizarJugador(int iD, string name, DateTime fecha, bool activo, string colorInterfaz)
        {

            //asda
            try
            {
                var objetliminar = PersonasJugando.Find(x => x.ID == iD);
                objetliminar.Name = name;
                objetliminar.Fecha = fecha;
                objetliminar.Activo = activo;
                objetliminar.ColorInterfaz = colorInterfaz;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool EliminarJugador(int iD)
        {


            try
            {
                var objetliminar = PersonasJugando.Find(x => x.ID == iD);
                if (objetliminar != null)
                {
                    PersonasJugando.Remove(objetliminar);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool AgregarJugador(int iD, string name, DateTime fecha, bool activo, string colorInterfaz)
        {
            try
            {
                PersonasJugando.Add(new Hijo(a.ID = iD,a.Name = name,a.Fecha = fecha,a.Activo = activo,a.ColorInterfaz = colorInterfaz));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
