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
    public partial class Editar_grilla : Form
    {
        public Editar_grilla()
        {
            InitializeComponent();
            llenar_tabla();
            cargar_estados();
        }

        private void cargar_estados()
        {
            Estado_comboBox.Items.Add("Borrador");
            Estado_comboBox.Items.Add("Publicada");
            Estado_comboBox.Items.Add("Finalizada");
        }

        private void llenar_tabla()
        {

            SqlDataAdapter adapter = App.db.getTablaPublicaciones();
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);

            this.dataGridView.DataSource = tabla;
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.MultiSelect = false;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSize = true;


        }

        private void Editar_grilla_Load(object sender, EventArgs e)
        {

        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {

            string query = armar_query();

            SqlDataAdapter adapter = App.db.getTablaPublicacionesFiltros(query);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);

            this.dataGridView.DataSource = tabla;
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.MultiSelect = false;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSize = true;

        }

        private string armar_query()
        {
            string query = "select publicacion_id,id_espectaculo,rubro_descripcion,grado_nombre,usuario_username, publicacion_estado,publicacion_fecha_publicacion,publicacion_fecha_evento,publicacion_descripcion, publicacion_direccion from INNERJOIN.publicacion left outer join INNERJOIN.usuario on id_responsable = usuario_id left outer join INNERJOIN.rubro on id_rubro = rubro_id left outer join INNERJOIN.grado on id_grado = grado_id where ";
            string query_descripcion;
            string query_id;
            string query_estado;
            string query_direccion;
            int count = 0;

            if (!String.IsNullOrEmpty(Descripcion_textBox.Text))
            {
                query_descripcion = " publicacion_descripcion LIKE '" + Descripcion_textBox.Text + "'";
                query = query + query_descripcion;
                count++;
            }

            if (!String.IsNullOrEmpty(EspecID_textBox.Text))
            {
                if (count > 0)
                {
                    query_id = " id_espectaculo = " + Convert.ToDecimal(EspecID_textBox.Text);
                    query = query + " and " + query_id;
                    count++;
                }
                else {
                    query_id = " id_espectaculo = " + Convert.ToDecimal(EspecID_textBox.Text);
                    query = query + query_id;
                    count++;
                }
            }

            if (!String.IsNullOrEmpty(Convert.ToString(Estado_comboBox.SelectedItem)))
            {
                if (count > 0)
                {
                    query_estado = " publicacion_estado LIKE '" + Convert.ToString(Estado_comboBox.SelectedItem) + "'";
                    query = query + " and " + query_estado;
                    count++;
                }
                else {
                    query_estado = " publicacion_estado LIKE '" + Convert.ToString(Estado_comboBox.SelectedItem) + "'";
                    query = query + query_estado;
                    count++;
                }
            }

            if (!String.IsNullOrEmpty(Direccion_textBox.Text))
            {
                if (count > 0)
                {
                    query_direccion = " publicacion_direccion LIKE '" + Direccion_textBox.Text + "'";
                    query = query + " and " + query_direccion;
                    count++;
                }
                else {
                    query_direccion = " publicacion_direccion LIKE '" + Direccion_textBox.Text + "'";
                    query = query + query_direccion;
                    count++;
                }
            }

            
            if(count == 0){
                query = "select publicacion_id,id_espectaculo,rubro_descripcion,grado_nombre,usuario_username, publicacion_estado,publicacion_fecha_publicacion,publicacion_fecha_evento,publicacion_descripcion, publicacion_direccion from INNERJOIN.publicacion left outer join INNERJOIN.usuario on id_responsable = usuario_id left outer join INNERJOIN.rubro on id_rubro = rubro_id left outer join INNERJOIN.grado on id_grado = grado_id";
            }

            return query;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login.MenuPrincipal menu = new Login.MenuPrincipal();
            menu.Show();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[6].Value) == "Borrador")
            {

                Datos.Publicacion publicacion = armar_publicacion(e);
                Decimal id = Convert.ToDecimal(dataGridView.Rows[e.RowIndex].Cells[1].Value);

                Editar_formulario form = new Editar_formulario(publicacion);
                form.Show();
      
            }
            else {
                MessageBox.Show("Solo se pueden modificar publicaciones en estado BORRADOR!");
            }
        }

        private Datos.Publicacion armar_publicacion(DataGridViewCellEventArgs e)
        {
            Datos.Publicacion publicacion = new Datos.Publicacion();

            publicacion.id = Convert.ToDecimal(dataGridView.Rows[e.RowIndex].Cells[1].Value);
            publicacion.rubro = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[3].Value);
            publicacion.grado = App.db.getGrado(Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[4].Value));
            publicacion.id_responsable = 1;
            publicacion.estado = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[6].Value);
            publicacion.fecha_espectaculo = Convert.ToDateTime(dataGridView.Rows[e.RowIndex].Cells[7].Value);
            publicacion.fecha_publicacion = Convert.ToDateTime(dataGridView.Rows[e.RowIndex].Cells[8].Value);
            publicacion.descripcion = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[9].Value);
            publicacion.direccion = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells[10].Value);

            return publicacion;
        }

        private void Limpiar_button_Click(object sender, EventArgs e)
        {
            Herramientas.Funcionalidades_Pantallas.Limpiar(this);
        }

       
    }
}
