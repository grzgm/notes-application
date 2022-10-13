using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LogicLayer;
using static System.Net.Mime.MediaTypeNames;
using DataLayer;
using System.Text.Json;
using System.Linq.Expressions;

namespace NotesAplicationWeb.Pages
{
    public class ContentModel : PageModel
    {
        public Account account;

        [BindProperty(SupportsGet = true)]
        public string accountJson { get; set; }

        [BindProperty(SupportsGet = true)]
        public string accountType { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Title { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Text { get; set; }

        [BindProperty(SupportsGet = true)]
        public int NoteId { get; set; }

        public List<Note> Notes { get; set; } = new List<Note>();

        private void RetriveNotes()
        {
            NoteRepository noteRepository = new NoteRepository();
            INoteManagerWeb noteManager = new NoteManager(noteRepository);

            List<Note> lLNotes = noteManager.ReadNotes(account.Id);
            foreach (Note note in lLNotes)
            {
                Notes.Add(note);
            }
        }

        public IActionResult OnGet()
        {
            GetJsonAccount();
            if(account == null)
                return RedirectToPage("Index");
            this.RetriveNotes();
            return Page();
        }

        public IActionResult OnGetDelete()
        {
            GetJsonAccount();
            if (account == null)
                return RedirectToPage("Index");
            NoteRepository noteRepository = new NoteRepository();
            INoteManagerWeb noteManager = new NoteManager(noteRepository);
            noteManager.DeleteNote(NoteId, account.Id);
            this.RetriveNotes();
            return Page();
        }

        public IActionResult OnPostDelete()
        {
            return RedirectToPage("Content");
        }

        public void GetJsonAccount()
        {
            if (HttpContext.Session.Get("accountJson") == null)
                return;

            switch (HttpContext.Session.GetString("accountType"))
            {
                case "LogicLayer.User":
                    account = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("accountJson"));
                    break;
                case "LogicLayer.PremiumUser":
                    account = JsonSerializer.Deserialize<PremiumUser>(HttpContext.Session.GetString("accountJson"));
                    break;
                case "LogicLayer.Admin":
                    account = JsonSerializer.Deserialize<Admin>(HttpContext.Session.GetString("accountJson"));
                    break;
                default:
                    throw new NotImplementedException();
                    break;
            }
            //account = JsonSerializer.Deserialize(accountJson, Type.GetType(accountType)) as Account;

            // Disabling Nav Links
            ViewData["accountJson"] = accountJson;
        }
    }
}
