using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LogicLayer.DTOs;

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
            this.id = accountDTO.Id;
            this.name = accountDTO.Name;
            this.email = accountDTO.Email;
            this.password = accountDTO.Password;
            this.maxAmountOfNotes = accountDTO.MaxAmountOfNotes.Value;
            this.maxLengthOfNotes = accountDTO.MaxLengthOfNotes.Value;
        }

        [JsonConstructor]
        public User(int id, string name, string email, string password, int maxAmountOfNotes, int maxLengthOfNotes) : base(id, name, email, password)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.maxAmountOfNotes = maxAmountOfNotes;
            this.maxLengthOfNotes = maxLengthOfNotes;
        }

        public int MaxAmountOfNotes
        {
            get { return this.maxAmountOfNotes; }
            set { this.maxAmountOfNotes = value; }
        }

        public int MaxLengthOfNotes
        {
            get { return this.maxLengthOfNotes; }
            set { this.maxLengthOfNotes = value; }
        }
        private void GetPremium()
        {
            throw new NotImplementedException();
        }
    }
}
