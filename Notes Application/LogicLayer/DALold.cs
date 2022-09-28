using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DTOs;


namespace LogicLayer
{
	public class DALold
	{
        private SqlConnection conn;
        private string serverName;
        private string databaseName;
        private string username;
        private string password;
        private string constr;

        public DALold(string serverName, string databaseName, string username, string password)
        {
            this.serverName = serverName;
            this.databaseName = databaseName;
            this.username = username;
            this.password = password;

        }
        public DALold()
        {
        }

        public void Connect()
        {
            //constr = $"Data Source={serverName};Initial Catalog={databaseName};User ID={username};Password={password}";
            constr = "Data Source=GMALISZ\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";
            constr = "Data Source=DESKTOP-PCL70MC\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";

            conn = new SqlConnection(constr);
            conn.Open();

        }

        public void Disconnet()
        {
            conn.Close();
        }

        public void CreateNote(string title, string text)
        {
            SqlCommand cmd;

            string sql = "INSERT INTO notes VALUES(@title, @text)";

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@title", Value = title });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@text", Value = text });

            cmd.ExecuteNonQuery();

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
                output.Add(new List<string> { dreader.GetValue(0).ToString(), dreader.GetValue(1).ToString().Trim(), dreader.GetValue(2).ToString().Trim()});
            }

            dreader.Close();
            cmd.Dispose();
            return output;
        }

        public void UpdateNote( int id, string title, string text)
        {
            SqlCommand cmd;
            //SqlDataAdapter adap = new SqlDataAdapter();

            string sql = "UPDATE notes set Title= @title,[Text]= @text WHERE Id= @id";

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@id", Value = id });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@title", Value = title });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@text", Value = text });

            //adap.InsertCommand = new SqlCommand(sql, conn);
            //adap.InsertCommand.ExecuteNonQuery();

            cmd.ExecuteNonQuery();

            cmd.Dispose();
        }
        public void Delete(int id)
        {
            SqlCommand cmd;

            string sql = "DELETE FROM notes WHERE @id";

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@id", Value = id });

            cmd.ExecuteNonQuery();

            cmd.Dispose();
        }
    }
}
