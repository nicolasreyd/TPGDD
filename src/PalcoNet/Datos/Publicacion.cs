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
        public string descripcion;
        public DateTime fecha_publicacion;
        public DateTime fecha_espectaculo;
        public string rubro;
        public string estado;
        public string direccion;
        public Datos.Grado grado;
        public List<Ubicacion> ubicaciones;

        public Publicacion(){
            id_responsable = App.currentUser.user_id;
            ubicaciones = new List<Ubicacion>();
        }

    }
}
