using LogicLayer;
using LogicLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace UnitTestProject
{
    internal class FakeNoteDB : INoteRepository
    {
        private int amountOfSuccessfullMethodsCalls = 0;
        public int AmountOfSuccessfullMethodsCalls
        { get { return amountOfSuccessfullMethodsCalls; } }
        public void CreateNote(int userId, string title, string text)
        {
            if(!(userId > 0 && title != null && text != null))
            {
                throw new Exception();
            }
            amountOfSuccessfullMethodsCalls++;
        }
        public List<NoteDTO> ReadNotes(int userId)
        {
            if (userId > 0)
            {
                return new List<NoteDTO>();
            }

            throw new Exception();
        }
        public void UpdateNote(int noteId, int userId, string title, string text)
        {
        }
        public void DeleteNote(int noteId, int userId)
        {
        }
    }
}
