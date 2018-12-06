using PalcoNet.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Cliente
{
    public partial class ABMCliente : Form
    {
        public ABMCliente()
        {
            InitializeComponent();
        }

        private void ClienteAlta_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alta_Cliente alta = new Alta_Cliente();
            alta.Show();
        }

        private void ModificacionCliente_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abm_Cliente.busquedaModificacion_Cliente modifCliente = new Abm_Cliente.busquedaModificacion_Cliente();
            modifCliente.Show();
        }

        private void BajaCliente_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abm_Cliente.Baja_Cliente bajaCliente = new Abm_Cliente.Baja_Cliente();
            bajaCliente.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
        }
    }
}
