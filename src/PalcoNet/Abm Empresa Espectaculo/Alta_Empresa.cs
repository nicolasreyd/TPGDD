using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    public partial class Alta_Empresa : Form
    {

        private string username = "";
        private string password = "";

        public Alta_Empresa(string v_username, string v_password)
        {
            InitializeComponent();
            username += v_username;
            password += v_password;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ABMEmpresa abmEmpresa = new ABMEmpresa();
            abmEmpresa.Show();
        }

        private void limpiar_button_Click(object sender, EventArgs e)
        {
            Herramientas.Funcionalidades_Pantallas.Limpiar(this);
        }

        private void altaUsuario_button_Click(object sender, EventArgs e)
        {
            string msjError = "";

            if (razonSocial_textBox.Text == string.Empty)
            {
                msjError += "El campo \"Razón social\" es obligatorio\n";
            }
            else
            {
                if (App.db.razonSocialDuplicada(razonSocial_textBox.Text)) msjError += "La razón social ya se encuentra registrada\n";
            }

            if (!Utilidades.cuitValido(cuitEmpresa_textBox.Text)) msjError += "El numero de CUIT es incorrecto\n";
            else
            {
                if (App.db.cuitRepetido(cuitEmpresa_textBox.Text)) msjError += "El CUIT ya se encuentra registrado\n";
            }

            if (domCalleEmpresa_textBox.Text == string.Empty)
            {
                msjError += "El campo \"Calle\" es obligatorio\n";
            }

            if (domNumeroEmpresa_textBox.Text == string.Empty)
            {
                msjError += "El campo \"Número\" es obligatorio\n";
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(domNumeroEmpresa_textBox.Text, "[^0-9]")) msjError += "El número de domicilio sólo puede contener numeros.\n";

            if (domPisoEmpresa_textBox.Text == string.Empty)
            {
                msjError += "El campo \"Piso\" es obligatorio\n";
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(domPisoEmpresa_textBox.Text, "[^0-9]")) msjError += "El número de piso sólo puede contener numeros.\n";


            if (domDeptoEmpresa_textBox.Text == string.Empty)
            {
                msjError += "El campo \"Departamento\" es obligatorio\n";
            }

            if (ciudadEmpresa_textBox.Text == string.Empty)
            {
                msjError += "El campo \"Ciudad\" es obligatorio\n";
            }

            if (codPostEmpresa_textBox.Text == string.Empty)
            {
                msjError += "El campo \"Código Postal\" es obligatorio\n";
            }

            if (telefonoEmpresa_textBox.Text == string.Empty)
            {
                msjError += "El campo \"Teléfono\" es obligatorio\n";
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(telefonoEmpresa_textBox.Text, "[^0-9]")) msjError += "El teléfono sólo puede contener numeros.\n";

            if (emailEmpresa_textBox.Text == string.Empty)
            {
                msjError += "El campo \"E-Mail\" es obligatorio\n";
            }

            if (msjError != string.Empty)
            {
                MessageBox.Show(msjError);
                return;
            }

            App.db.agregar_nueva_empresa(username,password,razonSocial_textBox.Text,cuitEmpresa_textBox.Text,domCalleEmpresa_textBox.Text,domNumeroEmpresa_textBox.Text,domPisoEmpresa_textBox.Text,domDeptoEmpresa_textBox.Text,ciudadEmpresa_textBox.Text,codPostEmpresa_textBox.Text,telefonoEmpresa_textBox.Text,emailEmpresa_textBox.Text);
            
            if (!string.IsNullOrEmpty(username))
            {
                this.Hide();
                Login.Login login = new Login.Login();
                login.Show();
                return;
            }

            this.Hide();
            ABMEmpresa abmEmpresa = new ABMEmpresa();
            abmEmpresa.Show();
        }

        private void cuitEmpresa_textBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void telefonoEmpresa_textBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void domPisoEmpresa_textBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void domNumeroEmpresa_textBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void Alta_Empresa_Load(object sender, EventArgs e)
        {

        }
    }
}
