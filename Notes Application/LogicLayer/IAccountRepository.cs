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
        AccountDTO ReadUser(int id);
        List<AccountDTO> ReadUsers(string name, string email);
        void UpdateUser(int id, string name, string email, int maxAmountOfNotes, int maxLengthOfNotes, DateTime? endPremiumDate = null);
        public void DeleteUser(int id);
        public void CreatePremiumRequest(int userId);
        public void CreateAdmin(string name, string email, string password, string adminRole);
        public AccountDTO ReadAdmin(int id);
        public List<AccountDTO> ReadAdmins(string name, string email, string adminRole);
        public void UpdateAdmin(int id, string name, string email, string adminRole);
        public void DeleteAdmin(int id);

    }
}
