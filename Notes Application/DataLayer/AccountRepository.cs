using System.Data.SqlClient;
using System.Security.Principal;
//using DataLayer.DTOs;
using LogicLayer;
using LogicLayer.DTOs;

namespace DataLayer
{
    public class AccountRepository : LogicLayer.IAccountRepository
    {
        private SqlConnection conn;
        private string constr;
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
            catch (SqlException ex)
            {
                throw new Exception("User with those credentials already exists.");
            }
            catch (Exception ex)
            {
                throw new Exception("STH went wrong");
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
                "[StartPremiumDate], [EndPremiumDate], AdminRole FROM account " +
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
                if (!DBNull.Value.Equals(dreader.GetValue(8)))
                    accountDTO.AdminRole = dreader.GetString(8).Trim();
                dreader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("There is no such user.");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return accountDTO;
        }

        public AccountDTO ReadUser(int id)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;
            SqlDataReader dreader;

            string sql = "SELECT account.[Id], account.[Name], account.[Email], account.[Password], " +
                "userTable.[MaxAmountOfNotes], userTable.[MaxLengthOfNote], " +
                "[StartPremiumDate], [EndPremiumDate] FROM account " +
                "INNER JOIN userTable ON account.Id = userTable.Id " +
                "LEFT JOIN premiumUserTable ON account.Id = premiumUserTable.Id " +
                "WHERE account.[Id] = @id";

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@id", Value = id });

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
                throw new Exception("There is no such user.");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return accountDTO;
        }

        public List<AccountDTO> ReadUsers(string name, string email)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;
            SqlDataReader dreader;

            string sql = "SELECT account.[Id], account.[Name], account.[Email], account.[Password], " +
                "userTable.[MaxAmountOfNotes], userTable.[MaxLengthOfNote], " +
                "[StartPremiumDate], [EndPremiumDate] FROM account " +
                "INNER JOIN userTable ON account.Id = userTable.Id " +
                "LEFT JOIN premiumUserTable ON account.Id = premiumUserTable.Id " +
                "WHERE TRIM([Name]) LIKE @name AND TRIM([Email]) LIKE @email";

            cmd = new SqlCommand(sql, conn);
            if (name != "")
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@name", Value = name });
            else
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@name", Value = "%" });
            if (email != "")
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@email", Value = email });
            else
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@email", Value = "%" });

            List<AccountDTO> accountDTOs = new List<AccountDTO>();

            try
            {
                dreader = cmd.ExecuteReader();

                while(dreader.Read())
                {
                    AccountDTO accountDTO = new AccountDTO
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
                    accountDTOs.Add(accountDTO);
                }
                dreader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("There is no such users.");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return accountDTOs;
        }

        public void UpdateUser(int id, string name, string email, int maxAmountOfNotes, int maxLengthOfNotes, DateTime? endPremiumDate = null)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;

            string sql = "BEGIN TRANSACTION; " +
                "UPDATE account SET Name = @name, Email = @email WHERE Id = @id; " +
                "UPDATE userTable SET MaxAmountOfNotes = @maxAmountOfNotes, MaxLengthOfNote = @maxLengthOfNotes WHERE Id = @id; ";

            if(endPremiumDate != null)
            {
                sql += "UPDATE premiumUserTable SET EndPremiumDate = @endPremiumDate WHERE Id = @id; ";
            }

