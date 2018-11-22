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

        public Modificacion_Rol()
        {
            InitializeComponent();
            llenar_tabla();
            func = new Herramientas.Funcionalidades_Pantallas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

           //Oculto la columna de pk y baja logica
           this.dataGridView1.Columns[0].Visible = false;
           this.dataGridView1.Columns[2].Visible = false;


        }

        private void Modificacion_Rol_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar_Button_Click(object sender, EventArgs e)
        {
            func.Limpiar(this);
        }
    }
}
