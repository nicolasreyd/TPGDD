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

namespace PalcoNet.Canje_Puntos
{
    public partial class CanjePuntos : Form
    {
        private decimal cliente;
        private decimal puntos;
        private DateTime fecha_venc_puntos;
        private DataTable table_premios_productos;

        private decimal id_canje;
        private decimal puntos_canje;

        public CanjePuntos()
        {
            InitializeComponent();
            this.cliente = App.db.getClienteId();
            this.puntos = App.db.getPuntos(this.cliente);
            this.fecha_venc_puntos = App.db.getPuntosVencimiento(this.cliente);
            Console.WriteLine(this.puntos.ToString());

            SqlDataAdapter adapter = App.db.getPremiosYProductos(this.puntos);
            DataTable table = new DataTable();
            adapter.Fill(table);

            this.table_premios_productos = table;
            dataGridViewPremios.DataSource = this.table_premios_productos;

            lblPuntos.Text = this.puntos.ToString();
            lblFechaVencimiento.Text = this.fecha_venc_puntos.ToString("dd/MM/yyyy");
        }

        private void actualizarTablas(Decimal idCanje, Decimal puntosCanje)
        {
            Decimal puntosFinales = this.puntos - puntosCanje;
            int statusPuntos = App.db.actualizarPuntos(this.cliente, puntosFinales);
            Decimal statusCanje = App.db.agregarPremioACliente(this.cliente, idCanje);
            Console.WriteLine("Status");
            Console.WriteLine(statusPuntos.ToString());
            Console.WriteLine(statusCanje.ToString());

            if (statusPuntos == 1 && statusCanje == -1)
            {
                this.puntos = puntosFinales;
                lblPuntos.Text = this.puntos.ToString();
                lblMensaje.Text = "Canje realizado con exito";
            }
            else {
                lblMensaje.Text = "Ocurrio un error en la operacion";
            }
        }

        private void CanjePuntos_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnclm = new DataGridViewButtonColumn();
            btnclm.Name = "Canjear";
            dataGridViewPremios.Columns.Add(btnclm);
        }

        private void dataGridViewPremios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewPremios.Columns[e.ColumnIndex].Name == "Canjear") {
                if (dataGridViewPremios.CurrentRow.Cells[0].Value != System.DBNull.Value && dataGridViewPremios.CurrentRow.Cells[0].Value != null)
                {
                    if (Convert.ToDecimal(dataGridViewPremios.CurrentRow.Cells[1].Value) <= this.puntos)
                    {
                        this.id_canje = Convert.ToDecimal(dataGridViewPremios.CurrentRow.Cells[0].Value);
                        this.puntos_canje = Convert.ToDecimal(dataGridViewPremios.CurrentRow.Cells[1].Value);
                        actualizarTablas(this.id_canje, this.puntos_canje);
                    }
                    else
                    {
                        lblMensaje.Text = "Puntos insuficientes";
                    }
                    
                }
                else
                {
                    lblMensaje.Text = "No hay nada que canjear";
                }
                

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login.MenuPrincipal menu = new Login.MenuPrincipal();
            menu.Show();
        }
        
    }
}
