using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		{}
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

        public int Id { get; private set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
