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

namespace PalcoNet.Abm_Cliente
{
    public partial class busquedaModificacion_Cliente : Form
    {
        List<string> condiciones = new List<string>();
        private string nombre_busqueda = "";
        private string apellido_busqueda = "";
        private string dni_busqueda = "";
        private string email_busqueda = "";
        string id;
        
        
        public busquedaModificacion_Cliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            Abm_Cliente.Modificacion_Cliente modifCliente = new Abm_Cliente.Modificacion_Cliente(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value));
            modifCliente.Show();
        }

        private void busquedaNombre_textBox_TextChanged(object sender, EventArgs e)
        {
            this.nombre_busqueda = busquedaNombre_textBox.Text;
        }

        private void busquedaApellido_textBox_TextChanged(object sender, EventArgs e)
        {
            this.apellido_busqueda = busquedaApellido_textBox.Text;
        }

        private void busquedaDNI_textBox_TextChanged(object sender, EventArgs e)
        {
            this.dni_busqueda = busquedaDNI_textBox.Text;
        }

        private void busquedaEmail_textBox_TextChanged(object sender, EventArgs e)
        {
            this.email_busqueda = busquedaEmail_textBox.Text;
        }

        private void busquedaCliente_button_Click(object sender, EventArgs e)
        {
            SqlDataAdapter data;

            if (this.nombre_busqueda != string.Empty)
            {
                condiciones.Add("cliente_nombre like \'%" + this.nombre_busqueda + "%\'");
            }

            if (this.apellido_busqueda != string.Empty)
            {
                condiciones.Add("cliente_apellido like \'%" + this.apellido_busqueda + "%\'");
            }

            if (this.dni_busqueda != string.Empty)
            {
                condiciones.Add("cliente_numero_dni = " + this.dni_busqueda + "");
            }

            if (this.email_busqueda != string.Empty)
            {
                condiciones.Add("cliente_email like \'%" + this.email_busqueda + "%\'");
            }

            data = App.db.getCliente(condiciones);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            this.dataGridView1.DataSource = tabla;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            condiciones.Clear();
        }

        private void limpiarPantalla_button_Click(object sender, EventArgs e)
        {
            Herramientas.Funcionalidades_Pantallas.Limpiar(this);
        }
    }
}
