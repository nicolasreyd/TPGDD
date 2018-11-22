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
    public partial class Alta_Rol : Form
    {

        private String nombre_alta;
        List<Datos.Funcionalidad> funcionalidades_seleccionadas = new List<Datos.Funcionalidad>();
        Herramientas.Funcionalidades_Pantallas funcionalidades;


        public Alta_Rol()
        {
            InitializeComponent();
            funcionalidades = new Herramientas.Funcionalidades_Pantallas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void volver_ambRol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ABMRol abm = new ABMRol();
            abm.Show();
        }

        private void Alta_Rol_Load(object sender, EventArgs e)
        {
            List<Datos.Funcionalidad> funcionalidades = new List<Datos.Funcionalidad>();
            funcionalidades = App.db.getFuncionalidadesTotales();
            completar_listbox(funcionalidades);
          
        }

private void completar_listbox(List<Datos.Funcionalidad> funcionalidades)
{
 	foreach(Datos.Funcionalidad funcionalidad in funcionalidades ){
        funcionalidades_checklist.Items.Add(funcionalidad);
        funcionalidades_checklist.DisplayMember = "nombre";
        funcionalidades_checklist.ValueMember = "id";
    }
}

        private void nomreRol_Textbox_TextChanged(object sender, EventArgs e)
        {
            this.nombre_alta = nombreRol_Textbox.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Alta_Button_Click(object sender, EventArgs e)
        {
            if (get_funcionalidades_seleccionadas().Count > 0)
            {
                int result = App.db.agregar_nuevo_rol(nombre_alta, get_funcionalidades_seleccionadas());

                if (result == 1)
                {
                    MessageBox.Show("Rol correctamente creado.");
                }
                else
                {
                    MessageBox.Show("Error al cargar el rol, vuelva a intentar.");
                }
            }
            else {
                MessageBox.Show("No se selecciono ninguna funcionalidad");
            }

        }

        private List<Datos.Funcionalidad> get_funcionalidades_seleccionadas()
        {
            List<Datos.Funcionalidad> funcionalidades = new List<Datos.Funcionalidad>();

            if (funcionalidades_checklist.CheckedItems.Count > 0)
            {
                foreach (Datos.Funcionalidad funcionalidad in funcionalidades_checklist.CheckedItems)
                {

                    funcionalidades.Add(funcionalidad);
                }

            }
            else {

                MessageBox.Show("No se selecciono ninguna funcionalidad");
                return funcionalidades;
            
            }
                
            return funcionalidades;
        }

        private void Limpiar_Button_Click(object sender, EventArgs e)
        {
            
            funcionalidades.Limpiar(this);
            for (int i = 0; i < funcionalidades_checklist.Items.Count; i++)
            {

                funcionalidades_checklist.SetItemChecked(i, false);

            }
           
        }
    }
}
