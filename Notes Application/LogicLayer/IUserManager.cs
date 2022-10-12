using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
	public interface IUserManager
	{
		Account ReadAccount(string name, string password);

		int CreateUser(string name, string email, string password);
	}
}
