using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace LogicLayer
{
	public class NoteManager : INoteManagerDesktop, INoteManagerWeb
	{
		private int amountOfNotes;
		private int amountPinnedNotes;
		private static int noteIdCounter;
		int amountPremiumNotes;
		private List<List<Note>> usersNotes;

		private readonly NoteRepository noteRepository; //MÓJ dal ale tylko dla notes


		public NoteManager(NoteRepository noteRepository)
		{
			this.noteRepository = noteRepository
				?? throw new ArgumentNullException(nameof(noteRepository));
		}

		public IEnumerable<Note> GetAll()
		{
			return new List<Note>();
		}
		 
		public int AmountOfNotes()
		{
			throw new NotImplementedException();
		}

		public int AmountPinnedNotes()
		{
			throw new NotImplementedException();
		}

		public int AmountPremiumNotes()
		{
			throw new NotImplementedException();
		}

		public List<string> ListOfUserNotes(int userId)
		{
			throw new NotImplementedException();
		}

		public List<string> ListOfPremiumNotes(int userId)
		{
			throw new NotImplementedException();
		}

		public List<Note> GetListOfUserNotes(int userId)
		{
			throw new NotImplementedException();
		}

		public Note GetUserNote(int userId, int noteId)
		{
			throw new NotImplementedException();
		}

		public List<Note> ReadNote(int userId, int noteId)
		{
			throw new NotImplementedException();
		}

		public List<Note> UpdateNote(int userId, int noteId)
		{
			throw new NotImplementedException();
		}

		public List<Note> DeleteNote(int userId, int noteId)
		{
			throw new NotImplementedException();
		}

		public List<Note> GetListOfNotes()
		{
			throw new NotImplementedException();
		}

		public Note GetNote()
		{
			throw new NotImplementedException();
		}

		public List<Note> CreateNote()
		{
			throw new NotImplementedException();
		}

		public List<Note> ReadNote()
		{
			throw new NotImplementedException();
		}

		public List<Note> UpdateNote()
		{
			throw new NotImplementedException();
		}

		public List<Note> DeleteNote()
		{
			throw new NotImplementedException();
		}
	}
}
