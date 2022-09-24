using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LogicLayer;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace NotesAplicationWeb.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }
        public User Email { get; set; }
        public string mess { get; private set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                mess = "Valid";
                return Page();
            }
            else
            {
                mess = "notValid";
                return Page();
            }
        }
    }
}
