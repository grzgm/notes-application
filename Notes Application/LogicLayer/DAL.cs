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
        public DAL()
        {
        }

        public void Connect()
        {
            constr = "Data Source=GMALISZ\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";

            conn = new SqlConnection(constr);
            conn.Open();

        }

        public void Disconnet()
        {
            conn.Close();
        }

        public List<List<string>> ReadNotes()
        {
            SqlCommand cmd;
            SqlDataReader dreader;

            string sql;
            sql = "SELECT Id,Title,[Text] FROM notes";

            cmd = new SqlCommand(sql, conn);

            dreader = cmd.ExecuteReader();

            List<List<string>> output = new List<List<string>>();

            while (dreader.Read())
            {
                output.Add(new List<string> { dreader.GetValue(0).ToString(), dreader.GetValue(1).ToString(), dreader.GetValue(2).ToString() });
            }

            // to close all the objects
            dreader.Close();
            cmd.Dispose();
            return output;
        }

        public void UpdateNote( int id, string title, string text)
        {
            SqlCommand cmd;
            SqlDataAdapter adap = new SqlDataAdapter();

            string sql;
            sql = $"UPDATE notes set Title='{title}',[Text]='{text}' WHERE Id={id}";

            cmd = new SqlCommand(sql, conn);

            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();

            cmd.Dispose();
        }
        public void Update()
        {
            string constr;
            SqlConnection conn;
            constr = "Data Source=GMALISZ\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";

            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;
            SqlDataAdapter adap = new SqlDataAdapter();

            string sql = "";
            sql = "UPDATE notes set Title='test2',[Text]='test2' WHERE Id=2";

            cmd = new SqlCommand(sql, conn);

            adap.InsertCommand = new SqlCommand(sql, conn);

            adap.InsertCommand.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
        }

        public void Connect2()
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
