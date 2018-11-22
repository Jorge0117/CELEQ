using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Configuration;
// Namespace de acceso a base de datos
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CELEQ
{
    class AccesoBaseDatos
    {
        /*En Initial Catalog se agrega la base de datos propia. Intregated Security es para utilizar Windows Authentication*/
        //String conexion = "Data Source=10.1.4.55; Initial Catalog=DB_RRAM; Integrated Security=SSPI";

        /*En Initial Catalog se agrega la base de datos propia. Intregated Security = false es para utilizar SQL SERVER Authentication*/
        string conexion = "Data Source=10.90.85.116;User ID=Admin; Password=Adminsql$celeq; Initial Catalog=CELEQ; Integrated Security=false";
        
        /**
         * Constructor de la clase
         */
        public AccesoBaseDatos(){
        }

        /**
         * Permite ejecutar una consulta SQL, los datos son devueltos en un SqlDataReader
         * Recibe: La consulta sql a ejecutar
         * Modifica: Obtiene las tuplas que corresponden a la consulta recibida
         * Retorna: El datareader con los resultados de la ejecución de la consulta
         */
        public SqlDataReader ejecutarConsulta(String consulta)
        {
            //Prepara una nueva conexión a la bd y la abre
            SqlConnection sqlConnection = new SqlConnection(conexion);

            sqlConnection.Open();

            SqlDataReader datos = null;
            SqlCommand comando = null;

            try
            {
                //Ejecuta la consulta sql recibida por parámetro y la carga en un datareader
                comando = new SqlCommand(consulta, sqlConnection);
                datos = comando.ExecuteReader();
            }
            catch (SqlException ex)
            {

            }
            return datos;
        }

        /**
         * Permite ejecutar una consulta SQL, los datos son devueltos en un DataTable
         * * Recibe: La consulta sql a ejecutar
         * Modifica: Obtiene las tuplas que corresponden a la consulta recibida
         * Retorna: El datatable con los resultados de la ejecución de la consulta
         */
        public DataTable ejecutarConsultaTabla(String consulta)
        {
            //Prepara una nueva conexión a la bd y la abre
            SqlConnection sqlConnection = new SqlConnection(conexion);

            sqlConnection.Open();

            SqlCommand comando = new SqlCommand(consulta, sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();

            dataAdapter.Fill(table);
			
			return table;
        }


        /*Método para ejecutar un insert, update o delete 
         Recibe: la sentencia sql a ejecutar
         Modifica: realiza el cambio en la base de datos de acuerdo al tipo de sentencia sql
         Retorna: el tipo de error que generó la consulta o cero si la ejecución fue exitosa*/
        public int actualizarDatos(String consulta)
        {
            int error = 0;

            //Prepara una nueva conexión a la bd y la abre
            SqlConnection sqlConnection = new SqlConnection(conexion);
            sqlConnection.Open();

            SqlCommand cons = new SqlCommand(consulta, sqlConnection);

            try
            {
                //Ejecuta la consulta sql recibida por parámetro
                cons.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                error = e.Number;
                Debug.WriteLine("Error: " + error);
            }

            finally
            {
                sqlConnection.Close();
            }

            return error;
        }

        public float obtenerCantidadReactivos(string nombre, string pureza)
        {
            SqlDataReader cantidad = ejecutarConsulta("select cantidad from reactivo where nombre = '" + nombre +
                "' and pureza = '" + pureza + "'");
            cantidad.Read();
            return (float)cantidad.GetDouble(0);
        }

        public int obtenerCantidadcristaleria(string nombre, string material, string capacidad)
        {
            SqlDataReader cantidad = ejecutarConsulta("select cantidad from cristaleria where nombre = '" + nombre +
                "' and material = '" + material + "' and capacidad = '"+ capacidad +"'");
            cantidad.Read();
            return cantidad.GetInt32(0);
        }

        /* --------------------------------------------------
         * Usuarios
         * --------------------------------------------------*/

        /*Método para llamar al procedimiento almacenado que permite agregar un nuevo usuario 
                 Recibe: el usuario y la contraseña del nuevo usuario así como la cédula del estudiante a quién se asocia ese usuario
                 Modifica: Agrega en la base de datos un nuevo usuario
                 Retorna: 1 si se pudo guardar el nuevo usuario, un número diferente a cero que corresponde al número de error
                 si no se pudo insertar*/
        public int agregarUsuario(string usuario, string password, string correo, string categoria, string unidad, string nombre, string apellido1, string apellido2)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                /*El sqlCommand recibe como primer parámetro el nombre del procedimiento almacenado, 
                 * de segundo parámetro recibe el sqlConnection
                */
                using (SqlCommand cmd = new SqlCommand("agregarUsuario", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@pLogin", SqlDbType.VarChar).Value = usuario;
                        cmd.Parameters.Add("@pPassword", SqlDbType.VarChar).Value = password;
                        cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = correo;
                        cmd.Parameters.Add("@categoria", SqlDbType.VarChar).Value = categoria;
                        cmd.Parameters.Add("@unidad", SqlDbType.VarChar).Value = unidad;
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                        cmd.Parameters.Add("@apellido1", SqlDbType.VarChar).Value = apellido1;
                        cmd.Parameters.Add("@apellido2", SqlDbType.VarChar).Value = apellido2;


                        //se prepara el parámetro de retorno del procedimiento almacenado
                        cmd.Parameters.Add("@estado", SqlDbType.Bit).Direction = ParameterDirection.Output;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        /*Se convierte en un valor entero lo que se devuelve el procedimiento*/
                        return Convert.ToInt32(cmd.Parameters["@estado"].Value);

                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }
        }

        /*Método para llamar al procedimiento almacenado para comprobar que un usuario está en la base de datos
         Recibe: El usuario y contraseña que se desea verificar que está en la base de datos
         Modifica: Busca el usuario con esa contraseña en la base de datos
         Retorna: true si está en la base de datos, false sino*/
        public bool login(string usuario, string password)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                /*El sqlCommand recibe como primer parámetro el nombre del procedimiento almacenado, 
                 * de segundo parámetro recibe el sqlConnection
                */
                using (SqlCommand cmd = new SqlCommand("Login", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@pLoginName", SqlDbType.VarChar).Value = usuario;
                        cmd.Parameters.Add("@pPassword", SqlDbType.VarChar).Value = password;

                        //se prepara el parámetro de retorno del procedimiento almacenado
                        cmd.Parameters.Add("@isInDB", SqlDbType.Bit).Direction = ParameterDirection.Output;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        /*Se convierte en un valor entero lo que se devuelve el procedimiento*/
                        int value = Convert.ToInt32(cmd.Parameters["@isInDB"].Value);

                        /*Si el procedimiento devuelve 1 es que si se encuentra en la BD*/
                        if (value == 1)
                        {
                            return true;
                        }

                        /*Si devuelve 0 es que no se encuentra en la BD*/
                        else
                        {
                            return false;
                        }

                    }
                    catch (SqlException ex)
                    {
                        return false;
                    }
                }
            }

        }

        public string getCorreo(string usuario)
        {
            SqlDataReader correo = ejecutarConsulta("select correo from Usuarios where nombreUsuario = '" + usuario + "'");
            correo.Read();
            return correo[0].ToString();
        }

        public string getCategoria(string usuario)
        {
            SqlDataReader categoria = ejecutarConsulta("select categoria from Usuarios where nombreUsuario = '" + usuario + "'");
            categoria.Read();
            return categoria[0].ToString();
        }

        public string getUnidad(string usuario)
        {
            SqlDataReader unidad = ejecutarConsulta("select unidad from Usuarios where nombreUsuario = '" + usuario + "'");
            unidad.Read();
            return unidad[0].ToString();
        }

        public int modificarUsuario(string usuario, string password, string correo, string categoria, string unidad, string nombre, string apellido1, string apellido2)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                /*El sqlCommand recibe como primer parámetro el nombre del procedimiento almacenado, 
                 * de segundo parámetro recibe el sqlConnection
                */
                using (SqlCommand cmd = new SqlCommand("modificarUsuario", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
                        cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = correo;
                        cmd.Parameters.Add("@categoria", SqlDbType.VarChar).Value = categoria;
                        cmd.Parameters.Add("@unidad", SqlDbType.VarChar).Value = unidad;
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                        cmd.Parameters.Add("@apellido1", SqlDbType.VarChar).Value = apellido1;
                        cmd.Parameters.Add("@apellido2", SqlDbType.VarChar).Value = apellido2;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }
            return error;
        }

        /*---------------------------------------------------
         * Métodos almacenados
         * -------------------------------------------------*/

        public int agregarReactivo(string nombre, string pureza, float cantidad, string estado, string estante)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("agregarReactivo", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
                        cmd.Parameters.Add("@Pureza", SqlDbType.VarChar).Value = pureza;
                        cmd.Parameters.Add("@Cantidad", SqlDbType.Float).Value = cantidad;
                        cmd.Parameters.Add("@Estado", SqlDbType.VarChar).Value = estado;
                        cmd.Parameters.Add("@Estante", SqlDbType.VarChar).Value = estante;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                        return 1;
                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }
        }

        public int agregarCristaleria(string nombre, string material, string capacidad, int cantidad)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("agregarCristaleria", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
                        cmd.Parameters.Add("@Material", SqlDbType.VarChar).Value = material;
                        cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = cantidad;
                        cmd.Parameters.Add("@Capacidad", SqlDbType.VarChar).Value = capacidad;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                        return 1;
                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }
        }

        public int modificarReactivo(string nombreNuevo, string purezaNueva, float cantidad, string estado, string estante,
            string nombre, string pureza)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ModificarReactivo", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
                        cmd.Parameters.Add("@Pureza", SqlDbType.VarChar).Value = pureza;
                        cmd.Parameters.Add("@NombreNuevo", SqlDbType.VarChar).Value = nombreNuevo;
                        cmd.Parameters.Add("@PurezaNueva", SqlDbType.VarChar).Value = purezaNueva;
                        cmd.Parameters.Add("@Cantidad", SqlDbType.Float).Value = cantidad;
                        cmd.Parameters.Add("@Estado", SqlDbType.VarChar).Value = estado;
                        cmd.Parameters.Add("@Estante", SqlDbType.VarChar).Value = estante;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                        return 1;
                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }
        }

        public int modificarCristaleria(string nombreNuevo, string materialNuevo, string capacidadNueva, int cantidad,
            string nombre, string material, string capacidad)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("modificarCristaleria", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
                        cmd.Parameters.Add("@Material", SqlDbType.VarChar).Value = material;
                        cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = cantidad;
                        cmd.Parameters.Add("@NombreNuevo", SqlDbType.VarChar).Value = nombreNuevo;
                        cmd.Parameters.Add("@MaterialNuevo", SqlDbType.VarChar).Value = materialNuevo;
                        cmd.Parameters.Add("@CapacidadNueva", SqlDbType.VarChar).Value = capacidadNueva;
                        cmd.Parameters.Add("@Capacidad", SqlDbType.VarChar).Value = capacidad;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                        return 1;
                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }
        }


        public string obtenerUltimoIdSolicitud()
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                /*El sqlCommand recibe como primer parámetro el nombre del procedimiento almacenado, 
                 * de segundo parámetro recibe el sqlConnection
                */
                using (SqlCommand cmd = new SqlCommand("ultimoAgregado", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //se prepara el parámetro de retorno del procedimiento almacenado
                        cmd.Parameters.Add("@idSolicitud", SqlDbType.VarChar, 130).Direction = ParameterDirection.Output;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();

                        /*Se convierte en un valor entero lo que se devuelve el procedimiento*/
                        string value = Convert.ToString(cmd.Parameters["@idSolicitud"].Value);

                        /*Si el procedimiento devuelve 1 es que si se encuentra en la BD*/
                        if (value == "-1")
                        {
                            return "0000";
                        }

                        /*Si devuelve 0 es que no se encuentra en la BD*/
                        else
                        {
                            return value;
                        }

                    }
                    catch (SqlException ex)
                    {
                        return "Error generando el numero de solicitud, error: " + ex.Number;
                    }
                }
            }
        }

        public int agregarSolicitud(string idSolicitud, string fechaSol, string nombreSol, string nombreEnc,
            string correoSol, string unidad, string observacion, string usuario)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("agregarSolicitud", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = idSolicitud;
                        cmd.Parameters.Add("@FechSol", SqlDbType.Date).Value = fechaSol;
                        cmd.Parameters.Add("@nombreSol", SqlDbType.VarChar).Value = nombreSol;
                        cmd.Parameters.Add("@nombreEnc", SqlDbType.VarChar).Value = nombreEnc;
                        cmd.Parameters.Add("@correoSol", SqlDbType.VarChar).Value = correoSol;
                        cmd.Parameters.Add("@Unidad", SqlDbType.VarChar).Value = unidad;
                        cmd.Parameters.Add("@Observacion", SqlDbType.VarChar).Value = observacion;
                        cmd.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                        return 1;
                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }
        }

        public int agregarSolicitudReactivo(string idSolicitud, string reactivo, string pureza, float cantidad)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("agregarSolicitudReactivo", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@IdSolicitud", SqlDbType.VarChar).Value = idSolicitud;
                        cmd.Parameters.Add("@Reactivo", SqlDbType.VarChar).Value = reactivo;
                        cmd.Parameters.Add("@Pureza", SqlDbType.VarChar).Value = pureza;
                        cmd.Parameters.Add("@Cantidad", SqlDbType.Float).Value = cantidad;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                        return 1;
                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }
        }

        public int agregarSolicitudCristaleria(string idSolicitud, string cristaleria, string material, string capacidad, int cantidad)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("agregarSolicitudCristaleria", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@IdSolicitud", SqlDbType.VarChar).Value = idSolicitud;
                        cmd.Parameters.Add("@Cristaleria", SqlDbType.VarChar).Value = cristaleria;
                        cmd.Parameters.Add("@Material", SqlDbType.VarChar).Value = material;
                        cmd.Parameters.Add("@Capacidad", SqlDbType.VarChar).Value = capacidad;
                        cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = cantidad;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                        return 1;
                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }
        }

        public int denegarReactivo(string idSolicitud, string reactivo, string pureza)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("denegarReactivo", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@IdSolicitud", SqlDbType.VarChar).Value = idSolicitud;
                        cmd.Parameters.Add("@Reactivo", SqlDbType.VarChar).Value = reactivo;
                        cmd.Parameters.Add("@Pureza", SqlDbType.VarChar).Value = pureza;
                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                        return 1;
                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }
        }

        public int denegarCristaleria(string idSolicitud, string cristaleria, string material, string capacidad)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("denegarCristaleria", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@IdSolicitud", SqlDbType.VarChar).Value = idSolicitud;
                        cmd.Parameters.Add("@Cristaleria", SqlDbType.VarChar).Value = cristaleria;
                        cmd.Parameters.Add("@Material", SqlDbType.VarChar).Value = material;
                        cmd.Parameters.Add("@Capacidad", SqlDbType.VarChar).Value = capacidad;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                        return 1;
                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }
        }

        //---------------------------------------------------------------------------------------------
        //-----------------------------------------Mantenimiento---------------------------------------
        //---------------------------------------------------------------------------------------------

        public int agregarSolicitudMantenimiento(string idSolicitud, string fecha, string nombreSolicitante, 
            string telefono, string contactoAdicional, string urgencia, string areaTrabajo, string lugarTrabajo, string descripcion, string usuario)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("CrearSolicitudMantenimiento", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = idSolicitud;
                        cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombreSolicitante;
                        cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = telefono;
                        cmd.Parameters.Add("@contactoAdicional", SqlDbType.VarChar).Value = contactoAdicional;
                        cmd.Parameters.Add("@urgencia", SqlDbType.VarChar).Value = urgencia;
                        cmd.Parameters.Add("@areaTrabajo", SqlDbType.VarChar).Value = areaTrabajo;
                        cmd.Parameters.Add("@lugarTrabajo", SqlDbType.VarChar).Value = lugarTrabajo;
                        cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion;
                        cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;


                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                        return 1;
                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }
        }

        public string ultimaSolicitudMantenimiento(string areaTrabajo)
        {
            SqlDataReader consecutivo = ejecutarConsulta("select id from SolicitudMantenimiento where areaTrabajo = '" + areaTrabajo + "' and ultimoAgregado = 1");
            if (consecutivo.Read())
            {
                return consecutivo[0].ToString();
            }
            else
            {
                return null;
            }
        }

        public int aprobarSolicitudMantenimiento(string idSolicitud, string fecha, string personaAsignada, string observaciones)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("AprobarSolicitudMantenimiento", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = idSolicitud;
                        cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;
                        cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = personaAsignada;
                        cmd.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = observaciones;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                        return 1;
                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }
        }

        public int rechazarSolicitudMantenimiento(string idSolicitud, string motivo)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("RechazarSolicitudMantenimiento", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = idSolicitud;
                        cmd.Parameters.Add("@motivo", SqlDbType.VarChar).Value = motivo;

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                        return 1;
                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }
        }

        public int analizarSolicitudMantenimiento(string idSolicitud, string insumo, string costo, string observaciones, FileStream fs, string nombreArch)
        {
            int error = 0;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("analizarSolicitud", con))
                {
                    try
                    {
                        byte[] binaryfile = null;
                        if (nombreArch != null)
                        {
                            BinaryFormatter bf = new BinaryFormatter();
                            using (MemoryStream ms = new MemoryStream())
                            {
                                fs.CopyTo(ms);
                                binaryfile = ms.ToArray();
                            }

                            cmd.Parameters.Add("@archivo", SqlDbType.VarBinary).Value = binaryfile;
                            cmd.Parameters.Add("@nombreArchivo", SqlDbType.VarChar).Value = nombreArch;

                        }
                        else
                        {
                            cmd.Parameters.Add("@archivo", SqlDbType.VarBinary).Value = DBNull.Value;
                            cmd.Parameters.Add("@nombreArchivo", SqlDbType.VarChar).Value = DBNull.Value;
                        }
                        
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Se preparan los parámetros que recibe el procedimiento almacenado
                        cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = idSolicitud;
                        cmd.Parameters.Add("@insumos", SqlDbType.VarChar).Value = insumo;
                        cmd.Parameters.Add("@costo", SqlDbType.VarChar).Value = costo;
                        cmd.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = observaciones;
                        
                        

                        /*Se abre la conexión*/
                        con.Open();

                        //Se ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                        return 1;
                    }
                    catch (SqlException ex)
                    {
                        /*Se capta el número de error si no se pudo insertar*/
                        error = ex.Number;
                        return error;
                    }
                }
            }
        }


        public byte[] getDocument(string documentId)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            using (SqlCommand cm = cn.CreateCommand())
            {
                cm.CommandText = @"
            SELECT documento
            FROM   DocumentosMantenimiento
            WHERE  id = @Id";
                cm.Parameters.AddWithValue("@Id", documentId);
                cn.Open();
                return cm.ExecuteScalar() as byte[];
            }
        }




    }
}
