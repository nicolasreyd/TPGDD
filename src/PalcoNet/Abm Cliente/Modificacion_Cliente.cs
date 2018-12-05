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
        private string apellido_busqueda = "No se cambio";

        public Modificacion_Cliente(int valor)
        {
            InitializeComponent();
            idCliente = valor;

            SqlDataReader resultado = App.db.getDatosCliente(idCliente);

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
            this.apellido_busqueda = apellidoCliente_textBox.Text;
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
            //MessageBox.Show(this.apellido_busqueda);

            string msjError = "";

            if (nombreCliente_textBox.Text == string.Empty)
            {
                msjError += "El nombre es obligatorio\n";
            }

            if (apellidoCliente_textBox.Text == string.Empty)
            {
                msjError += "El apellido es obligatorio\n";
            }

            if (tipoDNI_comboBox.Text == string.Empty)
            {
                msjError += "El tipo de documento no puede ser vacio\n";
            }

            if (nroDNI_textBox.Text == string.Empty)
            {
                msjError += "El DNI no puede ser vacio\n";
            }

            if (cuilCliente_textBox.Text.Length != 11)
            {
                msjError += "El numero de CUIL es incorrecto\n";
            }

            if ((diaNac_comboBox.Text == string.Empty) ||
                (mesNac_comboBox.Text == string.Empty) ||
                (anioNac_comboBox.Text == string.Empty))
            {
                msjError += "La fecha de nacimiento esta incompleta\n";
            }
            else
            {
                switch (mesNac_comboBox.Text)
                {
                    case "04":
                    case "06":
                    case "09":
                    case "11":
                        {
                            if (diaNac_comboBox.Text == "31")
                            {
                                msjError += "La fecha de nacimiento es incorrecta\n";
                            }
                        }
                        break;
                    case "02":
                        {
                            if ((diaNac_comboBox.Text == "30") || (diaNac_comboBox.Text == "31"))
                            {
                                msjError += "La fecha de nacimiento es incorrecta\n";
                            }
                            else
                            {
                                if ((diaNac_comboBox.Text == "29") && (Convert.ToInt32(anioNac_comboBox.Text) % 4 != 0))
                                {
                                    msjError += "La fecha de nacimiento es incorrecta\n";
                                }
                            }
                        }
                        break;
                }

            }

            if (App.db.documentoRepetido(idCliente,this.tipoDNI_comboBox.Text,this.nroDNI_textBox.Text))
            {
                msjError += "La combinacion tipo/numero de documento ya se encuentra registrada\n";
            }

            if (App.db.cuilRepetido(idCliente,this.cuilCliente_textBox.Text))
            {
                msjError += "El numero de CUIL ya se encuentra registrado\n";
            }

            if (msjError != string.Empty)
            {
                MessageBox.Show(msjError);
                return;
            }
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

        private void volver_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abm_Cliente.busquedaModificacion_Cliente bModifCliente = new Abm_Cliente.busquedaModificacion_Cliente();
            bModifCliente.Show();
        }
    }
}
