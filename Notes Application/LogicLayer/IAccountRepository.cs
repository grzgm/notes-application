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
        AccountDTO CreateUser(string name, string email, string password);
        AccountDTO ReadAccount(string name, string password);
        AccountDTO ReadUser(int id);
        List<AccountDTO> ReadUsers(string name, string email);
        void UpdateUser(int id, string name, string email, int maxAmountOfNotes, int maxLengthOfNotes, DateTime? endPremiumDate = null);
        void DeleteUser(int id);
        void CreatePremiumRequest(int userId);
        void CreateAdmin(string name, string email, string password, string adminRole);
        AccountDTO ReadAdmin(int id);
        List<AccountDTO> ReadAdmins(string name, string email, string adminRole);
        void UpdateAdmin(int id, string name, string email, string adminRole);
        void DeleteAdmin(int id);

    }
}
