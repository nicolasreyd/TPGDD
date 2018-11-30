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
        Herramientas.Funcionalidades_Pantallas func;

        
        public Generar_Publicacion()
        {
            InitializeComponent();
            this.publicacion = new Datos.Publicacion();
            func = new Herramientas.Funcionalidades_Pantallas();

            cargar_rubros();
            cargar_grados();
        }

        private void cargar_grados()
        {
            List<Datos.Grado> grados = App.db.getGrados();

            grados.ForEach(delegate(Datos.Grado grado)
            {
                Grado_comboBox.Items.Add(grado.descripcion + " $ " + grado.comision);

            });


            Grado_comboBox.SelectedItem = grados.First().descripcion + " $ " + grados.First().comision;
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

 
        private void Generar_Publicacion_Load(object sender, EventArgs e)
        {
            Fecha_publi_TextBox.Text = DateTime.Today.ToString("dd/MM/yyyy");
            Estado_Textbox.Text = "Borrador";
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
                string[] split_grado = Convert.ToString(Grado_comboBox.SelectedItem).Split(' ');
                Console.WriteLine(split_grado[0]);
                publicacion.grado = new Datos.Grado(split_grado[0], 1 , Convert.ToDecimal(split_grado[2])); 
                App.db.generar_publicacion(publicacion);

                descartar_publicacion();

            }
            else {
                MessageBox.Show("Debe completar todos los campos correctamente");
            }
        }

        private void descartar_publicacion()
        {
            func.Limpiar(this);
            publicacion.ubicaciones = new List<Datos.Ubicacion>();
        }

        private bool data_validate()
        {
            bool resultado = true;


            if (String.IsNullOrEmpty(Descripcion_textBox.Text))
            {
                errorProvider.SetError(Descripcion_textBox, "El campo Descripcion es requerido");
                resultado = false;
            }


                //Verifico que la fecha de inicio sea menor o igual a la de vencimiento
                if (FechaEspec_dateTimePicker.Value < DateTime.Today)
                {
                    errorProvider.SetError(FechaEspec_dateTimePicker, "La fecha de espectaculo no puede ser menor a la de publicacion");
                    resultado = false;
                }
            

            if (String.IsNullOrEmpty(Direccion_TextBox.Text))
            {
                errorProvider.SetError(Direccion_TextBox, "El campo Direccion es requerido");
                resultado = false;
            }

            return resultado;
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

        private void Descartar_Button_Click(object sender, EventArgs e)
        {
            this.descartar_publicacion();
        }

        private void Generar_Publicacion_MouseClick(object sender, MouseEventArgs e)
        {
            cantidadUbicaciones_textbox.Text = Convert.ToString(publicacion.ubicaciones.Count);
        }

        private void verubic_button_Click(object sender, EventArgs e)
        {
            cantidadUbicaciones_textbox.Text = Convert.ToString(publicacion.ubicaciones.Count);
        }

     
    
    }
}
