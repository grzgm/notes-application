using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.DTOs;

namespace LogicLayer
{
	public class UserManager : IUserManager, IUserManagerAdmin
    {
        private readonly AccountRepository accountRepository;

		public UserManager(AccountRepository accountRepository)
        {
            this.accountRepository = accountRepository
                ?? throw new ArgumentNullException(nameof(accountRepository));
        }
        public int AmountOfPremiumUsers()
		{
			throw new NotImplementedException();
		}

		public int AmountOfUsers()
		{
			throw new NotImplementedException();
		}

		public void ChangeMaxAmountOfNotes(int id)
		{
			throw new NotImplementedException();
		}

		public void ChangeMaxLengthOfNotes(int id)
		{
			throw new NotImplementedException();
		}

		public void ChangePremiumStatus(int id)
		{
			throw new NotImplementedException();
		}

		public int CreateUser(string name, string email, string password)
		{
			return accountRepository.CreateUser(name, email, password);
		}

		public Account ReadAccount(string name, string password)
		{
			AccountDTO accountDTO = accountRepository.ReadAccount(name, password);
			Account account;
			if(accountDTO.IsPremium != null)
			{
                account = new User(accountDTO);
			}
			else if (accountDTO.StartPremiumDate != null)
			{
                account = new PremiumUser(accountDTO);
			}
			else
			{
				account = new Admin();
			}

			return account;
		}
	}
}
