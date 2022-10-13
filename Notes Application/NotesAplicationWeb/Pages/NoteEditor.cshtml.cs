using DataLayer;
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

        private int accountId { get; set; }
        public void OnGet()
        {
            Title = Note.Title;
            Text = Note.Text;
        }

        public IActionResult OnPost()
        {
            if (HttpContext.Session.Get("accountJson") == null)
                return RedirectToPage("Index");

            accountId = HttpContext.Session.GetInt32("accountId").Value;
            //if ((Note.Title == String.Empty) && (Note.Text == String.Empty))
            //{
            //    NoteRepository noteRepository = new NoteRepository();
            //    INoteManagerWeb noteManager = new NoteManager(noteRepository);
            //    noteManager.DeleteNote(1, int.Parse(RouteData.Values["noteId"].ToString()));
            //}
            if ((Title == null) && (Text == null))
            {
                NoteRepository noteRepository = new NoteRepository();
                INoteManagerWeb noteManager = new NoteManager(noteRepository);
                noteManager.CreateNote(accountId, Note.Title, Note.Text);
            }
            else if ((Title != Note.Title) || (Text != Note.Text))
            {
                NoteRepository noteRepository = new NoteRepository();
                INoteManagerWeb noteManager = new NoteManager(noteRepository);
                noteManager.UpdateNote(int.Parse(RouteData.Values["noteId"].ToString()), accountId, Note.Title, Note.Text);
            }

            return RedirectToPage("Content");
        }
    }
}
