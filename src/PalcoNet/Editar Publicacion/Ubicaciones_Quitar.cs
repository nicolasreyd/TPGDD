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

namespace PalcoNet.Editar_Publicacion
{
    public partial class Ubicaciones_Quitar : Form
    {
        public Decimal id_publicacion;

        public Ubicaciones_Quitar(Decimal id)
        {
            id_publicacion = id;
            InitializeComponent();
            llenar_tabla();
        }

        private void llenar_tabla()
        {
            SqlDataAdapter adapter = App.db.getUbicacionByPublicacionID(id_publicacion);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);

            this.dataGridView.DataSource = tabla;
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.MultiSelect = false;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSize = true;
        }


      
        private void Ubicaciones_Quitar_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            App.db.eliminar_ubicacion(Convert.ToDecimal(dataGridView.Rows[e.RowIndex].Cells[1].Value));
        }
    }
}
