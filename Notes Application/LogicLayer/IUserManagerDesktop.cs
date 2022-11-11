using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public interface IUserManagerDesktop
    {
        Account ReadUser(int userId, string name, string email);
        List<Account> ReadUsers(string name, string email);
        void UpdateUser(int userId, string name, string email, int maxAmountOfNotes, int maxLengthOfNotes, int? daysOfPremiumLeft = null);
        void DeleteUser(int userId);
        //void ChangePremiumStatus(int userId);
    }
}
