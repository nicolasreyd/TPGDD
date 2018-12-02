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
	public partial class Modificacion_Grado : Form
	{
		private String prioridad;
		Herramientas.Funcionalidades_Pantallas func;
		public Modificacion_Grado()
		{
			InitializeComponent();
			llenar_tabla();
			func = new Herramientas.Funcionalidades_Pantallas();
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

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			this.Hide();

			Decimal id = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

			using (var form2 = new Modificacion_Formulario(id))
			{
				form2.ShowDialog();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
            Herramientas.Funcionalidades_Pantallas.Limpiar(this);
		}

		private void Modificacion_Grado_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlDataAdapter data;
			if (prioridad == null || prioridad == "")
			{
				data = App.db.getTablaGrado();
			}
			else
			{
				data = App.db.getGradoByName(prioridad);
			}

			DataTable tabla = new DataTable();
			data.Fill(tabla);

			this.dataGridView1.DataSource = tabla;
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			this.prioridad = prioridad_textBox.Text;
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			ABMGrado vw = new ABMGrado();
			vw.Show();
		}
	}
}
