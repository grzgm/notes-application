using DataLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
	public class PremiumUser : User
	{
		private int daysOfPremiumLeft;

		public PremiumUser()
		{

        }
        public PremiumUser(AccountDTO accountDTO)
        {
            Id = accountDTO.Id;
            Name = accountDTO.Name;
            Email = accountDTO.Email;
            Password = accountDTO.Password;
            MaxAmountOfNotes = accountDTO.MaxAmountOfNotes.Value;
            MaxLengthOfNotes = accountDTO.MaxLengthOfNotes.Value;
            TimeSpan timeSpan = accountDTO.EndPremiumDate.Value - accountDTO.StartPremiumDate.Value;
            DaysOfPremiumLeft = timeSpan.Days;
        }

        public PremiumUser(int id, string name, string email, string password, int maxAmountOfNotes, int maxLengthOfNotes, bool isPremium, int daysOfPremiumLeft) : base(id, name,email,password,maxAmountOfNotes,maxLengthOfNotes, isPremium)
		{
			DaysOfPremiumLeft = daysOfPremiumLeft;
        }

        public void ProlongPremium()
        {
            throw new NotImplementedException();
        }

		public int DaysOfPremiumLeft { get; set; }
    }
}
