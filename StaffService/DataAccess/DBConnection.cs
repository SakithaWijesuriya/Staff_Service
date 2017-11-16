using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace StaffService.DataAccess
{
    class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;


        public DBConnection()
        {
            Initialize();
        }
        private void Initialize()
        {
            server = ConfigurationManager.AppSettings["server"];
            database = ConfigurationManager.AppSettings["database"];
            uid = ConfigurationManager.AppSettings["uid"];
            password = ConfigurationManager.AppSettings["password"];
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
               
                switch (ex.Number)
                {
                    case 0:
                       
                        break;

                    case 1045:
                     
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Inserts(string sqlquery)
        {
            string query = sqlquery;//"INSERT INTO addcustomer (customername, age) VALUES('John Smith', '33')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
            
        public DataTable Select(string command)
        {
           
            DataTable dt = new DataTable();
            if (this.OpenConnection() == true)
            {
               
                MySqlCommand cmd = new MySqlCommand(command, connection);
                cmd.ExecuteNonQuery();
              
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
               
                da.Fill(dt);
                da.Dispose();
                this.CloseConnection();
                return dt;

            }

            return dt;
            
        }

    }
}
