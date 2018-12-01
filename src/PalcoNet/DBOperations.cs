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

        public object Execute_SP(string storedProcedureName, object parameters = null)
        {
            var command = new SqlCommand();
            this.connection = new SqlConnection(ConnectionString);
            this.connection.Open();

            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = storedProcedureName;

            if (parameters != null)
            {
                command.Parameters.AddRange(GetSqlParameters(parameters));
            }

            command.CommandTimeout = 0;
            command.Connection = connection;
            object result = command.ExecuteScalar();

            return result;

        }

        private static SqlParameter[] GetSqlParameters(object parameters)
        {
            List<SqlParameter> result = new List<SqlParameter>();
            foreach (var property in parameters.GetType().GetProperties())
            {
                
                    result.Add(new SqlParameter("@" + property.Name, property.GetValue(parameters, null)));
                
            }

            return result.ToArray();
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
            SqlDataReader data = command_reader("select distinct id_rol,rol_nombre from INNERJOIN.usuario_rol join INNERJOIN.rol on id_rol = rol_id where id_usuario = " + user_id);
            
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

        public List<Datos.Funcionalidad> getFuncionalidades(Decimal id_rol) {
            List<Datos.Funcionalidad> funcionalidades = new List<Datos.Funcionalidad>();
            SqlDataReader data = command_reader("select func_id,func_nombre from INNERJOIN.rol_funcionalidad r join INNERJOIN.funcionalidad on r.id_funcionalidad = func_id where r.id_rol = " + id_rol);

            if (data.HasRows)
            {
                while (data.Read())
                {
                    Datos.Funcionalidad funcionalidad = new Datos.Funcionalidad(data.GetDecimal(0), data.GetString(1));
                    funcionalidades.Add(funcionalidad);
                }
            }

            data.Close();
            return funcionalidades;
        }


        public int inhabilitarUsuario(string usuario_leido, Decimal id_leido)
        {
            int resultado = command_update("update INNERJOIN.usuario set usuario_baja_logica = 0 where usuario_id = " + id_leido);
            return resultado;
        }

        public List<Datos.Funcionalidad> getFuncionalidadesTotales()
        {
            List<Datos.Funcionalidad> funcionalidades = new List<Datos.Funcionalidad>();
            SqlDataReader data = command_reader("select * from INNERJOIN.funcionalidad");

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
            Decimal id_generado = command_insert("insert into INNERJOIN.rol values ('" + nombre_alta + "', 1); select SCOPE_IDENTITY()");
            if (id_generado < 0)
            {
                return -1;
            }
            else {
            foreach(Datos.Funcionalidad funcionalidad in funcionalidades){

                command = new SqlCommand("insert into INNERJOIN.rol_funcionalidad values(@id_rol,@funcionalidad_id)", this.connection);
                command.Parameters.AddWithValue("@id_rol", id_generado);
                command.Parameters.AddWithValue("@funcionalidad_id", funcionalidad.id);

                command.ExecuteNonQuery();
                

            }
            return 1;
            }


        }

		public SqlDataAdapter getTablaGrado()
		{
			SqlCommand sqlcommand = new SqlCommand();
			connection = new SqlConnection(ConnectionString);
            SqlCommand query = new SqlCommand("select * from INNERJOIN.grado", connection);

			SqlDataAdapter adapter = new SqlDataAdapter(query);

			return adapter;
		}

		public SqlDataAdapter getTablaRol()
        {
            SqlCommand sqlcommand = new SqlCommand();
            connection = new SqlConnection(ConnectionString);
            SqlCommand query = new SqlCommand("select * from INNERJOIN.rol", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(query);

            return adapter;
        }

        public SqlDataAdapter getRolByName(String nombre)
        {
            SqlCommand sqlcommand = new SqlCommand();
            connection = new SqlConnection(ConnectionString);
            SqlCommand query = new SqlCommand("select * from INNERJOIN.rol where rol_nombre LIKE '" + nombre + "'", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(query);

            return adapter;
        }

		public SqlDataAdapter getGradoByName(String nombre)
		{
			SqlCommand sqlcommand = new SqlCommand();
			connection = new SqlConnection(ConnectionString);
            SqlCommand query = new SqlCommand("select * from INNERJOIN.grado where grado_nombre LIKE '" + nombre + "'", connection);

			SqlDataAdapter adapter = new SqlDataAdapter(query);

			return adapter;
		}

        public Datos.Grado getGrado(String nombre)
        {
            Datos.Grado grado;
            SqlDataReader data = command_reader("select * from INNERJOIN.grado where grado_nombre LIKE '" + nombre+"'");
       
            data.Read();
            grado = new Datos.Grado(nombre, data.GetDecimal(0), data.GetDecimal(2));

            data.Close();
            return grado;
        }

		public List<Datos.Funcionalidad> getMissingFuncionalidades(Decimal rol_id)
        {
            List<Datos.Funcionalidad> funcionalidades = new List<Datos.Funcionalidad>();
            SqlDataReader data = command_reader("select distinct func_id,func_nombre from INNERJOIN.funcionalidad EXCEPT select distinct func_id,func_nombre from INNERJOIN.funcionalidad join INNERJOIN.rol_funcionalidad on func_id = id_funcionalidad where id_rol = " + rol_id);

            if (data.HasRows)
            {
                while (data.Read())
                {
                    Datos.Funcionalidad funcionalidad = new Datos.Funcionalidad(data.GetDecimal(0),data.GetString(1));
                    funcionalidades.Add(funcionalidad);
                }
            }

            data.Close();
            return funcionalidades;
        }

        public void quitarFuncionalidad(decimal rol_id, Datos.Funcionalidad funcionalidad_seleccionada)
        {
 
            connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand sqlcommand = new SqlCommand("delete from INNERJOIN.rol_funcionalidad where id_funcionalidad = " + funcionalidad_seleccionada.id + " and id_rol = " + rol_id, connection);

            sqlcommand.ExecuteNonQuery();

        }

        public void agregarFuncionalidad(decimal rol_id, Datos.Funcionalidad funcionalidad_seleccionada)
        {
         
            connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand sqlcommand = new SqlCommand("insert into INNERJOIN.rol_funcionalidad values (" + rol_id + "," + funcionalidad_seleccionada.id + ")", connection);

            sqlcommand.ExecuteNonQuery();

        }



        public Datos.Funcionalidad getFuncionalidadByName(object nombre)
        {
            String nombre_func = Convert.ToString(nombre);
            SqlDataReader data = command_reader("select * from INNERJOIN.funcionalidad where func_nombre LIKE '" + nombre_func + "'");
            data.Read();
            Datos.Funcionalidad funcionalidad = new Datos.Funcionalidad(data.GetDecimal(0), nombre_func);
            data.Close();
            return funcionalidad;
        }

        public int modificarRol(string nombre, int habilitado, Decimal rol_id)
        {
            int resultado = command_update("update INNERJOIN.rol set rol_nombre = '" + nombre + "', rol_baja_logica = " + habilitado + " where rol_id = " + rol_id);
            return resultado;
        }

		public int modificarGrado(string prioridad, Decimal comision, Decimal grado_id)
		{
            int resultado = command_update("update INNERJOIN.grado set grado_nombre = '" + prioridad + "', grado_comision = " + comision + " where grado_id = " + grado_id);
			return resultado;
		}

		public void eliminar_rol(decimal id)
        {
            object result = Execute_SP("INNERJOIN.sp_eliminar_rol", new { id_rol = id });
           if (result == null) {
               MessageBox.Show("Baja Correcta");
           }
        }

		public void eliminar_grado(decimal id)
		{
            SqlDataReader data = command_reader("select publicacion_id from INNERJOIN.publicacion where id_grado = " + id);
			
			if (data.HasRows)
			{
				MessageBox.Show("El grado no se puede borrar, está asociado a publicaciones");
				return;
			}
			data.Close();
            SqlCommand sqlcommand = new SqlCommand("delete from INNERJOIN.grado where grado_id = " + id, connection);
			sqlcommand.ExecuteNonQuery();
		}


		public int agregar_nuevo_rol_nuevo_grado(String prioridad_alta, Decimal comision_alta)
		{
			
			Decimal id_generado = command_insert("insert into INNERJOIN.grado values ('" + prioridad_alta + "', '" + comision_alta + "'); select SCOPE_IDENTITY()");
			if (id_generado < 0)
			{
				return -1;
			}
			return 1;

        }

        public void generar_publicacion(Datos.Publicacion publicacion)
        {
            SqlCommand command;
            
            object result = Execute_SP("INNERJOIN.sp_generar_publicacion", 
                new { descripcion = publicacion.descripcion,
                      rubro_text = publicacion.rubro,
                      grado_text = publicacion.grado.descripcion,
                      grado_comision = publicacion.grado.comision,
                      id_usuario = App.currentUser.user_id,
                      estado = publicacion.estado,
                      fecha_public = publicacion.fecha_publicacion,
                      fecha_evento = publicacion.fecha_espectaculo,
                      direccion = publicacion.direccion,
                      identity = 1
                     });

           
          

            Decimal id_publicacion = Convert.ToDecimal(result);
            foreach (Datos.Ubicacion ubicacion in publicacion.ubicaciones) {
                command = new SqlCommand("insert into INNERJOIN.ubicacion values(@id_publi,@fila,@asiento,@precio,@tipo_id,@numerada)", this.connection);
                command.Parameters.AddWithValue("@id_publi", id_publicacion);
                command.Parameters.AddWithValue("@fila", ubicacion.Fila);
                command.Parameters.AddWithValue("@asiento", ubicacion.Asiento);
                command.Parameters.AddWithValue("@precio", ubicacion.precio);
                command.Parameters.AddWithValue("@tipo_id", ubicacion.tipo);
                command.Parameters.AddWithValue("@numerada", ubicacion.numerada);

                command.ExecuteNonQuery();
            }

            if (result != null || Convert.ToInt32(result) > 0)
            {
                MessageBox.Show("Creacion Correcta");
            }
            else {
                MessageBox.Show("Creacion Incorrecta");
            }
        }

        public List<Datos.Rubro> getRubros()
        {
            List<Datos.Rubro> rubros = new List<Datos.Rubro>();

            SqlDataReader data = command_reader("select distinct rubro_id,rubro_descripcion from INNERJOIN.rubro");

            if (data.HasRows)
            {
                while (data.Read())
                {
                    Decimal id = data.GetDecimal(0);
                    String descripcion = data.GetString(1);
                    rubros.Add(new Datos.Rubro(id, descripcion));
                }
            }

            data.Close();
            return rubros;


        }

        public List<string> getTipoUbicacion()
        {
            List<String> tipos = new List<String>();

            SqlDataReader data = command_reader("select * from INNERJOIN.ubicacion_tipo");

            if (data.HasRows)
            {
                while (data.Read())
                {
                    
                    String descripcion = data.GetString(1);
                    tipos.Add(descripcion);
                }
            }

            data.Close();
            return tipos;
        }

        public List<Datos.Grado> getGrados()
        {
            List<Datos.Grado> grados = new List<Datos.Grado>();

            SqlDataReader data = command_reader("select distinct * from INNERJOIN.grado");

            if (data.HasRows)
            {
                while (data.Read())
                {
                    Decimal id = data.GetDecimal(0);
                    String nombre = data.GetString(1);
                    Decimal comision = data.GetDecimal(2);
                    grados.Add(new Datos.Grado(nombre,id,comision));
                }
            }

            data.Close();
            return grados;
        }

        public decimal getTipoUbicacion(string descripcion)
        {
            Decimal id;
            SqlDataReader data = command_reader("select * from INNERJOIN.ubicacion_tipo where descripcion LIKE '" + descripcion + "'");
            data.Read();
            id = data.GetDecimal(0);
            data.Close();
            return id;
        }

        public void agregar_nuevo_cliente(string nombre_usuario, string apellido_usuario, string tipo_dni, int numero_dni, string numero_cuil, string fecha_nacimiento, string num_telefono, string email_dir,string domicilio_calle, int domicilio_numero, int domicilio_piso, string domicilio_depto, string cod_post, string numero_tarjeta, string vencimiento_tarjeta)//,rol)
        {
            object result = Execute_SP("INNERJOIN.sp_alta_cliente", new
            {
                tipodni = tipo_dni,
                nrodni = numero_dni,
                cuil = numero_cuil,
                apellido = apellido_usuario,
                nombre = nombre_usuario,
                fechanac = fecha_nacimiento,
                email = email_dir,
                telefono = num_telefono,
                dom_calle = domicilio_calle,
                dom_numero = domicilio_numero,
                dom_piso = domicilio_piso,
                dom_depto = domicilio_depto,
                codpost = cod_post,
                num_tarjeta = numero_tarjeta,
                venc_tarjeta = vencimiento_tarjeta
            });
            if (result == null)
            {
                MessageBox.Show("Alta de cliente correcta");
            }

        }

        public SqlDataAdapter getTablaPublicaciones()
        {
            SqlCommand sqlcommand = new SqlCommand();
            connection = new SqlConnection(ConnectionString);
            SqlCommand query = new SqlCommand("select publicacion_id,id_espectaculo,rubro_descripcion,grado_nombre,usuario_username, publicacion_estado,publicacion_fecha_publicacion,publicacion_fecha_evento,publicacion_descripcion, publicacion_direccion from INNERJOIN.publicacion left outer join INNERJOIN.usuario on id_responsable = usuario_id left outer join INNERJOIN.rubro on id_rubro = rubro_id left outer join INNERJOIN.grado on id_grado = grado_id", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(query);

            return adapter;
        }

        public SqlDataAdapter getTablaPublicacionesFiltros(string query)
        {
            SqlCommand sqlcommand = new SqlCommand();
            connection = new SqlConnection(ConnectionString);
            SqlCommand queryCommand = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(queryCommand);

            return adapter;
        }


        public SqlDataAdapter getUbicacionByPublicacionID(decimal id_publicacion)
        {
            SqlCommand sqlcommand = new SqlCommand();
            connection = new SqlConnection(ConnectionString);
            SqlCommand query = new SqlCommand("select * from INNERJOIN.ubicacion where id_publicacion = " + id_publicacion, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(query);

            return adapter;
        }

        public void eliminar_ubicacion(decimal id)
        {
            connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand sqlcommand = new SqlCommand("delete from INNERJOIN.ubicacion where ubicacion_id = " + id, connection);

            sqlcommand.ExecuteNonQuery();
        }
    }
}



