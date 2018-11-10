using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PalcoNet.Login
{
    public partial class Login : Form
    {
        private String username;
        private String password;
        private DBOperations connection;

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            username_textbox.Focus();
        }

        private void username_textbox_TextChanged(object sender, EventArgs e)
        {
            this.username = username_textbox.Text;
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {
            this.password = password_textbox.Text;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            password_textbox.Focus();
        }

        private void login_button_Click(object sender, EventArgs e)
        {

            SqlDataReader data = App.db.command("select * from GD2C2018.gd_esquema.usuario where usuario_username LIKE '" + this.username + "'");
            data.Read();

            user_validate(data);
           
        }

       

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void user_validate(SqlDataReader data) 
        {
            if (!user_exists(data))
            { //falta checkear baja logica
                MessageBox.Show("Usuario incorrecto, vuelva a intentar");
            }
      
            if (password_match(data))
            {
                Console.WriteLine("Cantidad de roles");
                App.currentUser = new Datos.Usuario(data.GetInt32(0),this.username);
                Console.WriteLine(App.currentUser.getRoles().Count);

                //Mostrar siguiente pantalla, si tiene mas de un rol
                if (App.currentUser.getRoles().Count > 1)
                {
                    SeleccionRol roles = new SeleccionRol();
                }
                //Sino ir al menu principal
                else
                {
                    //MenuPrincipal menu = new MenuPrincipal();
                }
                

            }
            else {
                MessageBox.Show("contraseña incorrecta");
                //aumentar cantidad de fallos y voler a intentar.
            }
        }

        private bool user_exists(SqlDataReader data)
        {
            return data.GetString(1) != null;
        }

        private bool password_match(SqlDataReader data)
        {  
           String passworddb = data.GetString(2);
           String passwordDecrypt = Herramientas.Encrypter.Encrypt256(this.password);

           return passworddb.Equals(passwordDecrypt);
        }
    }
}
