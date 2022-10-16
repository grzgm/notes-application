using DataLayer;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace NotesAplicationWeb.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        [Required, MinLength(3), MaxLength(15)]
        public string Name { get; set; }

        [BindProperty]
        [Required, RegularExpression("^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{6,10}$", ErrorMessage = "Password mus have minimum 6 characters and maximum 10, at least 1 letter and 1 number")]
        public string Password { get; set; }
        public string mess { get; private set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                AccountRepository accountRepository = new AccountRepository();
                IUserManager userManager = new UserManager(accountRepository);

                Account account;

                try
                {
                    account = userManager.ReadAccount(Name, Password);
                }
                catch (Exception ex)
                {
                    mess = ex.Message;
                    return Page();
                }

                string accountJson;

                switch (account.GetType().ToString())
                {
                    case "LogicLayer.User":
                        accountJson = JsonSerializer.Serialize((User)account);
                        break;
                    case "LogicLayer.PremiumUser":
                        accountJson = JsonSerializer.Serialize((PremiumUser)account);
                        break;
                    case "LogicLayer.Admin":
                        accountJson = JsonSerializer.Serialize((Admin)account);
                        break;
                    default:
                        throw new NotImplementedException();
                        break;
                }

                HttpContext.Session.SetString("accountJson", accountJson);
                HttpContext.Session.SetInt32("accountId", account.Id);
                HttpContext.Session.SetString("accountType", account.GetType().ToString());

                return RedirectToPage("Content");
            }
            else
            {
                mess = "Invalid Credentials";
                return Page();
            }
        }
    }
}
