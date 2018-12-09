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

        private void Guardar_button1_Click(object sender, EventArgs e)
        {
            int resultado;
            if (data_validate())
            {
                string query = armar_query();
                if (query == "")
                {
                    MessageBox.Show("No hay datos a actualizar.");
                }
                else
                {

                    
                    
                    if (publicacion.ubicaciones.Count > 0)
                    {
                        App.db.agregar_ubicaciones(publicacion.ubicaciones, publicacion.id);
                         resultado = App.db.modificarPublicacion(query);
                    }
                    else
                    {
                         resultado = App.db.modificarPublicacion(query);
                        MessageBox.Show("No hay ubicaciones para agregar.");
                    }

                    if (resultado <= 0)
                    {
                        MessageBox.Show("Error al actualizar");
                    }
                    else {
                        MessageBox.Show("Actualizado Correctamente");
                        this.Hide();
                    }
                    
                }
            }
        }

        private string armar_query()
        {
            string query = "update INNERJOIN.publicacion set ";
            int count = 0;
            string[] split_grado;
            

            if (!String.IsNullOrEmpty(Convert.ToString(Rubro_comboBox1.SelectedItem)) && !Convert.ToString(Rubro_comboBox1.SelectedItem).Equals(publicacion.rubro))
            {
                Datos.Rubro rubro = App.db.getRubroByName(Convert.ToString(Rubro_comboBox1.SelectedItem));
                query = query + "id_rubro = " + rubro.id;
                count++;
            }

            if(!String.IsNullOrEmpty(Convert.ToString(Grado_comboBox1.SelectedItem))){

               split_grado = Convert.ToString(Grado_comboBox1.SelectedItem).Split(' ');

               if (!split_grado[0].Equals(publicacion.grado.descripcion) && !Convert.ToString(publicacion.grado.comision).Equals(split_grado[2]))
            {
                Datos.Grado grado = App.db.getGrado(Convert.ToString(split_grado[0]));

                if (count > 0)
                {
                    query = query +" , id_grado = " + grado.id;
                }
                else {
                    query = query + " id_grado = " + grado.id;  
                }
                count++;
            }
       }


            if(FechaEspec_dateTimePicker1.Value != publicacion.fecha_espectaculo){
                
                if (count > 0)
                {
                    query = query + " , publicacion_fecha_evento = '" + FechaEspec_dateTimePicker1.Value+"'";
                }
                else
                {
                    query = query + " publicacion_fecha_evento = '" + FechaEspec_dateTimePicker1.Value + "'";
                }
                count++;
            }

            if (!String.IsNullOrEmpty(Descripcion_textBox1.Text) && !Descripcion_textBox1.Text.Equals(publicacion.descripcion))
            {

                if (count > 0)
                {
                    query = query + " , publicacion_descripcion = '" + Descripcion_textBox1.Text + "'";
                }
                else
                {
                    query = query + " publicacion_descripcion = '" + Descripcion_textBox1.Text + "'";
                }
                count++;
            }

            if (!String.IsNullOrEmpty(Direccion_textBox1.Text) && !Direccion_textBox1.Text.Equals(publicacion.direccion))
            {

                if (count > 0)
                {
                    query = query + " , publicacion_direccion = '" + Direccion_textBox1.Text + "'";
                }
                else
                {
                    query = query + " publicacion_direccion = '" + Direccion_textBox1.Text + "'";
                }
                count++;
            }


            if (count > 0)
            {
                query = query + " where publicacion_id = " + publicacion.id;
            }
            else {
                query = "";
            }

            return query;


        }

        private bool data_validate()
        {
            bool resultado = true;

            if(String.IsNullOrEmpty(Descripcion_textBox1.Text)){
                resultado = false;
            }

            if (String.IsNullOrEmpty(Direccion_textBox1.Text))
            {
                resultado = false;
            }
            return resultado; //TODO
        }

        private void Limpiar_button1_Click(object sender, EventArgs e)
        {
            Herramientas.Funcionalidades_Pantallas.Limpiar(this);
            
        }
    }
}
