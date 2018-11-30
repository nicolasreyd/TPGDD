using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Datos
{
    public class Ubicacion
    {
        public Decimal id;
        public int numerada;
        public String Fila; //2 caracteres validarlo en textbox
        public int Asiento; //3 caracteres validarlo en textbox
        public Decimal precio;
        public Decimal tipo;

    }
}
