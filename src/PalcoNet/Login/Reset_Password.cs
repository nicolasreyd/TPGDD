using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Login
{
    public partial class Reset_Password : Form
    {

        int id_usuario ;
        public Reset_Password(Decimal idUsuario)
        {
            InitializeComponent();

            id_usuario = Convert.ToInt32(idUsuario);
        }

        private void cambiarPass_button_Click(object sender, EventArgs e)
        {
            string msjError = "";
            if (ingresarPass_textBox.Text.Length < 8) msjError += "La contraseña debe tener como mínimo 8 caracteres \n";
            if (ingresarPass_textBox.Text != repetirPass_textBox.Text) msjError += "Las contraseñas no coinciden\n";

            if (msjError != string.Empty)
            {
                MessageBox.Show(msjError);
                return;
            }

            App.db.cambiarPassword(id_usuario, ingresarPass_textBox.Text);
            App.db.command_update("update INNERJOIN.usuario set usuario_debe_cambiar_clave = 0, usuario_clave_expirada = 0 where usuario_id = " + id_usuario);

            MessageBox.Show("Vuelva a ingresar con su nueva contraseña.");

            this.Hide();
            App.admin.cerrar_sesion();
        }
    }
}
