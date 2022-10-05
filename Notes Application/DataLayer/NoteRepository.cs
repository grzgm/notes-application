using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DTOs;


namespace DataLayer
{
	public class NoteRepository
	{
        private SqlConnection conn;
        //private string serverName;
        //private string databaseName;
        //private string username;
        //private string password;
        private string constr;

        //public NoteRepository(string serverName, string databaseName, string username, string password)
        //{
        //    this.serverName = serverName;
        //    this.databaseName = databaseName;
        //    this.username = username;
        //    this.password = password;

        //}
        public NoteRepository()
        {
            //constr = $"Data Source={serverName};Initial Catalog={databaseName};User ID={username};Password={password}";
            // PC
            constr = "Data Source=GMALISZ\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";
            // LAPTOP
            //constr = "Data Source=DESKTOP-PCL70MC\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";
        }

        public void CreateNote(string title, string text)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;

            string sql = "INSERT INTO notes VALUES(1, @title, @text, @date, @editdate)";

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@title", Value = title });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@text", Value = text });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@date", Value = DateTime.Now });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@editdate", Value = DateTime.Now });

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public List<NoteDTO> ReadNotes()
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;
            SqlDataReader dreader;

            string sql = "SELECT Id,Title,[Text] FROM notes";

            cmd = new SqlCommand(sql, conn);

            List<NoteDTO> notesDTO = new List<NoteDTO>();

            try
            {
                dreader = cmd.ExecuteReader();

                while (dreader.Read())
                {
                    notesDTO.Add(new NoteDTO
                    {
                        UserId = 0,
                        Id = int.Parse(dreader.GetValue(0).ToString()),
                        Title = dreader.GetValue(1).ToString().Trim(),
                        Text = dreader.GetValue(2).ToString().Trim()
                    }); ;
                }

                dreader.Close();
            }
            catch (Exception ex)
            {
                return new List<NoteDTO>();
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return notesDTO;
        }

        public void UpdateNote( int id, string title, string text)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;

            string sql = "UPDATE notes set Title=@title, [Text]=@text, EditDate=@editdate WHERE Id= @id";

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@id", Value = id });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@title", Value = title });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@text", Value = text });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@editdate", Value = DateTime.Now });

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
        public void DeleteNote(int id)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;

            string sql = "DELETE FROM notes WHERE Id=@id";

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@id", Value = id });

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
    }
}
