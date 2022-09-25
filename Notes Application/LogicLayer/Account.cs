using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
	public abstract class Account
	{
		protected int id;
		protected string name;
		protected string email;
		protected string password;
        protected int amountOfNotes;
        protected int maxAmountOfNotes;
		protected int maxLengthOfNote;

        public int Id
        {
            get;
            set;
        }

        [Required, MinLength(6), MaxLength(15)]
        public string Name
        {
            get;
            set;
        }

        [Required, EmailAddress]
        public string Email
        {
            get;
            set;
        }

        [Required, RegularExpression("^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{6,10}$", ErrorMessage = "Password mus have minimum 6 characters and maximum 10, at least 1 letter and 1 number")]
        public string Password
        {
            get;
            set;
        }

        public int AmountOfNotes
        {
            get;
            set;
        }

        public int MaxAmountOfNotes
        {
            get;
            set;
        }

        public int MaxLengthOfNotes
        {
            get;
            set;
        }
    }
}
