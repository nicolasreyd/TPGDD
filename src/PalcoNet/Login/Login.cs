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
        int intentos_login;
        
        

        public Login()
        {
            InitializeComponent();
            this.password_textbox.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {
            username_textbox.Focus();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            password_textbox.Focus();
        }

        private void username_textbox_TextChanged(object sender, EventArgs e)
        {
            this.username = username_textbox.Text;
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {
            this.password = password_textbox.Text;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            var resultado = true;

            if (String.IsNullOrEmpty(username))
            {
                errorProvider1.SetError(username_textbox, "El campo es requerido");
                resultado = false;
            }

            if (String.IsNullOrEmpty(password))
            {
                errorProvider1.SetError(password_textbox, "El campo es requerido");
                resultado = false;
            }

            if(resultado == true){
                SqlDataReader data = App.db.command_reader("select * from GD2C2018.INNERJOIN.usuario where usuario_username LIKE '" + this.username + "'");
            if (data.Read())
            {
                //Datos leidos
                String usuario_leido = data.GetString(1);
                Decimal id_leido = data.GetDecimal(0);
                String password_leida = data.GetString(2);
                Boolean baja_leida = data.GetBoolean(5);

                data.Close();
                user_validate(usuario_leido, id_leido, password_leida, baja_leida);

            }
            else {
                data.Close();
                MessageBox.Show("Usuario incorrecto, vuelva a intentar");
            }
         }
           
      }

       

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void user_validate(String usuario_leido, Decimal id_leido, String password_leida, Boolean baja_leida) 
        {

            if(baja_leida == false){
                MessageBox.Show("Usuario inhabilitado, intente con otro");
                this.Hide();
                Login nuevo_login = new Login();
                nuevo_login.Show();
            }

            if (!user_exists(usuario_leido))
            { 
                MessageBox.Show("Usuario incorrecto, vuelva a intentar");
            }
            else { 

            if (password_match(password_leida))
            {
                this.password = "";
                Console.WriteLine("Cantidad de roles");
                App.currentUser = new Datos.Usuario(id_leido,this.username);
                Console.WriteLine(App.currentUser.getRoles().Count);

                //Mostrar siguiente pantalla, si tiene mas de un rol
                if (App.currentUser.getRoles().Count > 1)
                {
                    this.Hide();
                    SeleccionRol roles = new SeleccionRol();
                    roles.Show();
                }
                //Sino ir al menu principal
                else
                {
                    this.Hide();
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Show();
                }
                

            }
            else {
                MessageBox.Show("contraseña incorrecta");
                intentos_login++;
                this.password = "";
                if (intentos_login >= 3)
                {
                    App.db.inhabilitarUsuario(usuario_leido, id_leido);
                }

             }

           }
        }


        private bool user_exists(String data)
        {
            return data != null;
        }

        private bool password_match(String password)
        {  
           String passwordDecrypt = Herramientas.Encrypter.Encrypt256(this.password);

           return password.Equals(passwordDecrypt);
        }

        private void nuevoCliente_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abm_Cliente.Baja_Cliente bajaCliente = new Abm_Cliente.Baja_Cliente();
            bajaCliente.Show();

        }
    }
}
