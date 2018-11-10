using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Datos
{
    public class Rol
    {
        public static int id_rol;
        public static String nombre_rol;

        public Rol(int idrol, String nombrerol) {
            id_rol = idrol;
            nombre_rol = nombrerol;
        }
    }
}
