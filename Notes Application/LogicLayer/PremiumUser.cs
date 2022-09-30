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
			throw new NotImplementedException();
		}

		public PremiumUser(int id, string name, string email, bool isPremium, int maxAmountOfNotes, int maxLengthOfNotes, int daysOfPremiumLeft)
		{
			throw new NotImplementedException();
        }

        public void ProlongPremium()
        {
            throw new NotImplementedException();
        }
    }
}
