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
    public partial class ABMRol : Form
    {
        public ABMRol()
        {
            InitializeComponent();
        }

        private void ABMRol_Load(object sender, EventArgs e)
        {

        }

        private void RolAlta_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alta_Rol alta = new Alta_Rol();
            alta.Show();

        }

        private void volver_menuprincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login.MenuPrincipal menu = new Login.MenuPrincipal();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modificacion_Rol modific = new Modificacion_Rol();
            modific.Show();
        }

        private void RolBaja_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Baja_Rol baja = new Baja_Rol();
            baja.Show();
        }
    }
}
