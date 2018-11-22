using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace PalcoNet
{
    public class DBOperations
    {
        private SqlConnection connection;
        private const string ConnectionKey = "conexion";

        private static string ConnectionString
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings[ConnectionKey].ConnectionString;
            }
        }

        public DBOperations()
        {
        }

        public SqlDataReader command_reader(string query)
        {
            
            SqlCommand sqlcommand = new SqlCommand();
            connection = new SqlConnection(ConnectionString);
            connection.Open();
            sqlcommand.Connection = this.connection;
 
            sqlcommand.CommandText = query;
            Console.WriteLine(query);

            SqlDataReader exec = sqlcommand.ExecuteReader();
            return exec;
        }

        public int command_update(string query)
        {

            SqlCommand sqlcommand = new SqlCommand();
            connection = new SqlConnection(ConnectionString);
            connection.Open();
            sqlcommand.Connection = this.connection;

            sqlcommand.CommandText = query;
            Console.WriteLine(query);
            int resultado = sqlcommand.ExecuteNonQuery();
            return resultado;
        }

        public Decimal command_insert(string query)
        {
            SqlCommand sqlcommand = new SqlCommand();
            connection = new SqlConnection(ConnectionString);
            connection.Open();
            sqlcommand.Connection = this.connection;

            sqlcommand.CommandText = query;
            Console.WriteLine(query);
            Decimal resultado = Convert.ToDecimal(sqlcommand.ExecuteScalar());

            if (resultado == 0) {
                return -1;
            }

            return resultado;
        }

        public void close(string query)
        {
            connection.Close();
            Console.WriteLine("Desconectado de GD2C2018");
           
        }

        public List<Datos.Rol> getRoles(Decimal user_id) {
            List<Datos.Rol> roles = new List<Datos.Rol>();
            SqlDataReader data = command_reader("select distinct id_rol,rol_nombre from gd_esquema.usuario_rol join gd_esquema.rol on id_rol = rol_id where id_usuario = "+ user_id);
            
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

        public List<String> getFuncionalidades(Decimal id_rol) {
            List<String> funcionalidades = new List<String>();
            SqlDataReader data = command_reader("select func_nombre from gd_esquema.rol_funcionalidad r join gd_esquema.funcionalidad on r.id_funcionalidad = func_id where r.id_rol = " + id_rol);

            if (data.HasRows)
            {
                while (data.Read())
                {
                    String funcionalidad = data.GetString(0);
                    funcionalidades.Add(funcionalidad);
                }
            }

            data.Close();
            return funcionalidades;
        }


        public int inhabilitarUsuario(string usuario_leido, Decimal id_leido)
        {
            int resultado = command_update("update gd_esquema.usuario set usuario_baja_logica = 0 where usuario_id = " + id_leido);
            return resultado;
        }

        public List<Datos.Funcionalidad> getFuncionalidadesTotales()
        {
            List<Datos.Funcionalidad> funcionalidades = new List<Datos.Funcionalidad>();
            SqlDataReader data = command_reader("select * from gd_esquema.funcionalidad");

            if (data.HasRows)
            {
                while (data.Read())
                {
                    //Datos leidos
                    Datos.Funcionalidad funcionalidad = new Datos.Funcionalidad(data.GetDecimal(0), data.GetString(1));
                    funcionalidades.Add(funcionalidad);
                }
            }

            data.Close();
            return funcionalidades;
        }

        public int agregar_nuevo_rol(String nombre_alta, List<Datos.Funcionalidad> funcionalidades)
        {
            SqlCommand command;
            Decimal id_generado = command_insert("insert into gd_esquema.rol values ('" + nombre_alta + "', 1); select SCOPE_IDENTITY()");
            if (id_generado < 0)
            {
                return -1;
            }
            else {
            foreach(Datos.Funcionalidad funcionalidad in funcionalidades){

                command = new SqlCommand("insert into gd_esquema.rol_funcionalidad values(@id_rol,@funcionalidad_id)", this.connection);
                command.Parameters.AddWithValue("@id_rol", id_generado);
                command.Parameters.AddWithValue("@funcionalidad_id", funcionalidad.id);

                command.ExecuteNonQuery();
                

            }
            return 1;
            }


        }

        public SqlDataAdapter getTablaRol()
        {
            SqlCommand sqlcommand = new SqlCommand();
            connection = new SqlConnection(ConnectionString);
            SqlCommand query = new SqlCommand("select * from gd_esquema.rol", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(query);

            return adapter;
        }

        public SqlDataAdapter getRolByName(String nombre)
        {
            SqlCommand sqlcommand = new SqlCommand();
            connection = new SqlConnection(ConnectionString);
            SqlCommand query = new SqlCommand("select * from gd_esquema.rol where rol_nombre LIKE '"+nombre+"'", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(query);

            return adapter;
        }
    }

 


}
