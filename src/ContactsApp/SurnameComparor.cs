using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class SurnameComparer : IComparer<Contact>
    {
        public int Compare(Contact a, Contact b)
        {
            string aContact = a.Surname + a.Name;
            string bContact = b.Surname + b.Name;

            return string.Compare(aContact, bContact);
        }
    }
}
