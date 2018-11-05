using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet
{
    public partial class Main : Form
    {

        public static SQLConnector db = new SQLConnector();
        public static Login.Login login;

        public Main()
        {
            InitializeComponent();
        }

        private void iralogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            login = new PalcoNet.Login.Login();
            login.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
