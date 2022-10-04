using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NotesAplicationWeb.Pages
{
    public class NoteEditorModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public string Title { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Text { get; set; }
        //[BindProperty]
        //public int Id { get; set; }

        [BindProperty(SupportsGet = true)]
        public Note Note { get; set; }
        public void OnGet()
        {
            Title = Note.Title;
            Text = Note.Text;
        }

        public IActionResult OnPost()
        {
            //if ((Note.Title == String.Empty) && (Note.Text == String.Empty))
            //{
            //    INoteManagerWeb noteManager = new NoteManager();
            //    noteManager.DeleteNote(1, int.Parse(RouteData.Values["id"].ToString()));
            //}
            if ((Title == null) && (Text == null))
            {
                INoteManagerWeb noteManager = new NoteManager();
                noteManager.CreateNote(1, Note.Title, Note.Text);
            }
            else if ((Title != Note.Title) || (Text != Note.Text))
            {
                INoteManagerWeb noteManager = new NoteManager();
                noteManager.UpdateNote(1, int.Parse(RouteData.Values["id"].ToString()), Note.Title, Note.Text);
            }

            return RedirectToPage("Content");
        }

        public IActionResult OnPostSave()
        {
            string i = RouteData.Values["id"].ToString();
            // Note cannot Bind id as it is 
            return RedirectToPage("Content", new { Title = Note.Title, Text = Note.Text, Id = RouteData.Values["id"] });
        }
    }
}
