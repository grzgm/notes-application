using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DTOs;

namespace LogicLayer
{
    public class Note
	{
		private int userId;
		private int id;
        private string title;
        private string text;
        private DateTime date;
        private DateTime editDate;

        public Note()
        { }
        public Note(NoteDTO noteDTO)
        {
            this.UserId = noteDTO.UserId;
            this.Id = noteDTO.Id;
            this.Title = noteDTO.Title;
            this.Text = noteDTO.Text;
        }
        public Note(int id, string title, string text)
        {
            this.Title = title;
            this.Text = text;
			this.Id = id;
        }
		public Note(int userId, int id, string title, string text, DateTime date, DateTime editDate)
		{
			this.userId = userId;
			this.Id = id;
			this.Title = title;
			this.Text = text;
            this.date = date;
            this.editDate = editDate;
		}

        public int UserId { get; private set; }
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
