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
		protected int amountOfNotes;
		protected string password;
		protected int maxAmountOfNotes;
		protected int maxLengthOfNote;

        public int Id
        {
            get;
            set;
        }

        [Required, MinLength(6)]
        public string? Name
        {
            get;
            set;
        }

        [EmailAddress(ErrorMessage = "Email")]
        public string Email
        {
            get;
            set;
        }

        public bool IsPremium
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
