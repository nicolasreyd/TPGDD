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
using PalcoNet.Datos;

namespace PalcoNet.Comprar
{
    public partial class Comprar : Form
    {
        private decimal cliente;
        private DataTable todos_los_datos;
        private decimal total = 0;
        private decimal pagina = 0;
        private decimal maximo_paginas = 0;
        private int items_por_pagina = 10;
        List<Datos.Categoria> categorias_seleccionadas = new List<Datos.Categoria>();
        String descripcion;
        Herramientas.Funcionalidades_Pantallas categorias;
        public Comprar()
        {
            categorias = new Herramientas.Funcionalidades_Pantallas();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Decimal id = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            List<Tarjeta> tarjetas = App.db.getTarjetas();
            if (tarjetas.Count()>0)
            {
                using (var form1 = new ComprarUbicacionTarjeta(id))
                {
                    form1.ShowDialog();
                }
            }
            else
            {
                using (var form2 = new ComprarUbicacionSinTarjeta(id))
                {
                    form2.ShowDialog();
                }
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filtrar_Enter(object sender, EventArgs e)
        {

        }

        private void Comprar_Load(object sender, EventArgs e)
        {
            List<Datos.Categoria> categorias = new List<Datos.Categoria>();
            categorias = App.db.getCategoriasTotales();
            completar_listbox(categorias);
        }

        private void completar_listbox(List<Datos.Categoria> categorias)
        {
            foreach (Datos.Categoria categoria in categorias)
            {
                categoria_listBox.Items.Add(categoria);
                categoria_listBox.DisplayMember = "descripcion";
                categoria_listBox.ValueMember = "id";
            }
        }

        private List<Datos.Categoria> get_categorias_seleccionadas()
        {
            List<Datos.Categoria> categorias = new List<Datos.Categoria>();

            if (categoria_listBox.CheckedItems.Count > 0)
            {
                foreach (Datos.Categoria categoria in categoria_listBox.CheckedItems)
                {
                    categorias.Add(categoria);
                }

            }

            return categorias;
        }

        private void categoria_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void compra_limpiar_Click(object sender, EventArgs e)
        {
            //categorias.Limpiar(this);
            for (int i = 0; i < categoria_listBox.Items.Count; i++)
            {

                categoria_listBox.SetItemChecked(i, false);

            }
        }

        private void descripcion_textBox_TextChanged(object sender, EventArgs e)
        {
            this.descripcion = descripcion_textBox.Text;
        }

        private void compra_buscar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter data;

            data = App.db.getPulicacion(get_categorias_seleccionadas(), descripcion,fechaDesde_textBox.Value,fechaHasta_textBox.Value);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            this.todos_los_datos = tabla;
            this.total = this.todos_los_datos.Rows.Count;
            this.maximo_paginas = Math.Ceiling(this.total / this.items_por_pagina);
            lbl_totalPaginas.Text = this.maximo_paginas.ToString();
            this.dataGridView1.DataSource = Split(tabla);
            HabilitarBotones();

            //this.dataGridView1.DataSource = tabla;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private DataTable Split(DataTable tablaCompras)
        {
            lbl_Pagina.Text = (this.pagina + 1).ToString();
            HabilitarBotones();
            return tablaCompras.Select().Skip(Convert.ToInt32(this.items_por_pagina * this.pagina)).Take(this.items_por_pagina).CopyToDataTable();
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

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pagina = this.pagina + 1;
            dataGridView1.DataSource = Split(this.todos_los_datos);
        }

        private void atras_button_Click(object sender, EventArgs e)
        {
            this.pagina = this.pagina - 1;
            dataGridView1.DataSource = Split(this.todos_los_datos);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login.MenuPrincipal menu = new Login.MenuPrincipal();
            menu.Show();
        }
    }
}
