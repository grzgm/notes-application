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

		Note GetUserNote(int noteId, int userId);

        Note ReadNote(int noteId, int userId);

		void UpdateNote(int noteId, int userId);

        void DeleteNote(int noteId, int userId);
    }
}
