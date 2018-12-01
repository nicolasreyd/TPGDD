using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Rol
{
    public partial class Modificacion_Formulario : Form
    {

        Decimal id_seleccionado;
        String nombre_modificar;
        int habilitado;
      


        Herramientas.Funcionalidades_Pantallas func;

        public Modificacion_Formulario(Decimal id)
        {
            InitializeComponent();
            id_seleccionado = id;
            func = new Herramientas.Funcionalidades_Pantallas();
        }

        private void Moficacion_Formulario_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.nombre_modificar = nombre_textbox.Text;
        }

        private void Limpiar_Button_Click(object sender, EventArgs e)
        {
            Herramientas.Funcionalidades_Pantallas.Limpiar(this);
        }

        private void Habilitado_check_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Habilitado_check.CheckState) == true)
            {
                this.habilitado = 1;
            }
            else {
                this.habilitado = 0;
            }
            

        }

        private void agregarFunc_Button_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Funcionalidad_Modif func_agregar = new Funcionalidad_Modif("Agregar", id_seleccionado);
            func_agregar.Show();
        }

        private void quitarFunc_Button_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Funcionalidad_Modif func_quitar = new Funcionalidad_Modif("Quitar", id_seleccionado);
            func_quitar.Show();
        }

        private void Guardar_Button_Click(object sender, EventArgs e)
        {
           int resultado =  App.db.modificarRol(this.nombre_modificar, this.habilitado, this.id_seleccionado);

            if(resultado < 0 ){
                MessageBox.Show("Error al modificar el Rol");
            } else {
                MessageBox.Show("Rol modificado satisfactoriamente");
            }

            this.Hide();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Modificacion_Rol modif = new Modificacion_Rol();
            modif.Show();
        }

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
