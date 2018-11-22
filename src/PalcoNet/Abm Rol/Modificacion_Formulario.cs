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
    public partial class Modificacion_Formulario : Form
    {

        Decimal id_seleccionado;
        String nombre_modificar;
        Herramientas.Funcionalidades_Pantallas func;

        public Modificacion_Formulario(Decimal id)
        {
            InitializeComponent();
            id_seleccionado = id;
            func = new Herramientas.Funcionalidades_Pantallas();
        }

        private void Moficacion_Formulario_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.nombre_modificar = nombre_textbox.Text;
        }

        private void Limpiar_Button_Click(object sender, EventArgs e)
        {
            func.Limpiar(this);
        }

        private void Habilitado_check_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
