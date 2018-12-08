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
        string apellido;
        string nombre;
        string tipoDni;
        string nroDni;
        string cuil;
        string diaNac;
        string mesNac;
        string anioNac;
        string domCalle;
        string domNro;
        string domPiso;
        string domDepto;
        string codPost;
        string telefono;
        string email;
        bool habilitado;
        private string fecha_nacimiento;

        public Modificacion_Cliente(int valor)
        {
            InitializeComponent();
            idCliente = valor;

            SqlDataReader resultado = App.db.getDatosCliente(idCliente);

            if (resultado.Read())
            {
                /*
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
                */

                apellidoCliente_textBox.Text = resultado.GetString(0);
                this.apellido = apellidoCliente_textBox.Text;
                nombreCliente_textBox.Text = resultado.GetString(1);
                this.nombre = nombreCliente_textBox.Text;
                tipoDNI_comboBox.Text = resultado.GetString(2);
                this.tipoDni = tipoDNI_comboBox.Text;
                nroDNI_textBox.Text = resultado.GetDecimal(3).ToString();
                this.nroDni = nroDNI_textBox.Text;
                cuilCliente_textBox.Text = resultado.GetString(4);
                this.cuil = cuilCliente_textBox.Text;
                diaNac_comboBox.Text = resultado.GetString(5).Substring(6, 2);
                this.diaNac = diaNac_comboBox.Text;
                mesNac_comboBox.Text = resultado.GetString(5).Substring(4, 2);
                this.mesNac = mesNac_comboBox.Text;
                anioNac_comboBox.Text = resultado.GetString(5).Substring(0, 4);
                this.anioNac = anioNac_comboBox.Text;
                domCalleCliente_textBox.Text = resultado.GetString(6);
                this.domCalle = domCalleCliente_textBox.Text;
                domNumeroCliente_textBox.Text = resultado.GetDecimal(7).ToString();
                this.domNro = domNumeroCliente_textBox.Text;
                domPisoCliente_textBox.Text = resultado.GetDecimal(8).ToString();
                this.domPiso = domPisoCliente_textBox.Text;
                domDeptoCliente_textBox.Text = resultado.GetString(9);
                this.domDepto = domDeptoCliente_textBox.Text;
                codPostCliente_textBox.Text = resultado.GetString(10);
                this.codPost = codPostCliente_textBox.Text;
                telefonoCliente_textBox.Text = resultado.GetString(11);
                this.telefono = telefonoCliente_textBox.Text;
                emailCliente_textBox.Text = resultado.GetString(12);
                this.email = emailCliente_textBox.Text;
                habilitado_checkBox.Checked = (bool)!resultado.GetSqlBoolean(13);

                this.fecha_nacimiento = diaNac_comboBox.Text + "/" + mesNac_comboBox.Text + "/" + anioNac_comboBox.Text;

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

            List<string> camposAModificar = new List<string>();

            if (apellidoCliente_textBox.Text != this.apellido) camposAModificar.Add("cliente_apellido = '" + apellidoCliente_textBox.Text + "'");
            if (nombreCliente_textBox.Text != this.nombre) camposAModificar.Add("cliente_nombre = '" + nombreCliente_textBox.Text + "'");
            if (tipoDNI_comboBox.Text != this.tipoDni) camposAModificar.Add("cliente_tipo_dni = '" + tipoDNI_comboBox.Text + "'");
            if (nroDNI_textBox.Text != this.nroDni) camposAModificar.Add("cliente_numero_dni = " + nroDNI_textBox.Text); //REVISAR TIPO DE DATOS EN LA TABLA
            if (cuilCliente_textBox.Text != this.cuil) camposAModificar.Add("cliente_cuil = '" + cuilCliente_textBox.Text + "'");
            if (diaNac_comboBox.Text + "/" + mesNac_comboBox.Text + "/" + anioNac_comboBox.Text != this.fecha_nacimiento)
            {
                this.fecha_nacimiento = diaNac_comboBox.Text + "/" + mesNac_comboBox.Text + "/" + anioNac_comboBox.Text;
                camposAModificar.Add("cliente_fecha_nacimiento = '" + this.fecha_nacimiento + "'"); //REVISAR EL TEMA DEL CONVERT
            }
            if (domCalleCliente_textBox.Text != this.domCalle) camposAModificar.Add("cliente_domicilio_calle = '" + domCalleCliente_textBox.Text + "'");
            if (domNumeroCliente_textBox.Text != this.domNro) camposAModificar.Add("cliente_domicilio_numero = " + domNumeroCliente_textBox.Text);
            if (domPisoCliente_textBox.Text != this.domPiso) camposAModificar.Add("cliente_domicilio_piso = " + domPisoCliente_textBox.Text);
            if (domDeptoCliente_textBox.Text != this.domDepto) camposAModificar.Add("cliente_domicilio_departamento = '" + domDeptoCliente_textBox.Text + "'");
            if (codPostCliente_textBox.Text != this.codPost) camposAModificar.Add("cliente_codigo_postal = '" + codPostCliente_textBox.Text + "'");
            if (telefonoCliente_textBox.Text != this.telefono) camposAModificar.Add("cliente_telefono = '" + telefonoCliente_textBox.Text + "'");
            if (emailCliente_textBox.Text != this.email) camposAModificar.Add("cliente_email = '" + emailCliente_textBox.Text + "'");

            //this.fecha_nacimiento = diaNac_comboBox.Text+"/"+mesNac_comboBox.Text+"/"+anioNac_comboBox.Text;

            //int resultado = App.db.updateCliente(idCliente, apellidoCliente_textBox.Text, nombreCliente_textBox.Text, tipoDNI_comboBox.Text, nroDNI_textBox.Text, cuilCliente_textBox.Text, this.fecha_nacimiento, domCalleCliente_textBox.Text, domNumeroCliente_textBox.Text, domPisoCliente_textBox.Text, domDeptoCliente_textBox.Text, codPostCliente_textBox.Text, telefonoCliente_textBox.Text, emailCliente_textBox.Text);

            if (!camposAModificar.Any())
            {
                MessageBox.Show("No se modifico ningún campo");
            }
            else
            {
                int resultado = App.db.updateCliente(idCliente, camposAModificar);

                if (resultado == 1) MessageBox.Show("Cliente actualizado correctamente. ");

                this.Hide();
                Abm_Cliente.busquedaModificacion_Cliente bmodifCliente = new Abm_Cliente.busquedaModificacion_Cliente();
                bmodifCliente.Show();
            }
            
        }

        private void limpiar_button_Click(object sender, EventArgs e)
        {

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

        private void Modificacion_Cliente_Load(object sender, EventArgs e)
        {
            this.habilitarCliente_button.Enabled = !this.habilitado_checkBox.Checked;
            habilitado_checkBox.AutoCheck = false;
        }

        private void habilitarCliente_button_Click(object sender, EventArgs e)
        {
            App.db.rehabilitarUsuario("cliente", idCliente);
        }

        private void cambiarPass_button_Click(object sender, EventArgs e)
        {
            SqlDataReader data = App.db.command_reader("select usuario_id from INNERJOIN.cliente where cliente_id=" + idCliente);

            if (data.HasRows)
            {
                data.Read();
                this.Hide();
                Cambio_Password cambioPass = new Cambio_Password(idCliente,Convert.ToInt32(data.GetDecimal(0)));
                cambioPass.Show();
            }
        }
    }
}
