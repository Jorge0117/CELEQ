using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CELEQ
{
    class AccesobdUsuarios
    {
        string conexion = "Data Source=10.90.85.116;User ID=Admin; Password=Adminsql$celeq; Initial Catalog=Usuarios; Integrated Security=false";

        public AccesobdUsuarios()
        {

        }

        /*Método para llamar al procedimiento almacenado que permite agregar un nuevo usuario 
         Recibe: el usuario y la contraseña del nuevo usuario así como la cédula del estudiante a quién se asocia ese usuario
         Modifica: Agrega en la base de datos un nuevo usuario
         Retorna: 1 si se pudo guardar el nuevo usuario, un número diferente a cero que corresponde al número de error
         si no se pudo insertar*/
        public int agregarUsuario(string usuario, string password, string correo, string categoria)
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
            SqlDataReader correo = ejecutarConsulta("select categoria from Usuarios where nombreUsuario = '" + usuario + "'");
            correo.Read();
            return correo[0].ToString();
        }

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

        public int modificarUsuario(string usuario, string password, string correo, string categoria)
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

    }
}
