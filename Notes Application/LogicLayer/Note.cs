using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer.DTOs;

namespace LogicLayer
{
    public class Note
    {
        private int id;
        private int userId;
        private string title;
        private string text;
        private DateTime creationDate;
        private DateTime editDate;

        public Note()
        { }
        public Note(NoteDTO noteDTO)
        {
            this.userId = noteDTO.UserId;
            this.id = noteDTO.Id;
            this.title = noteDTO.Title;
            this.text = noteDTO.Text;
        }
        public Note(int id, string title, string text)
        {
            this.id = id;
            this.title = title;
            this.text = text;
        }
		public Note(int userId, int id, string title, string text, DateTime creationDate, DateTime editDate)
		{
			this.userId = userId;
			this.id = id;
			this.title = title;
			this.text = text;
            this.creationDate = creationDate;
            this.editDate = editDate;
		}

        public override string ToString()
        {
            int titleLenght = 10;
            int textLenght = 20;
            if (title.Length < titleLenght)
                titleLenght = title.Length;
            if (text.Length < textLenght)
                textLenght = text.Length;
            return Title.Substring(0, titleLenght) + "; " + Text.Substring(0, textLenght);
        }

        public int UserId { get { return this.userId; }}
        public int Id { get { return this.id; } }
        public string Title { get { return this.title; } set { this.title = value; } }
        public string Text { get { return this.text; } set { this.text = value; } }
        public DateTime CreationDate { get { return this.creationDate; }}
        public DateTime EditDate { get { return this.editDate; } set { this.editDate = value; } }
    }
}
