using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using LogicLayer;

namespace NotesAplicationWeb.Pages
{
    public class RegisterModel : PageModel
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
                //Which one is better?
                return RedirectToPage("Content");
                return new RedirectToPageResult("Content");
            }
            else
            {
                mess = "notValid";
                return Page();
            }
        }
    }
}
