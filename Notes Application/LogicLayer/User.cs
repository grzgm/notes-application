using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DTOs;

namespace LogicLayer
{
	public class User : Account
	{
        protected int maxAmountOfNotes;
        protected int maxLengthOfNotes;


        public User()
        { }
        public User(AccountDTO accountDTO)
        {
            Id = accountDTO.Id;
            Name = accountDTO.Name;
            Email = accountDTO.Email;
            Password = accountDTO.Password;
            MaxAmountOfNotes = accountDTO.MaxAmountOfNotes.Value;
            MaxLengthOfNotes = accountDTO.MaxLengthOfNotes.Value;
        }

        public User(int id, string name, string email, string password, int maxAmountOfNotes, int maxLengthOfNotes, bool isPremium) : base(id, name, email, password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            MaxAmountOfNotes = maxAmountOfNotes;
            MaxLengthOfNotes = maxLengthOfNotes;
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
        public void GetPremium()
        {
            throw new NotImplementedException();
        }
    }
}
