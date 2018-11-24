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
	public partial class Alta_Grado : Form
	{
		private String prioridad_alta;
		private Decimal comision_alta;
		public Alta_Grado()
		{
			InitializeComponent();
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			this.comision_alta = Convert.ToDecimal(comision_textBox.Text);
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			this.prioridad_alta = prioridad_textBox.Text;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void Alta_Click(object sender, EventArgs e)
		{
			int result = App.db.agregar_nuevo_rol_nuevo_grado(prioridad_alta, comision_alta);

			if (result == 1)
			{
				MessageBox.Show("Rol correctamente creado.");
			}
			else
			{
				MessageBox.Show("Error al cargar el rol, vuelva a intentar.");
			}
		}
	}
}
