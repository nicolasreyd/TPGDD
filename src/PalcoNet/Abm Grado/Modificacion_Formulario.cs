using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Grado
{
	public partial class Modificacion_Formulario : Form
	{
		Decimal id_seleccionado;
		private String prioridad;
		private Decimal comision;
		private decimal id;
		Herramientas.Funcionalidades_Pantallas func;

		public Modificacion_Formulario()
		{
			InitializeComponent();
		}

		public Modificacion_Formulario(decimal id)
		{
			InitializeComponent();
			id_seleccionado = id;
			func = new Herramientas.Funcionalidades_Pantallas();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			int resultado = App.db.modificarGrado(this.prioridad, this.comision, this.id_seleccionado);

			if (resultado < 0)
			{
				MessageBox.Show("Error al modificar el Grado");
			}
			else
			{
				MessageBox.Show("Grado modificado satisfactoriamente");
			}

			this.Hide();
      		}

		private void prioridad_textBox_TextChanged(object sender, EventArgs e)
		{
			this.prioridad = prioridad_textBox.Text;
		}

		private void comision_textBox_TextChanged(object sender, EventArgs e)
		{
			this.comision = Convert.ToDecimal(comision_textBox.Text);
		}

		private void Modificacion_Formulario_Load(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			Modificacion_Grado vw = new Modificacion_Grado();
			vw.Show();
		}
	}
}
