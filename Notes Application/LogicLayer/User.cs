using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
	public class User : Account
	{
		protected bool isPremium;

        public User()
        { }

        public User(int id, string name, string email, bool isPremium, int maxAmountOfNotes, int maxLengthOfNotes)
        {
            Id = id;
            Name = name;
            Email = email;
            IsPremium = isPremium;
            MaxAmountOfNotes = maxAmountOfNotes;
            MaxLengthOfNotes = maxLengthOfNotes;
        }
        public bool IsPremium
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
