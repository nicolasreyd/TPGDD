using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Datos
{
    public class Grado
    {
        public string descripcion { get; set; }
        public Decimal id { get; set; }
        public Decimal comision { get; set; }

        public Grado(string _descricpcion, Decimal _id, Decimal _comision) {
            this.descripcion = _descricpcion;
            this.id = _id;
            this.comision = _comision;
        }
    }
}
