using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Editar_Publicacion
{
    public partial class Editar_formulario : Form
    {
        
        Datos.Publicacion publicacion;

        public Editar_formulario()
        {
            InitializeComponent();
        }

        public Editar_formulario(Datos.Publicacion _publicacion)
        {
            InitializeComponent();
            cargar_rubros();
            cargar_grados();
            this.publicacion = _publicacion;
        }

        private void cargar_grados()
        {
            List<Datos.Grado> grados = App.db.getGrados();

            grados.ForEach(delegate(Datos.Grado grado)
            {
                Grado_comboBox1.Items.Add(grado.descripcion + " $ " + grado.comision);

            });


            Grado_comboBox1.SelectedItem = grados.First().descripcion + " $ " + grados.First().comision;
        }

        private void cargar_rubros()
        {
            List<Datos.Rubro> rubros = App.db.getRubros();

            rubros.ForEach(delegate(Datos.Rubro rubro)
            {
                Rubro_comboBox1.Items.Add(rubro.descripcion);

            });


            Rubro_comboBox1.SelectedItem = rubros.First().descripcion;
        }

        private void AgregarUbicaciones_button1_Click(object sender, EventArgs e)
        {
            Generar_Publicacion.Ubicaciones_Agregar agregar = new Generar_Publicacion.Ubicaciones_Agregar(this.publicacion);
            agregar.Show();
        }

        private void Editar_formulario_Load(object sender, EventArgs e)
        {

        }

        private void QuitarUbicaciones_button1_Click(object sender, EventArgs e)
        {
            Ubicaciones_Quitar quitar = new Ubicaciones_Quitar(publicacion.id);
            quitar.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

        }
    }
}
