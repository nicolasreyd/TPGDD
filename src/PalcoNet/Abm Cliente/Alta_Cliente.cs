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
        private string telefono;
        private string domicilio_calle;
        private int domicilio_numero;
        private int domicilio_piso;
        private string domicilio_depto;
        private string cod_post;
        private string rol;
        private string email;
        private string numero_tarjeta;
        private string vencimiento_tarjeta;

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
        }

        private void cuilCliente_textBox_TextChanged(object sender, EventArgs e)
        {
            this.cuil = cuilCliente_textBox.Text;
        }

        private void fechaNacCliente_textBox_TextChanged(object sender, EventArgs e)
        {
            this.fecha_nacimiento = fechaNacCliente_textBox.Text;
        }

        private void telefonoCliente_textBox_TextChanged(object sender, EventArgs e)
        {
            this.telefono = telefonoCliente_textBox.Text;
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
            this.domicilio_numero = Convert.ToInt32(domNumeroCliente_textBox.Text);
        }

        private void domPisoCliente_textBox_TextChanged(object sender, EventArgs e)
        {
            this.domicilio_piso = Convert.ToInt32(domPisoCliente_textBox.Text);
        }

        private void domDeptoCliente_textBox_TextChanged(object sender, EventArgs e)
        {
            this.domicilio_depto = domDeptoCliente_textBox.Text;
        }

        private void codPostCliente_textBox_TextChanged(object sender, EventArgs e)
        {
            this.cod_post = codPostCliente_textBox.Text;
        }

        private void rolCliente_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rol = rolCliente_comboBox.Text;
        }

        private void numeroTarjeta_textBox_TextChanged(object sender, EventArgs e)
        {
            this.numero_tarjeta = numeroTarjeta_textBox.Text;
        }

        private void vencimientoTarjeta_textBox_TextChanged(object sender, EventArgs e)
        {
            this.vencimiento_tarjeta = "01/"+vencimientoTarjeta_textBox.Text;
        }

        private void altaUsuario_button_Click(object sender, EventArgs e)
        {
            /*
            string msjError = "";

            if (nroDNI_textBox.Text == string.Empty)
            {
               // MessageBox.Show("El DNI no puede ser vacio");
               // return;
                msjError += "El DNI no puede ser vacio\n";
            }

            if (numeroTarjeta_textBox.Text == string.Empty)
            {
               // MessageBox.Show("La tarjeta no puede ser vacia");
               // return;
                msjError += "La tarjeta no puede ser vacia";
            }

            MessageBox.Show(msjError);
            return;
             */

            App.db.agregar_nuevo_cliente(nombre_usuario, apellido_usuario, tipo_dni, numero_dni, cuil, fecha_nacimiento, telefono, email, domicilio_calle, domicilio_numero, domicilio_piso, domicilio_depto, cod_post, numero_tarjeta, vencimiento_tarjeta);//,rol);
            this.Hide();
            Login.Login login = new Login.Login();
            login.Show();
        }



       // object resultado = DBOperations.Execute_SP("INNERJOIN.sp_alta_cliente", new { codpost = this.cod_post });
    }
}
