using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Windows.Forms;

namespace PalcoNet
{
    public class DBOperations
    {
        private SqlConnection connection;


        public DBOperations()
        {

            try
            {
                this.connection = new SqlConnection("Data Source=.\\SQLSERVER2012;Initial Catalog=GD2C2018;user=gdEspectaculos2018;password=gd2019");
                this.connection.Open();
                Console.WriteLine("Conectando a GD2C2018");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar");
            }
        }

        public SqlDataReader command_reader(string query)
        {

            SqlCommand sqlcommand = new SqlCommand();

            sqlcommand.Connection = this.connection;
            sqlcommand.CommandText = query;
            Console.WriteLine(query);

            SqlDataReader exec = sqlcommand.ExecuteReader();
            return exec;
        }

        public int command_update(string query)
        {

            SqlCommand sqlcommand = new SqlCommand();

            sqlcommand.Connection = this.connection;
            sqlcommand.CommandText = query;
            Console.WriteLine(query);
            int resultado = sqlcommand.ExecuteNonQuery();

            return resultado;
        }

        public void close(string query)
        {
            connection.Close();
            Console.WriteLine("Desconectado de GD2C2018");
           
        }

        public List<Datos.Rol> getRoles(int user_id) {
            SqlDataReader data = command_reader("select distinct id_rol,rol_nombre from gd_esquema.usuario_rol join gd_esquema.rol on id_rol = rol_id where id_usuario = "+ user_id);
            List<Datos.Rol> roles = new List<Datos.Rol>();

            if (data.HasRows)
            {
                while (data.Read())
                {
                    Decimal id_rol = data.GetDecimal(0);
                    String nombre = data.GetString(1);
                    roles.Add(new Datos.Rol(id_rol, nombre));
                }
            }

            data.Close();
            return roles;
        }

        public int inhabilitarUsuario(string usuario_leido, int id_leido)
        {
            int resultado = command_update("update gd_esquema.usuario set usuario_baja_logica = 0 where usuario_id = " + id_leido);
            return resultado;
        }
    }

 


}
