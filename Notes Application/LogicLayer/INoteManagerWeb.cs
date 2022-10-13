using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
	public interface INoteManagerWeb
	{
        void CreateNote(int userId, string title, string text);
        Note ReadNote(int noteId, int userId);
        List<Note> ReadNotes(int userId);
        void UpdateNote(int noteId, int userId, string title, string text);
        //List<Note> UpdateNote(int userId, int noteId, string text);
        //List<Note> UpdateNote(int userId, int noteId, string title);
        void DeleteNote(int noteId, int userId);
    }
}
