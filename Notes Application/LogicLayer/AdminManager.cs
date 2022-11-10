using LogicLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
	public class AdminManager
    {
        private readonly IAccountRepository accountRepository;
        public AdminManager(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository
                ?? throw new ArgumentNullException(nameof(accountRepository));
        }
        public void ShowAdmin(int id)
		{
			throw new NotImplementedException();
		}

		public void ShowAllAdmins()
		{
			throw new NotImplementedException();
		}

		public int AmountOfAdmins()
		{
			throw new NotImplementedException();
		}

		Account SearchAdmin(string name, string password)
		{
			throw new NotImplementedException();
		}

		Account CreateAdmin(string name, string email, string password)
		{
			throw new NotImplementedException();
		}

        Account ReadAdmin(int id, string name, string email)
        {
            AccountDTO accountDTO;
            // There is no need to search with name, email, password in database, cuz id is Unique
            try
            {
                accountDTO = accountRepository.ReadAdmin(id);
            }
            catch (Exception ex)
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

            return UserManager.ConvertAccountDTO(accountDTO);
        }

        List<Account> ReadAdmin(string name, string email)
        {
            List<AccountDTO> accountDTOs;
            try
            {
                accountDTOs = accountRepository.ReadAdmins(name, email);
            }
            catch (Exception ex)
            {
                return null;
            }

            if (!accountDTOs.Any())
            {
                return null;
            }
            return UserManager.ConvertAccountsDTO(accountDTOs);
        }

    }
}
