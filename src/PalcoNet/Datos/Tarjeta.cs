using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Datos
{
    
    public class Tarjeta
    {
        public Decimal id { get; set;}
        public Decimal numero { get; set;}
        public DateTime vencimiento { get; set; }
        public Decimal clienteId { get; set; }

        public Tarjeta(Decimal id_tarjeta, Decimal numero, DateTime vencimiento, Decimal clienteId) {
            this.id = id_tarjeta;
            this.numero = numero ;
            this.vencimiento = vencimiento;
            this.clienteId = clienteId;
        }

    }
}
