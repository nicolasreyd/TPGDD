using System;

namespace PalcoNet.Datos
{
    public class PuntosVencidos
    {
        private Decimal documento { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        private Decimal suma { get; set; }

        public PuntosVencidos(Decimal v1, string v2, string v3, Decimal v4)
        {
            this.documento = v1;
            this.nombre = v2;
            this.apellido = v3;
            this.suma = v4;
        }
    }
}