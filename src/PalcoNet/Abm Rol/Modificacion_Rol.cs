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
    public partial class Modificacion_Rol : Form
    {

        Herramientas.Funcionalidades_Pantallas func;
        String nombre_filtro;
        

        public Modificacion_Rol()
        {
            InitializeComponent();
            llenar_tabla();
            func = new Herramientas.Funcionalidades_Pantallas();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.Hide();

            Decimal id = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            using (var form2 = new Modificacion_Formulario(id))
            {
                form2.ShowDialog();
            }
        }

        private void llenar_tabla() {

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

        private void Modificacion_Rol_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar_Button_Click(object sender, EventArgs e)
        {
            func.Limpiar(this);
        }

        private void Modificacion_Rol_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            using (var abmRol = new ABMRol())
            {
                abmRol.ShowDialog();
            }

            e.Cancel = true;
        }

        private void nombre_Textbox_TextChanged(object sender, EventArgs e)
        {
            this.nombre_filtro = nombre_Textbox.Text;
        }

        private void Buscar_Button_Click(object sender, EventArgs e)
        {   
            
            
            SqlDataAdapter data;
            if (nombre_filtro == null || nombre_filtro == "")
            {
                 data = App.db.getTablaRol();
            }
            else { 
                 data = App.db.getRolByName(nombre_filtro);
            }

            DataTable tabla = new DataTable();
            data.Fill(tabla);

            this.dataGridView1.DataSource = tabla;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ABMRol rol = new ABMRol();
            rol.Show();

        }
    }
}
