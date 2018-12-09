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

namespace PalcoNet.Listado_Estadistico
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            armar_listados();
            armar_trimestres();
            cargar_grados();
        }

        private void armar_trimestres()
        {
            //Build a list
            var dataSource = new List<Decimal>();
            dataSource.Add(1);
            dataSource.Add(2);
            dataSource.Add(3);
            dataSource.Add(4);
            //Setup data binding
            this.trimestre_comboBox.DataSource = dataSource;
        }

        private void armar_listados()
        {
            //Build a list
            var dataSource = new List<Datos.Listado>();
            dataSource.Add(new Datos.Listado("localidades_no_vendidas","Localidades no vendidas"));
            dataSource.Add(new Datos.Listado("puntos_vencidos", "Puntos vencidos"));
            dataSource.Add(new Datos.Listado("cantidad_compras", "Cantidad de compras"));

            //Setup data binding
            this.listado_comboBox.DataSource = dataSource;
            this.listado_comboBox.DisplayMember = "nombre";
            this.listado_comboBox.ValueMember = "codigo";
        }

        private void cargar_grados()
        {
            List<Datos.Grado> grados = App.db.getGrados();

            //Setup data binding
            this.grado_comboBox.DataSource = grados;
            this.grado_comboBox.DisplayMember = "descripcion";
            this.grado_comboBox.ValueMember = "id";
        }

        private void listado_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grado_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listar_Click(object sender, EventArgs e)
        {
            if (anio_textBox.Text=="")
            {
                MessageBox.Show("El anio no puede ser vacío");
                return;
            }
            int anio;
            if (!(int.TryParse(anio_textBox.Text,out anio) )){
                MessageBox.Show("Inserte un año correcto");
                return;
            }
            if(
                !(anio >= 1900 &&
                anio <= 3000))
            {
                MessageBox.Show("Inserte un año correcto");
                return;
            }
            DateTime fechaDesde = new DateTime();
            DateTime fechaHasta = new DateTime();
            if (trimestre_comboBox.Text == "1")
            {
                DateTime.TryParse(anio + "/01/01", out fechaDesde);
                DateTime.TryParse(anio + "/04/01", out fechaHasta);
            }
            if (trimestre_comboBox.Text == "2")
            {
                DateTime.TryParse(anio + "/04/01", out fechaDesde);
                DateTime.TryParse(anio + "/07/01", out fechaHasta);
            }
            if (trimestre_comboBox.Text == "3")
            {
                DateTime.TryParse(anio + "/07/01", out fechaDesde);
                DateTime.TryParse(anio + "/10/01", out fechaHasta);
            }
            if (trimestre_comboBox.Text == "4")
            {
                DateTime.TryParse(anio + "/10/01", out fechaDesde);
                DateTime.TryParse((anio+1) + "/01/01", out fechaHasta);
            }
            if(listado_comboBox.SelectedValue.ToString() == "localidades_no_vendidas")
            {
                SqlDataAdapter result = App.db.getLocalidadesNoVendidas(fechaDesde,fechaHasta,Convert.ToDecimal(grado_comboBox.SelectedValue));
                llenar_tabla(result);
            }
            if (listado_comboBox.SelectedValue.ToString() == "puntos_vencidos")
            {
                SqlDataAdapter result = App.db.getPuntosVencidos(fechaDesde, fechaHasta);
                llenar_tabla(result);
            }
            if (listado_comboBox.SelectedValue.ToString() == "cantidad_compras")
            {
                SqlDataAdapter result = App.db.getCantidadCompras(fechaDesde, fechaHasta);
                llenar_tabla(result);
            }
            
        }
        private void llenar_tabla(SqlDataAdapter data)
        {
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            this.dataGridView1.DataSource = tabla;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public static DataTable ObjectToData(object o)
        {
            DataTable dt = new DataTable("OutputData");

            DataRow dr = dt.NewRow();
            dt.Rows.Add(dr);

            o.GetType().GetProperties().ToList().ForEach(f =>
            {
                try
                {
                    f.GetValue(o, null);
                    dt.Columns.Add(f.Name, f.PropertyType);
                    dt.Rows[0][f.Name] = f.GetValue(o, null);
                }
                catch { }
            });
            return dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
