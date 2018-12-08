using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Generar_Rendicion_Comisiones
{
    public partial class Generar_Rendiciones : Form
    {
        public Generar_Rendiciones()
        {
            InitializeComponent();
            cargar_empresas();
        }

        private void cargar_empresas()
        {
            List<string> empresas = App.db.getEmpresasName();

            empresas.ForEach(delegate(string empresa)
            {
                Empresa_comboBox1.Items.Add(empresa);

            });


            Empresa_comboBox1.SelectedItem = empresas.First();
        }

        private void Generar_Rendiciones_Load(object sender, EventArgs e)
        {

        }

        private void Todas_checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Todas_checkBox1.Checked)
            {
                Cantidad_textBox1.Enabled = false;
                Cantidad_textBox1.Text = "Todas";

            }
            else {
                Cantidad_textBox1.Enabled = true;
                Cantidad_textBox1.Text = "";
            }
        }

        private void Limpiar_button1_Click(object sender, EventArgs e)
        {
            Herramientas.Funcionalidades_Pantallas.Limpiar(this);
        }

        private void Volver_linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login.MenuPrincipal menu = new Login.MenuPrincipal();
            menu.Show();
        }

        private void Rendir_Button_Click(object sender, EventArgs e)
        {
            if (validate_data()) {
                int cantidad_generadas = App.db.generar_rendiciones();
            }
        }

        private bool validate_data()
        {
            return true;
        }

       
    }
}
