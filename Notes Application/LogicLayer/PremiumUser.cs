using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LogicLayer.DTOs;

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
            this.id = accountDTO.Id;
            this.name = accountDTO.Name;
            this.email = accountDTO.Email;
            this.password = accountDTO.Password;
            this.maxAmountOfNotes = accountDTO.MaxAmountOfNotes.Value;
            this.maxLengthOfNotes = accountDTO.MaxLengthOfNotes.Value;
            TimeSpan timeSpan = accountDTO.EndPremiumDate.Value - DateTime.Now;
            this.daysOfPremiumLeft = timeSpan.Days;
        }

        [JsonConstructor]
        public PremiumUser(int id, string name, string email, string password, int maxAmountOfNotes, int maxLengthOfNotes, int daysOfPremiumLeft) : base(id, name,email,password,maxAmountOfNotes,maxLengthOfNotes)
		{
			this.daysOfPremiumLeft = daysOfPremiumLeft;
        }

        public void ProlongPremium()
        {
            throw new NotImplementedException();
        }

		public int DaysOfPremiumLeft { get { return this.daysOfPremiumLeft; } }
    }
}
