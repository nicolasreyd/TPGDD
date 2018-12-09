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

namespace PalcoNet.Generar_Rendicion_Comisiones
{
    public partial class Facturas : Form
    {
        decimal id_empresa;

        public Facturas(decimal empresa_id)
        {
            InitializeComponent();
            id_empresa = empresa_id;
            llenar_tabla();
        }

        private void llenar_tabla()
        {
            SqlDataAdapter adapter = App.db.getFacturasDelDia(id_empresa);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);

            this.dataGridView1.DataSource = tabla;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSize = true;
        }

        private void Facturas_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
