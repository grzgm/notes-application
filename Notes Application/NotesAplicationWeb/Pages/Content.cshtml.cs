using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LogicLayer;
using static System.Net.Mime.MediaTypeNames;

namespace NotesAplicationWeb.Pages
{
    public class ContentModel : PageModel
    {
        DALold dalOld = new DALold();
        [BindProperty(SupportsGet = true)]
        public string Title { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Text { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public List<Note> Notes { get; set; } = new List<Note>();
        public ContentModel()
        {
            //for(int i = 0; i < 4; i++)
            //{
            //    Notes.Add(new Note(i, "tytul["+i.ToString()+"]", "lorem Lorem ipsum dolor sit amet consectetur adipisicing elit. Accusantium perferendis voluptate bt consectetur adipisicing elit. Accusantium perferendis voluptate bt consectetur adipisicing elit. Accusantium perferendis voluptate bt consectetur adipisicing elit. Accusantium perferendis voluptate beatae. i tak dalej[" + i.ToString() + "]"));
            //}
            //dal.Connect();
            //List<List<string>> DBNotes;
            //DBNotes = dal.ReadNotes();
            //dal.Disconnet();
            //foreach (List<string> note in DBNotes)
            //{
            //    Notes.Add(new Note(int.Parse(note[0]), note[1],note[2]));
            //}
            //dal.Disconnet();
        }
        public void OnGet()
        {
            //if (Id != 0)
            //{
            //    if (Id < Notes.Count())
            //    {
            //        Notes[Id] = new Note(Id, Title, Text);
            //    }
            //    else if (Id == Notes.Count())
            //    {
            //        Notes.Add(new Note(Id, Title, Text));
            //    }

            //}
            dalOld.Connect();

            List<List<string>> DBNotes;
            DBNotes = dalOld.ReadNotes();
            foreach (List<string> note in DBNotes)
            {
                Notes.Add(new Note(int.Parse(note[0]), note[1], note[2]));
            }

            if (Id != 0)
            {
                if (Id < (Notes.Count()+1))
                {
                    dalOld.UpdateNote(Id, Title, Text);
                    Notes[Id-1] = new Note(Id, Title, Text);
                }
                else if (Id == Notes.Count())
                {
                    Notes.Add(new Note(Id, Title, Text));
                }

            }
            dalOld.Disconnet();
        }
    }
}
