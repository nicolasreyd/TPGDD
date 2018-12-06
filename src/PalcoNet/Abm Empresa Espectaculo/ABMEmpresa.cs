using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Empresa_Espectaculo
{
    public partial class ABMEmpresa : Form
    {
        public ABMEmpresa()
        {
            InitializeComponent();
        }

        private void ClienteAlta_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alta_Empresa alta = new Alta_Empresa();
            alta.Show();
        }

        private void ModificacionCliente_button_Click(object sender, EventArgs e)
        {
        //    this.Hide();
        //    Alta_Empresa alta = new Alta_Empresa();
        //    alta.Show();
        }

        private void BajaCliente_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Baja_Empresa baja = new Baja_Empresa();
            baja.Show();
        }
    }
}
