using PalcoNet.Abm_Cliente;
using PalcoNet.Abm_Empresa_Espectaculo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Registro_de_Usuario
{
    public partial class Registro_Usuario : Form
    {
        public Registro_Usuario()
        {
            InitializeComponent();
        }

        private void aceptar_button_Click(object sender, EventArgs e)
        {
            string msjError = "";

            if (App.db.usernameDuplicado(username_textBox.Text)) msjError += "El nombre de usuario ya está registrado.\n";
            if (password_textBox.Text.Length < 8) msjError += "La contraseña debe tener al menos 8 caracteres.\n";
            if (password_textBox.Text != repetirPassword_textBox.Text) msjError += "Las contraseñas no coinciden.\n";
            if (!System.Text.RegularExpressions.Regex.IsMatch(username_textBox.Text, "[a-zA-Z0-9]+")) msjError += "El nombre de usuario sólo puede contener números y letras.\n";
            if (!System.Text.RegularExpressions.Regex.IsMatch(password_textBox.Text, "[a-zA-Z0-9]+")) msjError += "La contraseña sólo puede contener números y letras.\n";
            if (rol_comboBox.Text == string.Empty) msjError += "Debe elegir un rol para el usuario.\n";

            if (msjError != string.Empty)
            {
                MessageBox.Show(msjError);
                return;
            }

            switch (rol_comboBox.Text)
            {
                case "Cliente":
                    {
                        this.Hide();
                        Alta_Cliente altaCliente = new Alta_Cliente(username_textBox.Text, password_textBox.Text);
                        altaCliente.Show();
                    } break;
                case "Empresa":
                    {
                        this.Hide();
                        Alta_Empresa altaEmpresa = new Alta_Empresa(username_textBox.Text, password_textBox.Text);
                        altaEmpresa.Show();
                    } break;
            }



            
        }

        private void volver_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.Login login = new Login.Login();
            login.Show();
        }

        private void Registro_Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
