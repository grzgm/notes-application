using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NotesAplicationWeb.Pages
{
    public class LoginModel : PageModel
    {
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
                return RedirectToPage("Content");
            }
            else
            {
                mess = "notValid";
                return Page();
            }
        }
    }
}
