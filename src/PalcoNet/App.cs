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
    public partial class App : Form
    {

        public static DBOperations db = new DBOperations();
        public static Login.Login login;
        public static Datos.Usuario currentUser;
        public static Datos.Rol currentRol;


        public App()
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
