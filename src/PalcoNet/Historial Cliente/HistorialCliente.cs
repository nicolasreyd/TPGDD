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

namespace PalcoNet.Historial_Cliente
{
    public partial class HistorialCliente : Form
    {
        private decimal cliente;
        private DataTable todos_los_datos;
        private decimal total = 0;
        private decimal pagina = 0;
        private decimal maximo_paginas = 0;
        private int items_por_pagina = 10;

        public HistorialCliente()
        {
            InitializeComponent();
            this.cliente = App.currentUser.user_id;//App.db.getClienteId();
            SqlDataAdapter adapter = App.db.getCompras(this.cliente);
            DataTable table = new DataTable();
            adapter.Fill(table);

            this.todos_los_datos = table;
            this.total = this.todos_los_datos.Rows.Count;
            this.maximo_paginas = Math.Ceiling(this.total / this.items_por_pagina);
            lbl_totalPaginas.Text = this.maximo_paginas.ToString();
            dataGridView1.DataSource = Split(table);
            HabilitarBotones();
        }

        private DataTable Split(DataTable tablaCompras) {
            lbl_Pagina.Text = (this.pagina + 1).ToString();
            HabilitarBotones();
            return tablaCompras.Select().Skip(Convert.ToInt32(this.items_por_pagina * this.pagina)).Take(this.items_por_pagina).CopyToDataTable();
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

        private void HabilitarBotones() {
            if (this.pagina == 0)
            {
                btn_Previo.Enabled = false;
            }
            else {
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


    }
}
