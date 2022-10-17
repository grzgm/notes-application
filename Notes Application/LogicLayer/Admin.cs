using DataLayer.DTOs;
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

        }
        public Admin(AccountDTO accountDTO)
        {
            this.id = accountDTO.Id;
            this.name = accountDTO.Name;
            this.email = accountDTO.Email;
            this.password = accountDTO.Password;
        }
        public Admin(int id, string name, string email, string password) : base(id, name, email, password)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
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
