using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NotesAplicationWeb.Pages
{
    public class NoteEditorModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }
        public string mess { get; private set; }
        [BindProperty(SupportsGet = true)]
        public string Title { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Text { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public Note Note { get; set; }
        public NoteEditorModel()
        {
            Note = new Note(Title, Text, Id);
        }
        public void OnGet()
        {
            Note = new Note(Title, Text, Id);
        }

        public IActionResult OnPost(string Title)
        {
            Note.title = Title;
            Note.text = Text;
            return RedirectToPage("Content", new { Title = this.Title, Text = this.Text, this.Id });
            //return RedirectToPage("Content", new { Title = "huj", Text = "huj", Id = 3 });
        }

        public IActionResult OnPostDelete()
        {
            Note.title = Title;
            Note.text = Text;
            return RedirectToPage("Content", new { Title = this.Title, Text = this.Text, this.Id });
        }
    }
}
