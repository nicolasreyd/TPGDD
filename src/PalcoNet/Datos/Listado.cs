using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Datos
{
    public class Listado
    {
        public string codigo { get; set; }
        public string nombre { get; set; }

        public Listado(string codigo, string nombre) {
            this.codigo = codigo;
            this.nombre = nombre;
        }
    }
}
