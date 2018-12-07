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
    public partial class Alta_Cliente : Form
    {

        Herramientas.Funcionalidades_Pantallas funcionalidades;
        
        private String nombre_usuario;
        private string apellido_usuario;
        private string tipo_dni;
        private string numero_dni;
        private string cuil;
        private string fecha_nacimiento;
        private string dia_nacimiento;
        private string mes_nacimiento;
        private string anio_nacimiento;
        private string telefono;
        private string domicilio_calle;
        private string domicilio_numero;
        private string domicilio_piso;
        private string domicilio_depto;
        private string cod_post;
        private string rol;
        private string email;
        private string numero_tarjeta;
        private string vencimiento_tarjeta;
        private string mes_tarjeta;
        private string anio_tarjeta;

        public Alta_Cliente()
        {
            InitializeComponent();
        }

        private void nombreCliente_textBox_TextChanged(object sender, EventArgs e)
        {
            this.nombre_usuario = nombreCliente_textBox.Text;
        }

        private void apellidoCliente_textBox_TextChanged(object sender, EventArgs e)
        {
            this.apellido_usuario = apellidoCliente_textBox.Text;

        }

        private void tipoDNI_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tipo_dni = tipoDNI_comboBox.Text;

        }

        private void nroDNI_textBox_TextChanged(object sender, EventArgs e)
        {
            //this.numero_dni = Convert.ToInt32(nroDNI_textBox.Text);
            this.numero_dni = nroDNI_textBox.Text;
            if (System.Text.RegularExpressions.Regex.IsMatch(nroDNI_textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("El número de documento solo puede contener numeros.");
                nroDNI_textBox.Text = nroDNI_textBox.Text.Remove(nroDNI_textBox.Text.Length - 1);
            }
        }

        private void cuilCliente_textBox_TextChanged(object sender, EventArgs e)
        {
            this.cuil = cuilCliente_textBox.Text;

            if (System.Text.RegularExpressions.Regex.IsMatch(cuilCliente_textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("El número de CUIL solo puede contener numeros.");
                cuilCliente_textBox.Text = cuilCliente_textBox.Text.Remove(cuilCliente_textBox.Text.Length - 1);
            }
        }

        private void diaNac_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dia_nacimiento = diaNac_comboBox.Text;
        }

        private void mesNac_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mes_nacimiento = mesNac_comboBox.Text;
        }

        private void anioNac_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.anio_nacimiento = anioNac_comboBox.Text;
        }

        private void telefonoCliente_textBox_TextChanged(object sender, EventArgs e)
        {
            this.telefono = telefonoCliente_textBox.Text;

            if (System.Text.RegularExpressions.Regex.IsMatch(telefonoCliente_textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("El numero de telefono solo puede contener numeros.");
                telefonoCliente_textBox.Text = telefonoCliente_textBox.Text.Remove(telefonoCliente_textBox.Text.Length - 1);
            }
        }


        private void emailCliente_textBox_TextChanged(object sender, EventArgs e)
        {
            this.email = emailCliente_textBox.Text;
        }

        private void domCalleCliente_textBox_TextChanged(object sender, EventArgs e)
        {
            this.domicilio_calle = domCalleCliente_textBox.Text;
        }

        private void domNumeroCliente_textBox_TextChanged(object sender, EventArgs e)
        {
           // this.domicilio_numero = Convert.ToInt32(domNumeroCliente_textBox.Text);
            this.domicilio_numero = domNumeroCliente_textBox.Text;
        }

        private void domPisoCliente_textBox_TextChanged(object sender, EventArgs e)
        {
           // this.domicilio_piso = Convert.ToInt32(domPisoCliente_textBox.Text);
            this.domicilio_piso = domPisoCliente_textBox.Text;
        }

        private void domDeptoCliente_textBox_TextChanged(object sender, EventArgs e)
        {
            this.domicilio_depto = domDeptoCliente_textBox.Text;
        }

        private void codPostCliente_textBox_TextChanged(object sender, EventArgs e)
        {
            this.cod_post = codPostCliente_textBox.Text;
        }
        /*
        private void rolCliente_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rol = rolCliente_comboBox.Text;
        }*/

        private void numeroTarjeta_textBox_TextChanged(object sender, EventArgs e)
        {
            this.numero_tarjeta = numeroTarjeta_textBox.Text;

            if (System.Text.RegularExpressions.Regex.IsMatch(numeroTarjeta_textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("El numero de tarjeta solo puede contener numeros.");
                numeroTarjeta_textBox.Text = numeroTarjeta_textBox.Text.Remove(numeroTarjeta_textBox.Text.Length - 1);
            }
        }
        /*
        private void vencimientoTarjeta_textBox_TextChanged(object sender, EventArgs e)
        {
            this.vencimiento_tarjeta = "01/"+vencimientoTarjeta_textBox.Text;
        }*/

        private void mesTarjeta_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mes_tarjeta = mesTarjeta_comboBox.Text;
        }

        private void anioTarjeta_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.anio_tarjeta = anioTarjeta_comboBox.Text;
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
            /*
            if (tipoDNI_comboBox.Text == string.Empty)
            {
                msjError += "El tipo de documento no puede ser vacio\n";
            }

            if (nroDNI_textBox.Text == string.Empty)
            {
                msjError += "El DNI no puede ser vacio\n";
            }*/

            if ((tipoDNI_comboBox.Text == string.Empty) || (nroDNI_textBox.Text == string.Empty))
                msjError += "El tipo/numero de documento no puede ser vacio\n";
            else
                {
                    if (App.db.documentoRepetido(tipoDNI_comboBox.Text,nroDNI_textBox.Text))
                        msjError += "La combinacion tipo/numero de documento ya se encuentra registrada\n";
                }

            //if (cuilCliente_textBox.Text.Length != 11)
            //{
            //    msjError += "El numero de CUIL debe tener 11 caracteres\n";
            //} // Se puede mejorar para que sea exhaustivo
            //else
                if (!Utilidades.cuilValido(cuilCliente_textBox.Text)) msjError += "El numero de CUIL es incorrecto\n";

            if ((diaNac_comboBox.Text == string.Empty) ||
                (mesNac_comboBox.Text == string.Empty) ||
                (anioNac_comboBox.Text == string.Empty))
            {
                msjError += "La fecha de nacimiento esta incompleta\n";
            } else
            {
                switch ( mesNac_comboBox.Text)
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
                            } else
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


            if (numeroTarjeta_textBox.Text.Length != 16)
            {
                msjError += "El numero de tarjeta es incorrecto";
            }

            if (msjError != string.Empty)
            {
                MessageBox.Show(msjError);
                return;
            }

            this.fecha_nacimiento=this.dia_nacimiento+"/"+this.mes_nacimiento+"/"+this.anio_nacimiento;
            this.vencimiento_tarjeta = "01/"+this.mes_tarjeta+"/"+this.anio_tarjeta;
            
            /*
            string errores;

            errores = App.db.validar_datos_cliente(nombre_usuario, apellido_usuario, tipo_dni, numero_dni, cuil, fecha_nacimiento, telefono, email, domicilio_calle, domicilio_numero, domicilio_piso, domicilio_depto, cod_post, numero_tarjeta, vencimiento_tarjeta);

            if (errores != string.Empty)
            {
                MessageBox.Show(errores);
                return;
            }
             * */
            
            App.db.agregar_nuevo_cliente(nombre_usuario, apellido_usuario, tipo_dni, numero_dni, cuil, fecha_nacimiento, telefono, email, domicilio_calle, domicilio_numero, domicilio_piso, domicilio_depto, cod_post, numero_tarjeta, vencimiento_tarjeta);//,rol);
            this.Hide();
            ABMCliente abmCliente = new ABMCliente();
            abmCliente.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void limpiar_button_Click(object sender, EventArgs e)
        {
            Herramientas.Funcionalidades_Pantallas.Limpiar(this);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ABMCliente abmCliente = new ABMCliente();
            abmCliente.Show();
        }


    }
}
