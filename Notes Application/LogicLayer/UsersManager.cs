using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LogicLayer.DTOs;

namespace LogicLayer
{
	public class UserManager : IUserManagerWeb, IUserManagerDesktop, IUserManagerAdmin
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

        Account IUserManagerWeb.CreateUser(string name, string email, string password)
		{
            AccountDTO accountDTO = accountRepository.CreateUser(name, email, password);
            return ConvertAccountDTO(accountDTO);
        }

        Account IUserManagerWeb.ReadAccount(string name, string password)
        {
            AccountDTO accountDTO = accountRepository.ReadAccount(name, password);
            return ConvertAccountDTO(accountDTO);
        }
        void IUserManagerWeb.CreatePremiumRequest(int userId)
        {
            accountRepository.CreatePremiumRequest(userId);
        }

        Account IUserManagerDesktop.ReadUser(int id, string name, string email)
        {
            AccountDTO accountDTO;
            // There is no need to search with name, email, password in database, cuz id is Unique
            try
            {
                accountDTO = accountRepository.ReadUser(id);
            }
            catch(Exception ex)
            {
                return null;
            }

            if (name != "")
            {
                if (accountDTO.Name != name)
                    return null;
            }
            if (email != "")
            {
                if (accountDTO.Email != email)
                    return null;
            }

            return ConvertAccountDTO(accountDTO);
        }

        List<Account> IUserManagerDesktop.ReadUsers(string name, string email)
        {
            List<AccountDTO> accountDTOs;
            try
            {
                accountDTOs = accountRepository.ReadUsers(name, email);
            }
            catch (Exception ex)
            {
                return null;
            }

            if(!accountDTOs.Any())
            {
                return null;
            }
            return ConvertAccountsDTO(accountDTOs);
        }

        void IUserManagerDesktop.UpdateUser(int id, string name, string email, int maxAmountOfNotes, int maxLengthOfNotes, int? daysOfPremiumLeft = null)
        {
            if(daysOfPremiumLeft != null)
                accountRepository.UpdateUser(id, name, email, maxAmountOfNotes, maxLengthOfNotes, DateTime.Now.AddDays(daysOfPremiumLeft.Value));
            else
                accountRepository.UpdateUser(id, name, email, maxAmountOfNotes, maxLengthOfNotes);

        }

        void IUserManagerDesktop.DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        private Account ConvertAccountDTO(AccountDTO accountDTO)
        {
            Account account;
            if (accountDTO.MaxLengthOfNotes == null)
            {
                account = new Admin(accountDTO);
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

        private List<Account> ConvertAccountsDTO(List<AccountDTO> accountDTOs)
        {
            List<Account> accounts = new List<Account>();
            foreach (AccountDTO accountDTO in accountDTOs)
            {
                accounts.Add(ConvertAccountDTO(accountDTO));
            }

            return accounts;
        }
    }
}
