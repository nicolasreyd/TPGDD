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
        private DataTable todos_los_datos;
        private decimal total = 0;
        private decimal pagina = 0;
        private decimal maximo_paginas = 0;
        private int items_por_pagina = 10;

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


            this.todos_los_datos = tabla;
            this.total = this.todos_los_datos.Rows.Count;
            this.maximo_paginas = Math.Ceiling(this.total / this.items_por_pagina);
            lbl_totalPaginas.Text = this.maximo_paginas.ToString();
            if (tabla.Rows.Count > 0)
            {
                dataGridView1.DataSource = Split(tabla);
                
            }
            else
            {
                MessageBox.Show("No se encontraron facturas para la empresa.");
            }
        }

        private DataTable Split(DataTable tabla)
        {
            lbl_Pagina.Text = (this.pagina + 1).ToString();
            HabilitarBotones();
            if (tabla.Rows.Count > 0)
            {
                return tabla.Select().Skip(Convert.ToInt32(this.items_por_pagina * this.pagina)).Take(this.items_por_pagina).CopyToDataTable();
            }
            else
            {
                MessageBox.Show("No se encontraron facturas para la empresa.");
                DataTable datable = new DataTable();
                return datable;
            }
        }

        private void HabilitarBotones()
        {
            if (this.pagina == 0)
            {
                btn_Previo.Enabled = false;
            }
            else
            {
                btn_Previo.Enabled = true;
            }

            if (this.pagina == (this.maximo_paginas - 1))
            {
                btn_Sig.Enabled = false;
            }
            else
            {
                btn_Sig.Enabled = true;
            }
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

        private void btn_Sig_Click(object sender, EventArgs e)
        {
            this.pagina = this.pagina + 1;
            dataGridView1.DataSource = Split(this.todos_los_datos);
        }

        private void btn_Previo_Click(object sender, EventArgs e)
        {
            this.pagina = this.pagina - 1;
            dataGridView1.DataSource = Split(this.todos_los_datos);
        }
    }
}
