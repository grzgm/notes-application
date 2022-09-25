using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LogicLayer;

namespace NotesAplicationWeb.Pages
{
    public class ContentModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Title { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Text { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public List<Note> Notes { get; set; } = new List<Note>();
        public ContentModel()
        {
            for(int i = 0; i < 2; i++)
            {
                Notes.Add(new Note(i, "tytul["+i.ToString()+"]", "lorem Lorem ipsum dolor sit amet consectetur adipisicing elit. Accusantium perferendis voluptate bt consectetur adipisicing elit. Accusantium perferendis voluptate bt consectetur adipisicing elit. Accusantium perferendis voluptate bt consectetur adipisicing elit. Accusantium perferendis voluptate beatae. i tak dalej[" + i.ToString() + "]"));
            }
        }
        public void OnGet()
        {
            if (Id != 0)
            {
                for(int i = 0; i < Notes.Count; i++)
                {
                    if(Notes[i].Id == Id)
                    {
                        Notes[i] = new Note(Id, Title, Text);
                    }
                }
            }
        }
    }
}