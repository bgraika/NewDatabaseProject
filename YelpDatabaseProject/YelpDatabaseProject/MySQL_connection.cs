using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace YelpDatabaseProject
{
    class MySQL_connection
    {
        public MySqlConnection connect;

        public MySQL_connection()
        {
            try
            {
                Initialize();
            }
            catch (MySqlException ex)
            {

            }
        }

        //builds the connectionString that allows access to the database
        private void Initialize()
        {
            string server;
            string database;
            string uid;
            string password;
            server = "localhost";
            database = "project";
            uid = "root";
            password = "root";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connect = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connect.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 0)
                {

                }
                else if (ex.Number == 1045)
                {
                    return false;
                }

            }
            return false;
        }

        public bool CloseConnection()
        {
            try
            {
                connect.Close();
                return true;
            }
            catch (MySqlException ex)
            {

            }
            return false;
        }

        //selection string builder thats takes in a list of column names and a search string
        //returns a list of a list where each each index has items associated with one column
        public List<List<String>> SQLSELECTExec(string querySTR, List<string> column_names)
        {
            List<List<String>> qResult = new List<List<String>>();
            int i = 0;
            //if (this.OpenConnection() == true)
            //{
                MySqlCommand cmd = new MySqlCommand(querySTR, connect);
            cmd.CommandTimeout = 1000;
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    i = 0;//variable that switches qResult to hold a different column
                    foreach (string column_name in column_names)
                    {
                        //if a new column needs to be added
                        if (qResult.Count <= i)
                        {
                            List<string> sublist = new List<string>();
                            qResult.Add(sublist);
                        }
                    //add item to its respective column
                    try
                    {
                        qResult[i].Add(dataReader.GetString(column_name));
                    }
                    catch
                    {

                    }
                        i++;
                    }
                }
                dataReader.Close();

                //this.CloseConnection();
            //}
            return qResult;
        } //eo SQLSELECTExec

  
    }
}
