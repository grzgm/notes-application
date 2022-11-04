using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer.DTOs;

namespace LogicLayer
{
    public interface INoteRepository
    {
        public void CreateNote(int userId, string title, string text);
        public List<NoteDTO> ReadNotes(int userId);
        public void UpdateNote(int noteId, int userId, string title, string text);
        public void DeleteNote(int noteId, int userId);

    }
}
