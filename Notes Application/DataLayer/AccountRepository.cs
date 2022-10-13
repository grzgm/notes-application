﻿using DataLayer.DTOs;
using System.Data.SqlClient;
using System.Security.Principal;

namespace DataLayer
{
    public class AccountRepository
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
        public AccountRepository()
        {
            //constr = $"Data Source={serverName};Initial Catalog={databaseName};User ID={username};Password={password}";
            // PC
            constr = "Data Source=GMALISZ\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";
            // LAPTOP
            //constr = "Data Source=DESKTOP-PCL70MC\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";
        }

        public AccountDTO CreateUser(string name, string email, string password)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;
            SqlDataReader dreader;
            
            string sql = "BEGIN TRANSACTION;" +
                        "INSERT INTO account VALUES (@name, @email, @password);" +
                        "DECLARE @id INT;" +
                        "SET @id = IDENT_CURRENT('account')" +
                        "INSERT INTO userTable VALUES (@id, 5, 100);" +
                        "COMMIT;";
            int id = 0;
            string sqlId = "SELECT IDENT_CURRENT('account')";

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@name", Value = name });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@email", Value = email });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@password", Value = password });

            try
            {
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand(sqlId, conn);

                dreader = cmd.ExecuteReader();

                dreader.Read();
                id = int.Parse(dreader.GetValue(0).ToString());

                dreader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return new AccountDTO()
            {
                Id = id,
                Name = name,
                Email = email,
                Password = password,
                MaxAmountOfNotes = 5,
                MaxLengthOfNotes = 100
            };
        }

        public AccountDTO ReadAccount(string name, string password)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;
            SqlDataReader dreader;

            string sql = "SELECT account.[Id], account.[Name], account.[Email], account.[Password], " +
                "userTable.[MaxAmountOfNotes], userTable.[MaxLengthOfNote], " +
                "[StartPremiumDate], [EndPremiumDate] FROM account " +
                "LEFT JOIN userTable ON account.Id = userTable.Id " +
                "LEFT JOIN premiumUserTable ON account.Id = premiumUserTable.Id " +
                "LEFT JOIN adminTable ON account.Id = adminTable.Id " +
                "WHERE [Name] = @name AND [Password] = @password;";

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@name", Value = name });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@password", Value = password });

            AccountDTO accountDTO;

            try
            {
                dreader = cmd.ExecuteReader();

                dreader.Read();
                accountDTO = new AccountDTO
                {
                    Id = dreader.GetInt32(0),
                    Name = dreader.GetString(1).Trim(),
                    Email = dreader.GetString(2).Trim(),
                    Password = dreader.GetString(3).Trim()
                };

                if (!DBNull.Value.Equals(dreader.GetValue(4)))
                    accountDTO.MaxAmountOfNotes = dreader.GetInt32(4);
                if (!DBNull.Value.Equals(dreader.GetValue(5)))
                    accountDTO.MaxLengthOfNotes = dreader.GetInt32(5);

                if (!DBNull.Value.Equals(dreader.GetValue(6)))
                    accountDTO.StartPremiumDate = dreader.GetDateTime(6);
                if (!DBNull.Value.Equals(dreader.GetValue(7)))
                    accountDTO.EndPremiumDate = dreader.GetDateTime(7);
                dreader.Close();
            }
            catch (Exception ex)
            {
                return new AccountDTO();
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return accountDTO;
        }

        public void UpdateUser(int id, string title, string text)
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
        public void DeleteUser(int id)
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
