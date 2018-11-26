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
    }
}
