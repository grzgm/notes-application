using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
	public interface IUserManager
    {
        Account CreateUser(string name, string email, string password);
        Account ReadAccount(string name, string password);
        void CreatePremiumRequest(int userId);

    }
}
