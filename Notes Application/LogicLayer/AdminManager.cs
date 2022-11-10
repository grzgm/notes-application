using LogicLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

		public string CreateAdmin(string name, string email, string password, string adminRole)
		{
            try
            {
                accountRepository.CreateAdmin(name, email, password, adminRole);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "New Admin Added";
        }

        public Admin ReadAdmin(int id, string name, string email, string adminRole)
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
            if (adminRole != "")
            {
                if (accountDTO.AdminRole != email)
                    return null;
            }

            return ConvertAccountDTOToAdmin(accountDTO);
        }

        public List<Admin> ReadAdmins(string name, string email, string adminRole)
        {
            List<AccountDTO> accountDTOs;
            try
            {
                accountDTOs = accountRepository.ReadAdmins(name, email, adminRole);
            }
            catch (Exception ex)
            {
                return null;
            }

            if (!accountDTOs.Any())
            {
                return null;
            }
            return ConvertAccountsDTOToAdmins(accountDTOs);
        }

        public void UpdateAdmin(int id, string name, string email, string adminRole)
        {
            accountRepository.UpdateAdmin(id, name, email, adminRole);
        }
        public void DeleteAdmin(int id)
        {
            accountRepository.DeleteAdmin(id);
        }

        public Admin ConvertAccountDTOToAdmin(AccountDTO accountDTO)
        {
            return new Admin(accountDTO);
        }

        public List<Admin> ConvertAccountsDTOToAdmins(List<AccountDTO> accountDTOs)
        {
            List<Admin> accounts = new List<Admin>();
            foreach (AccountDTO accountDTO in accountDTOs)
            {
                accounts.Add(ConvertAccountDTOToAdmin(accountDTO));
            }

            return accounts;
        }

    }
}
