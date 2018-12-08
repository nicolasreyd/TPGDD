using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Rol
{
    public partial class Funcionalidad_Modif : Form
    {
        Decimal rol_id;
        String accion_pantalla;
        String funcionalidad_seleccionada;

        public Funcionalidad_Modif(String accion, Decimal id_rol)
        {
            InitializeComponent();
            this.rol_id = id_rol;
            accion_pantalla = accion;

            List<Datos.Funcionalidad> funcionalidades;
            if (accion == "Quitar")
            {
                funcionalidades = App.db.getFuncionalidades(id_rol);
            }
            else {
                funcionalidades = App.db.getMissingFuncionalidades(id_rol);
            }

            if (funcionalidades.Count > 0)
            {
                funcionalidades.ForEach(delegate(Datos.Funcionalidad funcionalidad)
                    {
                        comboFuncionalidades.Items.Add(funcionalidad.nombre);

                    });



                comboFuncionalidades.SelectedItem = funcionalidades.First().nombre;

            }
            else {
                
                MessageBox.Show("No hay items para agregar/Quitar");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Quitar_Funcionalidad_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void Guardar_Button_Click(object sender, EventArgs e)
        {
            Datos.Funcionalidad funcionalidad_seleccionada = App.db.getFuncionalidadByName(this.comboFuncionalidades.SelectedItem);
            if(accion_pantalla == "Quitar"){

                App.db.quitarFuncionalidad(rol_id, funcionalidad_seleccionada);
                MessageBox.Show("Funcionalidad quitada.");
            } else {
                App.db.agregarFuncionalidad(rol_id, funcionalidad_seleccionada);
                MessageBox.Show("Funcionalidad agregada.");
            }
            
            this.Hide();
        }

        private void comboFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
