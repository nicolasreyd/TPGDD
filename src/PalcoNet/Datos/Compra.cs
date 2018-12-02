using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Datos
{
    public class Compra
    {
        public Decimal id;
        public Decimal id_usuario;
        public Decimal id_publicacion;
        public String compra_medio_pago;
        public String compra_mail;
        public Decimal compra_importe_total;
        public List<Ubicacion> ubicaciones;

        public Compra(){
            id_usuario = App.currentUser.user_id;
            ubicaciones = new List<Ubicacion>();
        }

    }
}
