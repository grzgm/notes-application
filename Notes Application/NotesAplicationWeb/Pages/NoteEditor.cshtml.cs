using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NotesAplicationWeb.Pages
{
    public class NoteEditorModel : PageModel
    {
        //[BindProperty]
        //public string Title { get; set; }
        //[BindProperty]
        //public string Text { get; set; }
        //[BindProperty]
        //public int Id { get; set; }

        [BindProperty(SupportsGet = true)]
        public Note Note { get; set; }
        public void OnGet()
        {
            //Note = new Note(Title, Text, Id);
        }

        public void OnPost()
        {
        }

        public IActionResult OnPostSave()
        {
            // Note cannot Bind id as it is 
            return RedirectToPage("Content", new { Title = Note.Title, Text = Note.Text, Id = RouteData.Values["id"] });
        }
    }
}
