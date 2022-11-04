using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer.DTOs;

namespace LogicLayer
{
    public interface IAccountRepository
    {
        public AccountDTO CreateUser(string name, string email, string password);
        public AccountDTO ReadAccount(string name, string password);
        public void UpdateUser(int id, string title, string text);
        public void DeleteUser(int id);
        public void CreatePremiumRequest(int userId);

    }
}