            sql += "COMMIT;";

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@id", Value = id });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@name", Value = name });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@email", Value = email });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@maxAmountOfNotes", Value = maxAmountOfNotes });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@maxLengthOfNotes", Value = maxLengthOfNotes });

            if (endPremiumDate != null)
            {
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@endPremiumDate", Value = endPremiumDate.Value});
            }

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

            string sql = "DELETE FROM account WHERE Id=@id";

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
        public void CreatePremiumRequest(int userId)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;
            SqlDataReader dreader;

            string sqlCheck = "SELECT COUNT(UserId) FROM premiumRequests WHERE UserId = @id;";
            int amount = 0;
            string sqlInsert = "INSERT INTO premiumRequests VALUES (@id, @date);";

            cmd = new SqlCommand(sqlCheck, conn);
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@id", Value = userId });

            try
            {
                dreader = cmd.ExecuteReader();

                dreader.Read();
                amount = int.Parse(dreader.GetValue(0).ToString());

                dreader.Close();

                if (amount == 0)
                {
                    cmd = new SqlCommand(sqlInsert, conn);
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@id", Value = userId });
                    cmd.Parameters.Add(new SqlParameter { ParameterName = "@date", Value = DateTime.Now });
                    cmd.ExecuteNonQuery();
                }
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

        public void CreateAdmin(string name, string email, string password, string adminRole)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;
            SqlDataReader dreader;

            string sql = "BEGIN TRANSACTION;" +
                        "INSERT INTO account VALUES (@name, @email, @password);" +
                        "DECLARE @id INT;" +
                        "SET @id = IDENT_CURRENT('account')" +
                        "INSERT INTO adminTable VALUES (@id, @adminRole);" +
                        "COMMIT;";
            int id = 0;
            string sqlId = "SELECT IDENT_CURRENT('account')";

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@name", Value = name });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@email", Value = email });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@password", Value = password });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@adminRole", Value = adminRole });

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("User with those credentials already exists.");
            }
            catch (Exception ex)
            {
                throw new Exception("STH went wrong");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public AccountDTO ReadAdmin(int id)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;
            SqlDataReader dreader;

            string sql = "SELECT account.[Id], account.[Name], account.[Email], account.[Password], " +
                "adminTable.AdminRole FROM account " +
                "INNER JOIN adminTable ON account.Id = adminTable.Id " +
                "WHERE account.[Id] = @id;";

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@id", Value = id });

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
                    Password = dreader.GetString(3).Trim(),
                    AdminRole = dreader.GetString(4).Trim(),
                };
                dreader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("There is no such user.");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return accountDTO;
        }

        public List<AccountDTO> ReadAdmins(string name, string email, string adminRole)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;
            SqlDataReader dreader;

            string sql = "SELECT account.[Id], account.[Name], account.[Email], account.[Password], " +
                "AdminRole FROM account INNER JOIN adminTable ON account.Id = adminTable.Id " +
                "WHERE TRIM([Name]) LIKE @name AND TRIM([Email]) LIKE @email AND TRIM([AdminRole]) LIKE @adminRole;";

            cmd = new SqlCommand(sql, conn);
            if (name != "")
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@name", Value = name });
            else
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@name", Value = "%" });
            if (email != "")
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@email", Value = email });
            else
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@email", Value = "%" });
            if (email != "")
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@adminRole", Value = adminRole });
            else
                cmd.Parameters.Add(new SqlParameter { ParameterName = "@adminRole", Value = "%" });

            List<AccountDTO> accountDTOs = new List<AccountDTO>();

            try
            {
                dreader = cmd.ExecuteReader();

                while (dreader.Read())
                {
                    AccountDTO accountDTO = new AccountDTO
                    {
                        Id = dreader.GetInt32(0),
                        Name = dreader.GetString(1).Trim(),
                        Email = dreader.GetString(2).Trim(),
                        Password = dreader.GetString(3).Trim(),
                        AdminRole = dreader.GetString(4).Trim(),
                    };

                    accountDTOs.Add(accountDTO);
                }
                dreader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("There is no such users.");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }

            return accountDTOs;
        }
        public void UpdateAdmin(int id, string name, string email, string adminRole)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;

            string sql = "BEGIN TRANSACTION; " +
                "UPDATE account SET Name = @name, Email = @email WHERE Id = @id; " +
                "UPDATE AdminRole SET AdminRole = @adminRole WHERE Id = @id; " +
                "COMMIT;";

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@id", Value = id });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@name", Value = name });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@email", Value = email });
            cmd.Parameters.Add(new SqlParameter { ParameterName = "@adminRole", Value = adminRole });

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
        public void DeleteAdmin(int id)
        {
            conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd;

            string sql = "DELETE FROM account WHERE Id=@id";

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
