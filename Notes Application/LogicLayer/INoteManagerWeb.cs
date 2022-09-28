using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
	public interface INoteManagerWeb
	{
		Note GetNote();
        void CreateNote(int userId, string title, string text);
        List<Note> ReadNote(int userId, int noteId);
        void UpdateNote(int userId, int noteId, string title, string text);
        //List<Note> UpdateNote(int userId, int noteId, string text);
        //List<Note> UpdateNote(int userId, int noteId, string title);
        List<Note> DeleteNote(int userId, int noteId);
    }
}
