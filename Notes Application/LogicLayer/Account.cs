using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LogicLayer
{
	public abstract class Account
	{
		protected int id;
		protected string name;
		protected string email;
		protected string password;

        protected Account()
        {

        }
        [JsonConstructor]
        protected Account(int id, string name, string email, string password)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
        }

        public int Id
        {
            get { return this.id; }
        }

        [Required, MinLength(3), MaxLength(15)]
        public string Name
        {
            get { return this.name; }
             set { this.name = value; }
        }

        [Required, EmailAddress]
        public string Email
        {
            get { return this.email; }
             set { this.email = value; }
        }

        [Required, RegularExpression("^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{6,10}$", ErrorMessage = "Password mus have minimum 6 characters and maximum 10, at least 1 letter and 1 number")]
        public string Password
        {
            get { return this.password; }
             set { this.password = value; }
        }

        public int AmountOfNotes
        {
            get;
            set;
        }
    }
}
