using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
	public interface INoteManagerWeb
	{
		List<Note> GetListOfNotes();

		Note GetNote();

		List<Note> CreateNote();

		List<Note> ReadNote();

		List<Note> UpdateNote();

		List<Note> DeleteNote();
	}
}
