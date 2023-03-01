using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    internal class AddDeleteContact

    {
        public void AddContact(Contact person, Dictionary <string, Contact> dict)
        {
            dict.Add(person.contactNumber, person);
        }

        public void DeleteContact(string numberToRemove, Dictionary<string,Contact> dict)
        {
            dict.Remove(numberToRemove);
        }
    }
}
