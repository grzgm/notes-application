using LogicLayer;
using LogicLayer.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public AccountDTO ReadUser(int id)
        {
            if (id == 7)
            {
                return new AccountDTO()
                {
                    Id = 7,
                    Name = "NameUnitTest",
                    Email = "TestAccount@Email",
                    Password = "PasswordUnitTest",
                    MaxAmountOfNotes = 5,
                    MaxLengthOfNotes = 100
                };
            }
            throw new Exception("There is no such user.");
        }

        public List<AccountDTO> ReadUsers(string name, string email)
        {
            List<AccountDTO> users = new List<AccountDTO>(){
            new AccountDTO()
            {
                Id = 7,
                Name = "NameUnitTest",
                Email = "TestAccount@Email",
                Password = "PasswordUnitTest",
                MaxAmountOfNotes = 5,
                MaxLengthOfNotes = 100
            },
            new AccountDTO()
            {
                Id = 8,
                Name = "NameUnitTest2",
                Email = "TestAccount@Email",
                Password = "PasswordUnitTest",
                MaxAmountOfNotes = 5,
                MaxLengthOfNotes = 100
            },
            new AccountDTO()
            {
                Id = 9,
                Name = "NameUnitTest",
                Email = "TestAccount@Email2",
                Password = "PasswordUnitTest",
                MaxAmountOfNotes = 5,
                MaxLengthOfNotes = 100
            } };

            if(name == "NameUnitTest" && email == "TestAccount@Email")
            { 
                return new List<AccountDTO>(){new AccountDTO(){
                Id = 7,
                Name = "NameUnitTest",
                Email = "TestAccount@Email",
                Password = "PasswordUnitTest",
                MaxAmountOfNotes = 5,
                MaxLengthOfNotes = 100} };
            }
            else if (email == "Wrong" || name == "Wrong")
            {
                return new List<AccountDTO>();
            }
            else if (email == "" && name == "")
            {
                return users;
            }
            else if (name == "")
            {
                return users.Where(p => p.Email == email).ToList();
            }
            else if (email == "")
            {
                return users.Where(p => p.Name == name).ToList();
            }

            throw new Exception("There is no such users.");
        }

        public void UpdateUser(int id, string name, string email, int maxAmountOfNotes, int maxLengthOfNotes, int daysOfPremiumLeft)
        {
            throw new NotImplementedException();
        }
        public void DeleteUser(int id)
        {

        }
        public void CreatePremiumRequest(int userId)
        {

        }
    }
}
