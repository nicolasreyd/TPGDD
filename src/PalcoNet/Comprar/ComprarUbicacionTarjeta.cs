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

namespace PalcoNet.Comprar
{
    public partial class ComprarUbicacionTarjeta : Form
    {
        List<Decimal> ubicacionesAcomprar = new List<Decimal>();
        Decimal idPublicacion;
        public ComprarUbicacionTarjeta(Decimal idPublicacion)
        {
            this.idPublicacion = idPublicacion;
            InitializeComponent();
            llenar_tabla(idPublicacion);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comprar_Click(object sender, EventArgs e)
        {
            if (tarjetas_checkedListBox.SelectedItem == null)
            {
                MessageBox.Show("Seleccionar tarjeta");
                return;
            }
            if (ubicacionesAcomprar.Count()<1)
            {
                MessageBox.Show("Seleccione ubicaciones a comprar");
                return;
            }
            App.db.comprar(ubicacionesAcomprar, idPublicacion);
            llenar_tabla(idPublicacion);
        }

        private void llenar_tabla(Decimal idPublicacion)
        {

            SqlDataAdapter adapter = App.db.getTablaUbicaciones(idPublicacion);
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
            DataGridViewCheckBoxCell cell = dataGridView1.Rows[e.RowIndex].Cells[0] as DataGridViewCheckBoxCell;
            Decimal nuevoId = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            if (cell.Value != null && cell.Value.Equals(1))
            {
                ubicacionesAcomprar.Remove(nuevoId);
                cell.Value = 0;
            }
            else
            {
                ubicacionesAcomprar.Add(nuevoId);
                cell.Value = 1;
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < tarjetas_checkedListBox.Items.Count; ++ix)
                    if (e.Index != ix) tarjetas_checkedListBox.SetItemChecked(ix, false);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ComprarUbicacionTarjeta_Load(object sender, EventArgs e)
        {
            List<Datos.Tarjeta> tarjetas = new List<Datos.Tarjeta>();
            tarjetas = App.db.getTarjetas();
            completar_listbox(tarjetas);
        }
        private void completar_listbox(List<Datos.Tarjeta> tarjetas)
        {
            foreach (Datos.Tarjeta tarjeta in tarjetas)
            {
                tarjetas_checkedListBox.Items.Add(tarjeta);
                tarjetas_checkedListBox.DisplayMember = "numero";
                tarjetas_checkedListBox.ValueMember = "id";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
