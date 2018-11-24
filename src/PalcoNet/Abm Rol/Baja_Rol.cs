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

namespace PalcoNet.Abm_Rol
{
    public partial class Baja_Rol : Form
    {

        Herramientas.Funcionalidades_Pantallas func;
        public Baja_Rol()
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

            SqlDataAdapter adapter = App.db.getTablaRol();
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);

            this.dataGridView1.DataSource = tabla;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSize = true;


        }

        private void Limpiar_Button_Click(object sender, EventArgs e)
        {
            func.Limpiar(this);
        }

        private void Volver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ABMRol abm = new ABMRol();
            abm.Show();
        }
    }
}
