using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
	public class UsersManager : IUserManager, IUserManagerAdmin
	{
		public int AmountOfPremiumUsers()
		{
			throw new NotImplementedException();
		}

		public int AmountOfUsers()
		{
			throw new NotImplementedException();
		}

		public void ChangeMaxAmountOfNotes(int id)
		{
			throw new NotImplementedException();
		}

		public void ChangeMaxLengthOfNotes(int id)
		{
			throw new NotImplementedException();
		}

		public void ChangePremiumStatus(int id)
		{
			throw new NotImplementedException();
		}

		public Account CreateUser(string name, string email, string password)
		{
			throw new NotImplementedException();
		}

		public Account SearchUser(string name, string password)
		{
			throw new NotImplementedException();
		}
	}
}
