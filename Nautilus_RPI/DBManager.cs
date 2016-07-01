using MySql.Data.MySqlClient;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Nautilus_RPI
{
    class DBManager
    {
        //VARIABLE DECLARATION
        private static MySqlConnection _conn;
        /**********************************************************************************************************************************************/
        private void Conector()
        {
            Iniciador();
        }

        private static void Iniciador()
        {
            //Assign the connection string
            //The connection string information is extracted from the
            //ConfigManager class
            string cadenaConeccion = ConfigManager.ConnString();
            _conn = new MySqlConnection(cadenaConeccion);
        }
        /**********************************************************************************************************************************************/
        //Connection Function
        private static bool Conectarse()
        {
            try
            {
                _conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                /* If the connection misses
                 * we handle the error with a catcher
                 * The most common errors are:
                 * 0: Can't connect to the server (Ip or no internet connection available)
                 * 1045: Invalid User or Password. */
                switch (ex.Number)
                {
                    //Server unreachable case
                    case 0:
                        MessageBox.Show("No se puede conectar al servidor. Contactar al administrador");
                        break;
                    //Bas username/password case
                    case 1045:
                        MessageBox.Show("Usuario/Contraseña invalidos, Corrija los datos de la conexion");
                        break;
                }
                return false;
            }
        }
        /**********************************************************************************************************************************************/
        //Disconnection Function
        private static bool Desconectarse()
        {
            try
            {
                _conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /**********************************************************************************************************************************************/
        //Insert Sentence Function
        //we make it boolean to check if the insertion was effective
        public static bool Insertar(string Query)
        {
            //We initiate the variables
            Iniciador();

            if (Conectarse() == true)
            {
                //Sql sentence execution
                MySqlCommand sqlInsert = new MySqlCommand(Query, _conn);
                sqlInsert.ExecuteNonQuery();
                Desconectarse();
                return true;
                //MessageBox.Show("Insertado con exito");
            }
            else
            {
                return false;
            }
        }
        /**********************************************************************************************************************************************/
        //Select Routine with DataTable for datagrids
        // Works for any datagrid inside the program
        //Takes any SELECT sentence.
        public static DataTable SelectForGrid(string query)
        {
            //Initiate variables
            Iniciador();
            // Return variable declaration
            //DataSet dataSet;
            MySqlDataAdapter mySqlDataAdapter;
            DataTable dataSet = new DataTable();
            //Initiate connection
            if (Conectarse() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter(query, _conn);
                mySqlDataAdapter.Fill(dataSet);
                mySqlDataAdapter.Dispose();
                Desconectarse();
                return dataSet;
            }
            return dataSet;
            //End of succesful routine          
        }
        /**********************************************************************************************************************************************/
        //This is a special Select Routine that handles 
        // Text fields
        //Takes a special SELECT sentence
        public static DataSet SelectForText(string query)
        {
            //Initiate Variables
            Iniciador();
            DataSet ds;
            if (Conectarse() == true)
            {
                ds = new DataSet();
                MySqlDataAdapter mySqlDataAdapter;
                mySqlDataAdapter = new MySqlDataAdapter(query, _conn);
                mySqlDataAdapter.Fill(ds);
                mySqlDataAdapter.Dispose();
                Desconectarse();
                return ds;
            }
            ds = null;
            return ds;
        }
        /**********************************************************************************************************************************************/
        // SELECT function for the modify user Grid
        public static List<string>[] Select(string query)
        {
            //Initiate variables
            Iniciador();
            //Create a List to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open Connection and Execute sentence
            if (Conectarse() == true)
            {
                //Create the command
                MySqlCommand cmd = new MySqlCommand(query, _conn);
                //Create a DataReader and execute the command
                MySqlDataReader lectorDatos = cmd.ExecuteReader();
                //Read the DataReader and populate the List
                while (lectorDatos.Read())
                {
                    list[0].Add(lectorDatos["Nombre"] + "");
                    list[1].Add(lectorDatos["Apellido Paterno"] + "");
                    list[2].Add(lectorDatos["Apellido Materno"] + "");
                }

                //Close the DataReader
                lectorDatos.Close();
                //Close Connection
                Desconectarse();
                //Return the result
                return list;
            }
            else
            {
                return list; //Return empty list
            }
        }
        /**********************************************************************************************************************************************/
        //Public Function for UPDATE sentence
        public static bool Actualizar(string query)
        {
            //Initialize variables
            Iniciador();

            //Connector and method
            if (Conectarse() == true)
            {
                //UPDATE execution
                MySqlCommand sqlUpdate = new MySqlCommand(query, _conn);
                sqlUpdate.ExecuteNonQuery();
                Desconectarse();
                //MessageBox.Show("Actualizado con exito");
                return true;
            }
            else
            {
                //MessageBox.Show("Hubo un problema con la actualizacion");
                return false;
            }
        }
        /**********************************************************************************************************************************************/
        //Public method for DELETE sentence
        public static void deleteSQL(string query)
        {
            //Start Variables
            Iniciador();

            //Connect and method
            if (Conectarse() == true)
            {
                //UPDATE execution
                MySqlCommand sqlUpdate = new MySqlCommand(query, _conn);
                sqlUpdate.ExecuteNonQuery();
                Desconectarse();
                MessageBox.Show("eliminado con exito");
            }
            else
            {
                MessageBox.Show("Hubo un problema con la eliminacion");
            }
            Desconectarse();
        }
        /**********************************************************************************************************************************************/
        //Public Method to test the connection
        public static bool testConn()
        {
            
            //Start Variables
            Iniciador();

         
            if (Conectarse() == true)
            {
                Desconectarse();
                return true;   
            }
            else
            {
                Desconectarse();
                return false;
            }

           
        }
        /**********************************************************************************************************************************************/
      

        /**********************************************************************************************************************************************/
        /* LOGIN FUNCTION*/
        public static bool LogOk(string _username, string _password)
        {
            //Variable that stores the result
            bool value = new bool();
            string sql = null;
            int count = new int();

            Iniciador();

            //routine that checks both fields and compares them in the db
            //checkPassword
            if (Conectarse() == true)
            {
                sql = @"SELECT COUNT(*) FROM usuarios where UserID='" +
 _username + "' AND Pass='" + _password + "';";
                MySqlCommand cmd = new MySqlCommand(sql, _conn);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    count = Convert.ToInt32(result);
                }
            }
            //Algorithm that validates if the row exists
            //and assigns the true to the value variable
            if (count > 0)
            {
                value = true;
                return value;
            }
            else
            {
                value = false;
                return value;
            }

        }

        //Function that retrieves Latitude and Longitude
        public static long coordinates(string query)
        {
            long value = new long();
            Iniciador();
            MySqlCommand cmd = new MySqlCommand(query, _conn);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                value = Convert.ToInt64(result);
            }
            else
            {
                value = 0;
            }

            return value;
        }

    }
}

