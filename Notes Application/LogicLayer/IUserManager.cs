using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
	public interface IUserManager
	{
		Account SearchUser(string name, string password);

		Account CreateUser(string name, string email, string password);
	}
}
