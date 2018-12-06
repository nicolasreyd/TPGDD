using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    public partial class busquedaModificacion_Empresa : Form
    {
        List<string> condiciones = new List<string>();

        public busquedaModificacion_Empresa()
        {
            InitializeComponent();

        }

        private void busquedaModificacion_Empresa_Load(object sender, EventArgs e)
        {

        }

        private void busquedaEmpresa_button_Click(object sender, EventArgs e)
        {
            SqlDataAdapter data;

            if (busquedaRazonSocial_textBox.Text != string.Empty)
            {
                condiciones.Add("empresa_razon_social like '%" + busquedaRazonSocial_textBox.Text + "%'");
            }

            if (busquedaCuit_textBox.Text != string.Empty)
            {
                condiciones.Add("empresa_cuit = '" + busquedaCuit_textBox.Text + "'");
            }

            if (busquedaEmail_textBox.Text != string.Empty)
            {
                condiciones.Add("empresa_email like '%" + busquedaEmail_textBox.Text + "%'");
            }

            data = App.db.getEmpresa(condiciones);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            this.dataGridView1.DataSource = tabla;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            condiciones.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            Modificacion_Empresa modifEmpresa = new Modificacion_Empresa(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value));
            modifEmpresa.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void limpiarPantalla_button_Click(object sender, EventArgs e)
        {

        }
    }
}
