using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

		}

		private void GradoModificacion_Button_Click(object sender, EventArgs e)
		{

		}
	}
}
