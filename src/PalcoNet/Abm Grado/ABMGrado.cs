using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Login;

namespace PalcoNet.Abm_Grado
{
	public partial class ABMGrado : Form
	{
		public ABMGrado()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Alta_Grado alta = new Alta_Grado();
			alta.Show();
		}

		private void GradoBaja_Button_Click(object sender, EventArgs e)
		{
			this.Hide();
			Baja_Grado baja = new Baja_Grado();
			baja.Show();
		}

		private void GradoModificacion_Button_Click(object sender, EventArgs e)
		{
			this.Hide();
			Modificacion_Grado modificacion = new Modificacion_Grado();
			modificacion.Show();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			MenuPrincipal menu = new MenuPrincipal();
			menu.Show();
		}
	}
}
