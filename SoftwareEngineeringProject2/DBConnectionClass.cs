using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace SoftwareEngineeringProject2
{
    class DBConnectionClass
    {
            
        //private object of the class itself
        private static DBConnectionClass _instance;

        //connection string
        private string connStr;

        //connection to the DB
        private SqlConnection connToDB;

        /// <summary>
        /// constructor
        /// </summary>
        private DBConnectionClass()
        {
            connStr = Properties.Settings.Default.DBConnectionString;

        }

        ///
        ///methods
        ///
        /**
         * a static method that creates an unique object of the class itself
         */
        public static DBConnectionClass getInstanceOfDBConnection()
        {
            // create the object only if it doesn't exist  
            if (_instance == null)
                _instance = new DBConnectionClass();
            return _instance;
        }

        /**
         * Returns a data set built based on the query sent as parameter
         */
      


        /**
         * Method that saves data into the database
         */

        public void LoginDB( string usernametxt, string password)
        {
            using (SqlConnection connToDB = new SqlConnection(connStr))
            {
                //open connection
                connToDB.Open();
                String querry = "SELECT * FROM Idea_Creator WHERE Username = '" + usernametxt + "'AND Password = '" + password + "'";

                SqlDataAdapter sqlcommand = new SqlDataAdapter(querry, connToDB);

                //set the sqlCommand's properties
                DataTable dataTable = new DataTable();
                sqlcommand.Fill(dataTable);
               

                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successful");
                    
                    
                }
                else
                {
                    MessageBox.Show("Invallid ");
                }


                connToDB.Close();
            }

        }



    }



}

