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
        private string adminRole;
		public Admin()
		{

        }
        public Admin(AccountDTO accountDTO)
        {
            this.id = accountDTO.Id;
            this.name = accountDTO.Name;
            this.email = accountDTO.Email;
            this.password = accountDTO.Password;
            this.adminRole = accountDTO.AdminRole;
        }
        public Admin(int id, string name, string email, string password, string adminRole) : base(id, name, email, password)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.adminRole = adminRole;
        }
        public void ChangeUserPremiumStatus()
        {
            throw new NotImplementedException();
        }

        public void GetUserInfo(int id)
        {
            throw new NotImplementedException();
        }

        public string AdminRole
        {
            get { return this.adminRole; }
            set { this.adminRole = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "; " + AdminRole;
        }
    }
}
