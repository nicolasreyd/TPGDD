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
    public partial class ComprarUbicacionSinTarjeta : Form
    {
        List<Decimal> ubicacionesAcomprar = new List<Decimal>();
        Decimal idPublicacion;
        public ComprarUbicacionSinTarjeta()
        {
            InitializeComponent();
        }

        public ComprarUbicacionSinTarjeta(Decimal idPublicacion)
        {
            this.idPublicacion = idPublicacion;
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonCell cell = dataGridView1.Rows[e.RowIndex].Cells[0] as DataGridViewButtonCell;
            cell.ReadOnly = true;
            Decimal nuevoId = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            ubicacionesAcomprar.Add(nuevoId);
        }

        private void ComprarUbicacionSinTarjeta_Load(object sender, EventArgs e)
        {

        }

        private void Comprar_Click(object sender, EventArgs e)
        {
            if (numerotarjeta_textBox.Text==null || numerotarjeta_textBox.Text=="") {
                MessageBox.Show("Completar numero de tarjeta");
            }
            App.db.crearTarjeta(Convert.ToDecimal(numerotarjeta_textBox), vencimiento_dateTimePicker.Value);
            
        }
    }
}
