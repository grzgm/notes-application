using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
	public class Admin : Account
	{
		public Admin()
		{
			throw new NotImplementedException();
		}

		public Admin(int id, string name, string email, string password) : base(id, name, email, password)
        {

        }
        public void ChangeUserPremiumStatus()
        {
            throw new NotImplementedException();
        }

        public void GetUserInfo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
