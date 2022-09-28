using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer
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
            //constr = $"Data Source={serverName};Initial Catalog={databaseName};User ID={username};Password={password}";
            constr = "Data Source=GMALISZ\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";

            conn = new SqlConnection(constr);
            conn.Open();

        }

        public void Disconnet()
        {
            conn.Close();
        }

        public void CreateNote()
        {
            SqlCommand cmd;
            SqlDataAdapter adap = new SqlDataAdapter();

            string sql = "insert into demo values(3, 'Python')";

            cmd = new SqlCommand(sql, conn);

            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();

            cmd.Dispose();
        }

        public List<List<string>> ReadNotes()
        {
            SqlCommand cmd;
            SqlDataReader dreader;

            string sql = "SELECT Id,Title,[Text] FROM notes";

            cmd = new SqlCommand(sql, conn);

            dreader = cmd.ExecuteReader();

            List<List<string>> output = new List<List<string>>();

            while (dreader.Read())
            {
                output.Add(new List<string> { dreader.GetValue(0).ToString(), dreader.GetValue(1).ToString(), dreader.GetValue(2).ToString() });
            }

            dreader.Close();
            cmd.Dispose();
            return output;
        }

        public void UpdateNote( int id, string title, string text)
        {
            SqlCommand cmd;
            SqlDataAdapter adap = new SqlDataAdapter();

            string sql = $"UPDATE notes set Title='{title}',[Text]='{text}' WHERE Id={id}";

            cmd = new SqlCommand(sql, conn);

            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();

            cmd.Dispose();
        }
        public void Delete()
        {
            SqlCommand cmd;
            SqlDataAdapter adap = new SqlDataAdapter();

            string sql = "delete from demo where articleID=3";

            cmd = new SqlCommand(sql, conn);

            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();

            cmd.Dispose();
        }
    }
}
