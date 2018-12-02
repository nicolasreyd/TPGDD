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

namespace PalcoNet.Abm_Grado
{
	public partial class Baja_Grado : Form
	{
		private String prioridad_filtro;
		Herramientas.Funcionalidades_Pantallas func;
		public Baja_Grado()
		{
			InitializeComponent();
			func = new Herramientas.Funcionalidades_Pantallas();
			llenar_tabla();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			App.db.eliminar_rol(Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[1].Value));
		}

		private void llenar_tabla()
		{

			SqlDataAdapter adapter = App.db.getTablaGrado();
			DataTable tabla = new DataTable();
			adapter.Fill(tabla);

			this.dataGridView1.DataSource = tabla;
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AutoSize = true;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			this.prioridad_filtro = prioridad_textBox.Text;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SqlDataAdapter data;
			if (prioridad_filtro == null || prioridad_filtro == "")
			{
				data = App.db.getTablaGrado();
			}
			else
			{
				data = App.db.getGradoByName(prioridad_filtro);
			}

			DataTable tabla = new DataTable();
			data.Fill(tabla);

			this.dataGridView1.DataSource = tabla;
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		private void limpiar_button_Click(object sender, EventArgs e)
		{
            Herramientas.Funcionalidades_Pantallas.Limpiar(this);
		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			App.db.eliminar_grado(Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[1].Value));
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			ABMGrado vw = new ABMGrado();
			vw.Show();
		}
	}
}
