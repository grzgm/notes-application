using LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class NotesTestWeb
    {
        private INoteRepository noteRepository;
        private INoteManager noteManager;

        [TestMethod]
        public void CreatingCorrectNote()
        {
            // Arrange
            noteRepository = new FakeNoteDB();
            noteManager = new NoteManager(noteRepository);

            // Act
            noteManager.CreateNote(1, "TitleUnitTest", "TextUnitTest");
        }

        [TestMethod]
        public void CorrectReadingNotes()
        {
            // Arrange
            noteRepository = new FakeNoteDB();
            noteManager = new NoteManager(noteRepository);
            List<Note> notes;

            // Act
            notes = noteManager.ReadNotes(1);

            // Assert
            Assert.AreEqual(0, notes.Count);
        }

        // Assert
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void IncorrectReadingNotes()
        {
            // Arrange
            noteRepository = new FakeNoteDB();
            noteManager = new NoteManager(noteRepository);
            List<Note> notes;

            // Act
            notes = noteManager.ReadNotes(0);
        }
    }
}
