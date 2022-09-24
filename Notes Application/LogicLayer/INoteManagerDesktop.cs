using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
	public interface INoteManagerDesktop
	{
		List<Note> GetListOfUserNotes(int userId);

		Note GetUserNote(int userId, int noteId);

		List<Note> ReadNote(int userId, int noteId);

		List<Note> UpdateNote(int userId, int noteId);

		List<Note> DeleteNote(int userId, int noteId);
	}
}
