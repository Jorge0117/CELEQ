using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Configuration;
// Namespace de acceso a base de datos
using System.Data;
using System.Data.SqlClient;

namespace CELEQ
{
    class AccesoBaseDatos
    {
        /*En Initial Catalog se agrega la base de datos propia. Intregated Security es para utilizar Windows Authentication*/
        //String conexion = "Data Source=10.1.4.55; Initial Catalog=DB_RRAM; Integrated Security=SSPI";

        /*En Initial Catalog se agrega la base de datos propia. Intregated Security = false es para utilizar SQL SERVER Authentication*/
        string conexion = "Data Source=10.90.85.116;User ID=Admin; Password=Adminsql$celeq; Initial Catalog=Regencia; Integrated Security=false";
        
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
            string correoSol, string unidad, string observacion)
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

    }
}
