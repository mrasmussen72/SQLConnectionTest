using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLConnStrTester
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = String.Empty;
            int i = 0;
            foreach(string arg in args)
            {
                switch(arg.ToLower())
                {
                    case "-connectionstring":
                        if (args.Length >= (i + 1)) { connectionString = args[i+1]; Console.Write(connectionString); }
                        break;

                }
                i++;
            }

            try
            {
                
                var conn = new SqlConnection();
                conn.ConnectionString = connectionString;
                //"Data Source=YourServerName;" +
                //"Initial Catalog=YourDataBaseName;" +
                //"User id=YourDBUserName;" +
                //"Password=YourDBSecret;";
                conn.Open();
                Console.WriteLine("Connection state = " + conn.State.ToString());
                Console.WriteLine("\n Connection Successful!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Failed to connect to the database, message:  " + ex.Message);
            }
        }
    }
}
