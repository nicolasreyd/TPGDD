using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Datos
{
    public class Rubro
    {
        public Decimal id;
        public String descripcion;

        public Rubro(Decimal id_rubro, String descripcion_rubro) {

            this.id = id_rubro;
            this.descripcion = descripcion_rubro;
        }
    }
}
