using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Datos
{
    public class Rol
    {
        public Decimal id_rol;
        public String nombre_rol;

        public String getNombre_rol() {
         
            return nombre_rol;
        }

        public Rol(Decimal idrol, String nombrerol) {
            id_rol = idrol;
            nombre_rol = nombrerol;
        }

        public List<String> getFuncionalidades()
        {
            return App.db.getFuncionalidades(this.id_rol);
        }
    }
}
