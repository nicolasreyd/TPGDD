using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PalcoNet.Login
{
    public partial class SeleccionRol : Form
    {

        public SeleccionRol()
        {
            InitializeComponent();
            List<Datos.Rol> roles = App.currentUser.getRoles();
            
            roles.ForEach(delegate(Datos.Rol rol){
                comboRoles.Items.Add(rol.nombre_rol);
        
        });
            
 
           comboRoles.SelectedItem = roles.First().nombre_rol;
           
     }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SeleccionRol_Load(object sender, EventArgs e)
        {

        }

        private void ButtonOKRoles_Click(object sender, EventArgs e)
        {
            Console.WriteLine("select rol_id,rol_nombre from gd_esquema.Rol where rol_nombre = " + this.comboRoles.SelectedItem);
            SqlDataReader data = App.db.command_reader("select rol_id,rol_nombre from gd_esquema.Rol where rol_nombre = '" + this.comboRoles.SelectedItem + "'");
            App.currentRol = new Datos.Rol(data.GetDecimal(0), data.GetString(1));
            data.Close();

        }
    }
}
