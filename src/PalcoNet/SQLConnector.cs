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
    public class SQLConnector
    {
        private SqlConnection connection;


        public SQLConnector()
        {

            try
            {
                this.connection = new SqlConnection("Data Source=.\\SQLSERVER2012;Initial Catalog=GD2C2018;user=sa;password=Miclave.1");
                this.connection.Open();
                Console.WriteLine("Conectando a GD2C2018");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar");
            }
        }

        public SqlDataReader command(string query)
        {

            SqlCommand sqlcommand = new SqlCommand();

            sqlcommand.Connection = this.connection;
            sqlcommand.CommandText = query;

            SqlDataReader exec = sqlcommand.ExecuteReader();
            return exec;
        }

        public void close(string query)
        {
            connection.Close();
            Console.WriteLine("Desconectado de GD2C2018");
           
        }
    }

 
}
