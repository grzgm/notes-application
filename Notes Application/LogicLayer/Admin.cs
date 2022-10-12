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
            Id = accountDTO.Id;
            Name = accountDTO.Name;
            Email = accountDTO.Email;
            Password = accountDTO.Password;
        }
        public Admin(int id, string name, string email, string password) : base(id, name, email, password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
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
