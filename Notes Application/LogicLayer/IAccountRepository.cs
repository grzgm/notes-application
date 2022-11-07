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
        void UpdateUser(int id, string name, string email, int maxAmountOfNotes, int maxLengthOfNotes, int daysOfPremiumLeft);
        public void DeleteUser(int id);
        public void CreatePremiumRequest(int userId);

    }
}
