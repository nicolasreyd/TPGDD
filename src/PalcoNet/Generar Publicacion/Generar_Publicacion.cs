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
    public partial class Generar_Publicacion : Form
    {
        Datos.Publicacion publicacion;


        public Generar_Publicacion()
        {
            InitializeComponent();
            this.publicacion = new Datos.Publicacion();

            cargar_rubros();
        }

        private void cargar_rubros()
        {
            List<Datos.Rubro> rubros = App.db.getRubros();

            rubros.ForEach(delegate(Datos.Rubro rubro)
            {
                Rubro_comboBox.Items.Add(rubro.descripcion);

            });


            Rubro_comboBox.SelectedItem = rubros.First().descripcion;
        }

        private void Estado_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Generar_Publicacion_Load(object sender, EventArgs e)
        {
            Fecha_publi_TextBox.Text = DateTime.Today.ToString("dd/MM/yyyy");
            Estado_Textbox.Text = "Borrador";
        }

        private void Completar_Enter(object sender, EventArgs e)
        {

        }

        private void Generar_Button_Click(object sender, EventArgs e)
        {
            if (data_validate())
            {
                publicacion.descripcion = Descripcion_textBox.Text;
                publicacion.fecha_publicacion = DateTime.Today;
                publicacion.fecha_espectaculo = FechaEspec_dateTimePicker.Value;
                publicacion.rubro = Convert.ToString(Rubro_comboBox.SelectedItem);
                publicacion.estado = Estado_Textbox.Text;
                publicacion.direccion = Direccion_TextBox.Text;

                App.db.generar_publicacion(publicacion);

            }
            else {
                MessageBox.Show("Debe completar todos los campos correctamente");
            }
        }

        private bool data_validate()
        {
            throw new NotImplementedException();
        }

        private void SigEstado_button_Click(object sender, EventArgs e)
        {
            if (this.publicacion.id > 0)
            {
                this.publicacion.estado = "Activa";
            }
            else {
                MessageBox.Show("Primero debe generar la publicacion.");
            }
        }

        private void Rubro_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgregarUbi_Button_Click(object sender, EventArgs e)
        {
            Ubicaciones_Agregar agregar = new Ubicaciones_Agregar(this.publicacion);
            agregar.Show();
        }

    
    }
}
