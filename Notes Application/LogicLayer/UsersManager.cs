using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LogicLayer.DTOs;

namespace LogicLayer
{
	public class UserManager : IUserManager, IUserManagerAdmin
    {
        private readonly IAccountRepository accountRepository;

		public UserManager(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository
                ?? throw new ArgumentNullException(nameof(accountRepository));
        }

        public void ChangePremiumStatus(int id)
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

        public int AmountOfUsers()
        {
            throw new NotImplementedException();
        }
        public int AmountOfPremiumUsers()
        {
            throw new NotImplementedException();
        }

        public Account CreateUser(string name, string email, string password)
		{
            AccountDTO accountDTO = accountRepository.CreateUser(name, email, password);
            return ConvertAccountDTO(accountDTO);
        }

        public Account ReadAccount(string name, string password)
        {
            AccountDTO accountDTO = accountRepository.ReadAccount(name, password);
            return ConvertAccountDTO(accountDTO);
        }
        public void CreatePremiumRequest(int userId)
        {
            accountRepository.CreatePremiumRequest(userId);
        }

        private Account ConvertAccountDTO(AccountDTO accountDTO)
        {
            Account account;
            if (accountDTO.MaxLengthOfNotes == null)
            {
                account = new Admin();
            }
            else if (accountDTO.StartPremiumDate == null)
            {
                account = new User(accountDTO);
            }
            else
            {
                account = new PremiumUser(accountDTO);
            }

            return account;
        }
	}
}
