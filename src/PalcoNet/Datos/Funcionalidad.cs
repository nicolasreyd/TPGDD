using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Datos
{
    
    public class Funcionalidad
    {
        public String nombre { get; set;}
        public Decimal id { get; set;}

        public Funcionalidad(Decimal id_func, String nombre_func) {
            this.nombre = nombre_func;
            this.id = id_func;
        }

    }
}
