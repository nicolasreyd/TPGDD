using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Datos
{
    public class Grado
    {
        public string descripcion;
        public Decimal id;
        public Decimal comision;

        public Grado(string _descricpcion, Decimal _id, Decimal _comision) {
            this.descripcion = _descricpcion;
            this.id = _id;
            this.comision = _comision;
        }
    }
}
