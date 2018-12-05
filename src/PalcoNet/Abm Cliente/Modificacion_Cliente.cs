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

namespace PalcoNet.Abm_Cliente
{
    public partial class Modificacion_Cliente : Form
    {
        int idCliente;

        public Modificacion_Cliente(int valor)
        {
            InitializeComponent();
            idCliente = valor;

            SqlDataReader resultado = App.db.getDatosCliente(valor);

            if (resultado.Read())
            {
                apellidoCliente_textBox.Text = resultado.GetString(0);
                nombreCliente_textBox.Text = resultado.GetString(1);
                tipoDNI_comboBox.Text = resultado.GetString(2);
                nroDNI_textBox.Text = resultado.GetDecimal(3).ToString();
                cuilCliente_textBox.Text = resultado.GetString(4);
                diaNac_comboBox.Text = resultado.GetString(5).Substring(6,2);
                mesNac_comboBox.Text = resultado.GetString(5).Substring(4, 2);
                anioNac_comboBox.Text = resultado.GetString(5).Substring(0, 4);
                domCalleCliente_textBox.Text = resultado.GetString(6);
                domNumeroCliente_textBox.Text = resultado.GetDecimal(7).ToString();
                domPisoCliente_textBox.Text = resultado.GetDecimal(8).ToString();
                domDeptoCliente_textBox.Text = resultado.GetString(9);
                codPostCliente_textBox.Text = resultado.GetString(10);
                telefonoCliente_textBox.Text = resultado.GetString(11);
                emailCliente_textBox.Text = resultado.GetString(12);

            }

        }

        private void apellidoCliente_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreCliente_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tipoDNI_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nroDNI_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cuilCliente_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void diaNac_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mesNac_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void anioNac_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domCalleCliente_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void domNumeroCliente_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void domPisoCliente_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void domDeptoCliente_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void codPostCliente_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefonoCliente_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailCliente_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void altaUsuario_button_Click(object sender, EventArgs e)
        {

        }

        private void limpiar_button_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El id de cliente ingresado es : "+idCliente);
        }

        private void popular_formularios(int altoValor)
        {
            SqlDataReader resultado = App.db.getDatosCliente(idCliente);

            if (resultado.Read())
            {
                apellidoCliente_textBox.Text = resultado.GetString(0);
            }
        }
    }
}
