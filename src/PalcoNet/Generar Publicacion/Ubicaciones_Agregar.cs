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

            if (data_validate())
            {
                if (ubicacion.numerada == 1)
                {
                    ubicacion.Asiento = Convert.ToInt32(Asiento_textBox.Text);
                    ubicacion.Fila = Fila_textBox.Text;
                }
                else
                {
                    ubicacion.Asiento = 0;
                    ubicacion.Fila = "";
                }
                ubicacion.precio = Convert.ToDecimal(Precio_textBox.Text);
                ubicacion.tipo = App.db.getTipoUbicacion(Convert.ToString(Tipo_comboBox.SelectedItem));

                this.publicacion.ubicaciones.Add(ubicacion);

                MessageBox.Show("Ubicacion Agregada.");
                this.Hide();
                
            }
            else {
                MessageBox.Show("Valide los datos ingresados.");
            }
        }

        private bool data_validate()
        {
            bool resultado = true;

            if (Numerada_checkBox.Checked) {
                if (String.IsNullOrEmpty(Asiento_textBox.Text))
                {
                    errorProvider.SetError(Asiento_textBox, "El campo Asiento es requerido");
                    resultado = false;
                }

                if (String.IsNullOrEmpty(Fila_textBox.Text))
                {
                    errorProvider.SetError(Fila_textBox, "El campo Fila es requerido");
                    resultado = false;
                }

            }


            if (String.IsNullOrEmpty(this.Precio_textBox.Text))
            {
                errorProvider.SetError(Precio_textBox, "El campo Precio es requerido");
                resultado = false;
            }

            else if (!(Herramientas.Funcionalidades_Pantallas.esNumero(Precio_textBox.Text)))
            {
                errorProvider.SetError(Precio_textBox, "Ingrese un valor numerico");
                resultado = false;
            }

            return resultado;
        }
  }

}
