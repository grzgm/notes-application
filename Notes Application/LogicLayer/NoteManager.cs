using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.DTOs;
using static System.Net.Mime.MediaTypeNames;

namespace LogicLayer
{
	public class NoteManager : INoteManagerWeb, INoteManagerDesktop
    {
		private int amountOfNotes;
		private int amountPinnedNotes;
		int amountPremiumNotes;


        private readonly NoteRepository noteRepository;


        public NoteManager(NoteRepository noteRepository)
        {
            this.noteRepository = noteRepository
                ?? throw new ArgumentNullException(nameof(noteRepository));
        }
		//public NoteManager()
		//{
		//	this.noteRepository = new NoteRepository();
		//	this.noteRepository = noteRepository
		//		?? throw new ArgumentNullException(nameof(noteRepository));
		//}

		public IEnumerable<Note> GetAll()
		{
			return new List<Note>();
		}
		 
/*		public int AmountOfNotes()
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

		public List<string> ListOfPremiumNotes(int userId)
		{
			throw new NotImplementedException();
		}*/

		public void CreateNote(int userId, string title, string text)
        {
            noteRepository.CreateNote(title, text);
        }

        public Note ReadNote()
        {
            throw new NotImplementedException();
        }
        public List<Note> ReadNotes()
        {
            List<Note> lLNotes = new List<Note>();
            List<NoteDTO> dLNotes = noteRepository.ReadNotes();
            foreach (NoteDTO note in dLNotes)
            {
                lLNotes.Add(new Note(note));
            }

            return lLNotes;
        }

        public void UpdateNote(int userId, int noteId, string title, string text)
        {
			noteRepository.UpdateNote(noteId, title, text);
        }

		public void DeleteNote(int userId, int noteId)
        {
            noteRepository.DeleteNote(noteId);
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

		List<Note> INoteManagerDesktop.DeleteNote(int userId, int noteId)
		{
			throw new NotImplementedException();
		}
	}
}
