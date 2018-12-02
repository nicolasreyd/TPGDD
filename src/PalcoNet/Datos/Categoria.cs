using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Datos
{
    public class Categoria
    {
        public string descripcion { get; set; }
        public Decimal id { get; set; }

        public Categoria(Decimal _id, string _descricpcion) {
            this.descripcion = _descricpcion;
            this.id = _id;
        }
    }
}
