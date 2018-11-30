using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Generar_Publicacion
{
    public partial class Ubicaciones_Agregar : Form
    {
        Datos.Publicacion publicacion;
        public Ubicaciones_Agregar(Datos.Publicacion _publicacion)
        {
            InitializeComponent();
            this.publicacion = _publicacion;
            cargar_tipos();
        }

        private void cargar_tipos()
        {
            List<String> tipos = App.db.getTipoUbicacion();

            tipos.ForEach(delegate(String tipo)
            {
                Tipo_comboBox.Items.Add(tipo);

            });


            Tipo_comboBox.SelectedItem = tipos.First();
        }

        private void Numerada_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Numerada_checkBox.Checked)
            {
                Fila_textBox.Enabled = true;
                Asiento_textBox.Enabled = true;
            }
            else {
                Fila_textBox.Enabled = false;
                Asiento_textBox.Enabled = false;
            }
        }

        private void Ubicaciones_Agregar_Load(object sender, EventArgs e)
        {
            Fila_textBox.MaxLength = 2;
            Fila_textBox.Enabled = false;
            Asiento_textBox.MaxLength = 3;
            Asiento_textBox.Enabled = false;
        }

        private void Agregar_Button_Click(object sender, EventArgs e)
        {
            Datos.Ubicacion ubicacion = new Datos.Ubicacion();
            ubicacion.numerada = Convert.ToInt32(Numerada_checkBox.Checked);
            if (ubicacion.numerada == 1) {
                ubicacion.Asiento = Convert.ToInt32(Asiento_textBox.Text);
                ubicacion.Fila = Fila_textBox.Text;
            }
            ubicacion.precio = Convert.ToDecimal(Precio_textBox.Text);
            ubicacion.tipo = App.db.getTipoUbicacion(Convert.ToString(Tipo_comboBox.SelectedItem));

            this.publicacion.ubicaciones.Add(ubicacion);

            this.Hide();
        }

    
    }
}
