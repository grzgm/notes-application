using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.DTOs
{
    public class AccountDTO
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public int? AmountOfNotes
        {
            get;
            set;
        }
        public int? MaxAmountOfNotes
        {
            get;
            set;
        }
        public int? MaxLengthOfNotes
        {
            get;
            set;
        }
        public DateTime? StartPremiumDate
        {
            get;
            set;
        }
        public DateTime? EndPremiumDate
        {
            get;
            set;
        }
        public string Role
        {
            get;
            set;
        }
    }
}
