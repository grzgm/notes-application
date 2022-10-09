using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using LogicLayer;
using DataLayer;

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
                AccountRepository accountRepository = new AccountRepository();
                IUserManager userManager = new UserManager(accountRepository);

                try
                {
                    id = userManager.CreateUser(User.Name, User.Email, User.Password);
                }
                catch (Exception ex)
                {
                    return Page();
                }

                //Which one is better?
                return RedirectToPage("Content", new { accountId = id });
                return new RedirectToPageResult("Content");
            }
            else
            {
                mess = "notValid";
                return Page();
            }
        }

        public IActionResult OnPostSave()
        {
            return RedirectToPage("Content", new { accountId = 555 });
        }
    }
}
