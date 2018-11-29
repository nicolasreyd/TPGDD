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
        private string domicilio_numero;
        private string domicilio_piso;
        private string domicilio_depto;
        private string cod_post;
        private string rol;
        private string email;

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
            this.domicilio_numero = domNumeroCliente_textBox.Text;
        }

        private void domPisoCliente_textBox_TextChanged(object sender, EventArgs e)
        {
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

        private void rolCliente_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rol = rolCliente_comboBox.Text;
        }

        private void altaUsuario_button_Click(object sender, EventArgs e)
        {
            App.db.agregar_nuevo_cliente(nombre_usuario, apellido_usuario, tipo_dni, numero_dni, cuil, email, fecha_nacimiento, telefono, domicilio_calle, domicilio_numero, domicilio_piso, domicilio_depto, cod_post);//,rol);
        }

       // object resultado = DBOperations.Execute_SP("INNERJOIN.sp_alta_cliente", new { codpost = this.cod_post });
    }
}
