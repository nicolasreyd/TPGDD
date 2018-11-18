using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Datos
{
    public class Usuario
    {

        public string username;
        public Decimal user_id;
  

        public Usuario(Decimal id_usuario, String user_name)
        {
            this.username = user_name;
            this.user_id = id_usuario;
        }

        public List<Rol> getRoles()
        {
            return App.db.getRoles(this.user_id);
        }
    }
}
