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
		private int amountPremiumNotes;

        private readonly NoteRepository noteRepository;


        public NoteManager(NoteRepository noteRepository)
        {
            this.noteRepository = noteRepository
                ?? throw new ArgumentNullException(nameof(noteRepository));
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
            noteRepository.CreateNote(userId, title, text);
        }

        public Note ReadNote(int noteId, int userId)
        {
            throw new NotImplementedException();
        }
        public List<Note> ReadNotes(int userId)
        {
            List<Note> lLNotes = new List<Note>();
            List<NoteDTO> dLNotes = noteRepository.ReadNotes(userId);
            foreach (NoteDTO noteDTO in dLNotes)
            {
                lLNotes.Add(new Note(noteDTO));
            }

            return lLNotes;
        }

        public void UpdateNote(int noteId, int userId, string title, string text)
        {
			noteRepository.UpdateNote(noteId, userId, title, text);
        }

		public void DeleteNote(int noteId, int userId)
        {
            noteRepository.DeleteNote(noteId, userId);
        }

		public List<Note> GetListOfUserNotes(int userId)
		{
			throw new NotImplementedException();
		}

		public Note GetUserNote(int noteId, int userId)
        {
			throw new NotImplementedException();
		}

		public void UpdateNote(int noteId, int userId)
        {
			throw new NotImplementedException();
		}

		void INoteManagerDesktop.DeleteNote(int noteId, int userId)
		{
			throw new NotImplementedException();
		}
	}
}
