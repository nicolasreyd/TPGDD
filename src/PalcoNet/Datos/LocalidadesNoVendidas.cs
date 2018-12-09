using System;

namespace PalcoNet.Datos
{
    public class LocalidadesNoVendidas
    {
        private String empresa { get; set; }
        private Int32 cantidad { get; set; }

        public LocalidadesNoVendidas(String p1, Int32 p2)
        {
            this.empresa = p1;
            this.cantidad = p2;
        }
    }
}