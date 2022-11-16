using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using LogicLayer;
using DataLayer;
using System.Security.Principal;
using System.Text.Json;

namespace NotesAplicationWeb.Pages
{
    public class RegisterModel : PageModel
    {
        public int id;

        [BindProperty]
        public User User { get; set; }
        public string mess { get; private set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                IAccountRepository accountRepository = new AccountRepository();
                IUserManagerWeb userManager = new UserManager(accountRepository);

                Account account;

                try
                {
                    account = userManager.CreateUser(User.Name, User.Email, User.Password);
                }
                catch (Exception ex)
                {
                    mess = ex.Message;
                    return Page();
                }

                string accountJson = JsonSerializer.Serialize((User)account);

                HttpContext.Session.SetString("accountJson", accountJson);
                HttpContext.Session.SetInt32("accountId", account.Id);
                if (account is User)
                {
                    HttpContext.Session.SetInt32("MaxLengthOfNote", ((User)account).MaxLengthOfNotes);
                }
                HttpContext.Session.SetString("accountType", account.GetType().ToString());

                //Which one is better?
                return RedirectToPage("Content");
                return new RedirectToPageResult("Content");
            }
            else
            {
                mess = "Invalid Credentials";
                return Page();
            }
        }
    }
}
