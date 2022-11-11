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
        void CreateNote(int userId, string title, string text);
        List<NoteDTO> ReadNotes(int userId);
        void UpdateNote(int noteId, int userId, string title, string text);
        void DeleteNote(int noteId, int userId);

    }
}
