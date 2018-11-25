using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Datos
{
    public class Publicacion
    {
        public Decimal id;
        public Decimal id_responsable;
        public String descripcion;
        public DateTime fecha_publicacion;
        public DateTime fecha_espectaculo;
        public String rubro;
        public String estado;
        public String direccion;

        public Publicacion(){
            id_responsable = App.currentUser.user_id;
        }

    }
}
