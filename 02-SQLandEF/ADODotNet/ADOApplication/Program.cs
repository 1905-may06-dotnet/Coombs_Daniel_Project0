using System;
using System.Data;
using System.Data.SqlClient;

namespace ADOApplication
{
    //Comments
    //Hotekeys VS2019: Ctrl+K+C -> comment, Ctrl+K+U -> uncomment, Ctrl+K+D ->indentation
    class Program
    {
        static void Main(string[] args)
        {
            //endpoint
            string conStr = "Data Source=utadbserverdc.database.windows.net;Initial Catalog=AdventureWorks;Persist Security Info=True;User ID=danielcoombs005;Password=32AlplA23"; //connection string

            //command
            string query = "select * from SalesLT.Customer";

            //1. Make a Sql connection
            SqlConnection con;
            con = Connected(conStr, query);
        }

        private static SqlConnection Connected(string conStr, string query)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open(); //because unmanaged
            //2. Fire query
            SqlCommand cmd;
            cmd = new SqlCommand(query, con); //command query will run using connection option of con
            //3. Execute query and get results
            SqlDataReader dr;

            //cmd.ExecuteNonQuery(); //used for insert, update, delete commands
            dr = cmd.ExecuteReader(); //used for select commands
            if (dr.HasRows)
            {
                //Read() will pull 1 record at a time - so it cannot backtrack, that's why we should read/store the previous records
                while (dr.Read())
                {
                    //pulls first column of 
                    Console.WriteLine($"ID: {dr[0]} Name: {dr["FirstName"]} {dr["MiddleName"]} {dr["LastName"]}");
                }
            }
            con.Close(); //because unmanaged
            return con;
        }

        private static void Disconnected(string conStr, string query)
        {
            using (con = new SqlConnection(conStr))
            {

            }
        }
    }
}
