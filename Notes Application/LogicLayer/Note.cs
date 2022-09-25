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
		public string title;
		public DateTime date;
		public string text;
		public DateTime editDate;

		public Note()
		{

		}
		public Note(string title, string text, int id)
        {
            this.title = title;
            this.text = text;
			this.Id = id;
        }
		public Note(int userId, int id, string title, DateTime date, string text, DateTime editDate)
		{
			this.userId = userId;
			this.Id = id;
			this.title = title;
			this.date = date;
			this.text = text;
			this.editDate = editDate;
		}

		public int Id { get; private set; }
	}
}
