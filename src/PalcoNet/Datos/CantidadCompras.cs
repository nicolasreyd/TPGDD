using System;

namespace PalcoNet.Datos
    
{
    public class CantidadCompras
    {
        private Int32 cantidad;
        private Decimal clienteDocumento;
        private String clienteNombre;
        private String clienteApellido;
        private String empresaRazonSocial;
        public CantidadCompras(Int32 v1, Decimal v2, String v3, String v4, String v5)
        {
            this.cantidad = v1;
            this.clienteDocumento = v2;
            this.clienteNombre = v3;
            this.clienteApellido = v4;
            this.empresaRazonSocial = v5;
        }
    }
}