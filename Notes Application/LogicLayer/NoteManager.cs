using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer.DTOs;
using static System.Net.Mime.MediaTypeNames;

namespace LogicLayer
{
	public class NoteManager : INoteManager
    {
        private readonly INoteRepository noteRepository;
        public NoteManager(INoteRepository noteRepository)
        {
            this.noteRepository = noteRepository
                ?? throw new ArgumentNullException(nameof(noteRepository));
        }
		public void CreateNote(int userId, string title, string text)
        {
            noteRepository.CreateNote(userId, title, text);
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
	}
}
