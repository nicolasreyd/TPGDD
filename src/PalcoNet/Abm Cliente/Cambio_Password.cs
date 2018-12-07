using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Cliente
{
    public partial class Cambio_Password : Form
    {
        int id_usuario;
        int id_cliente;

        public Cambio_Password(int idCliente,int idUsuario)
        {
            InitializeComponent();
            id_usuario = idUsuario;
            id_cliente = idCliente;
        }

        private void Cambio_Password_Load(object sender, EventArgs e)
        {

        }

        private void cambiarPass_button_Click(object sender, EventArgs e)
        {
            string msjError = "";
            if (ingresarPass_textBox.Text.Length < 8) msjError += "La contraseña debe tener como mínimo 8 caracteres\n";
            if (ingresarPass_textBox.Text != repetirPass_textBox.Text) msjError += "Las contraseñas no coinciden\n";

            if (msjError != string.Empty)
            {
                MessageBox.Show(msjError);
                return;
            }

            App.db.cambiarPassword(id_usuario, ingresarPass_textBox.Text);
        }

        private void volver_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Modificacion_Cliente modifCliente = new Modificacion_Cliente(id_cliente);
            modifCliente.Show();
        }
    }
}
