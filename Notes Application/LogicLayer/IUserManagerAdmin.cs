using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public interface IUserManagerAdmin
    {
        void ChangePremiumStatus(int id);
        void ChangeMaxAmountOfNotes(int id);
        void ChangeMaxLengthOfNotes(int id);
        int AmountOfUsers();
        int AmountOfPremiumUsers();

    }
}
