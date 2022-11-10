using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer.DTOs;

namespace LogicLayer
{
	public class Admin : Account
	{
        private string role;
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
        public Admin(int id, string name, string email, string password, string role) : base(id, name, email, password)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;
        }
        public void ChangeUserPremiumStatus()
        {
            throw new NotImplementedException();
        }

        public void GetUserInfo(int id)
        {
            throw new NotImplementedException();
        }

        public string Role
        {
            get { return this.role; }
            set { this.role = value; }
        }
    }
}
