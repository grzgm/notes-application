using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public interface IUserManagerDesktop
    {
        Account ReadUser(int id, string name, string email, string password);
        List<Account> ReadUsers(string name, string email, string password);
        void UpdateUser(int id, string name, string email, string password, int maxAmountOfNotes, int maxLengthOfNotes, int daysOfPremiumLeft);
        void DeleteUser(int id);
    }
}
