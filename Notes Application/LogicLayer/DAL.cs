using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicLayer
{
	public class DAL
	{
        private SqlConnection conn;
        private string serverName;
        private string databaseName;
        private string username;
        private string password;
        private string constr;

        public DAL(string serverName, string databaseName, string username, string password)
        {
            this.serverName = serverName;
            this.databaseName = databaseName;
            this.username = username;
            this.password = password;

        }

        void Connect()
        {
            constr = $"Data Source={serverName};Initial Catalog={databaseName};User ID={username};Password={password}";

            conn = new SqlConnection(constr);
            conn.Open();

        }

        void Disconnet()
        {
            conn.Close();
        }

        void Connect2()
        {

            // for the connection to
            // sql server database
            //SqlConnection conn;

            // Data Source is the name of the
            // server on which the database is stored.
            // The Initial Catalog is used to specify
            // the name of the database
            // The UserID and Password are the credentials
            // required to connect to the database.
            constr = $"Data Source={serverName};Initial Catalog={databaseName};User ID={username};Password={password}";

            conn = new SqlConnection(constr);

            // to open the connection
            conn.Open();

            Console.WriteLine("Connection Open!");

            // to close the connection
            conn.Close();
        }
    }
}
