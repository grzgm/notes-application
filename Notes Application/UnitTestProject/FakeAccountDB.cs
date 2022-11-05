using LogicLayer;
using LogicLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    internal class FakeAccountDB : IAccountRepository
    {
        public AccountDTO CreateUser(string name, string email, string password)
        {
            if (name == "NameUnitTest" && email == "TestAccount@Email" && password == "PasswordUnitTest")
            {
                return new AccountDTO()
                {
                    Id = 7,
                    Name = name,
                    Email = email,
                    Password = password,
                    MaxAmountOfNotes = 5,
                    MaxLengthOfNotes = 100
                };
            }
            else if (name == "SqlException" && email == "SqlException" && password == "SqlException")
            {
                SqlException exception = null;
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=.;Database=GUARANTEED_TO_FAIL;Connection Timeout=1");
                    conn.Open();
                }
                catch (SqlException ex)
                {
                    exception = ex;
                }
                throw exception;
            }
            throw new Exception("STH went wrong");
        }
        public AccountDTO ReadAccount(string name, string password)
        {
            if(name == "NameUnitTest" && password == "PasswordUnitTest")
            {
                return new AccountDTO()
                {
                    Id = 7,
                    Name = name,
                    Email = "TestAccount@Email",
                    Password = password,
                    MaxAmountOfNotes = 5,
                    MaxLengthOfNotes = 100
                };
            }
            throw new Exception("There is no such user.");
        }
        public void UpdateUser(int id, string title, string text)
        {

        }
        public void DeleteUser(int id)
        {

        }
        public void CreatePremiumRequest(int userId)
        {

        }
    }
}
