using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LogicLayer;
using static System.Net.Mime.MediaTypeNames;
using DataLayer;
using System.Text.Json;

namespace NotesAplicationWeb.Pages
{
    public class ContentModel : PageModel
    {
        public Account account;

        [BindProperty(SupportsGet = true)]
        public string Title { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Text { get; set; }

        [BindProperty(SupportsGet = true)]
        public int NoteId { get; set; }

        [BindProperty(SupportsGet = true)]
        public string accountJson { get; set; }

        [BindProperty(SupportsGet = true)]
        public string accountType { get; set; }

        public List<Note> Notes { get; set; } = new List<Note>();

        private void RetriveNotes()
        {
            NoteRepository noteRepository = new NoteRepository();
            INoteManagerWeb noteManager = new NoteManager(noteRepository);

            List<Note> lLNotes = noteManager.ReadNotes();
            foreach (Note note in lLNotes)
            {
                Notes.Add(note);
            }
        }

        public void OnGet()
        {
            account = JsonSerializer.Deserialize(accountJson, Type.GetType(accountType)) as Account;
            this.RetriveNotes();
        }

        public void OnGetDelete()
        {
            NoteRepository noteRepository = new NoteRepository();
            INoteManagerWeb noteManager = new NoteManager(noteRepository);
            noteManager.DeleteNote(1, NoteId);
            this.RetriveNotes();
        }

        public IActionResult OnPostDelete()
        {
            return RedirectToPage("Content");
        }
    }
}
