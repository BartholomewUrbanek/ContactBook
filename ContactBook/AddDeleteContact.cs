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
            if (dict.ContainsKey(person.contactNumber))
            {
                Console.WriteLine($"\n Contact with this number is already in phone book:" );
                var existingContact = dict[person.contactNumber];
                Console.WriteLine($"\n\n{existingContact.firstName} {existingContact.lastName} {existingContact.contactNumber}");
            }
            else
            {
                dict.Add(person.contactNumber, person);
                Console.WriteLine("\n Contact added to phone book.");
            }
            
        }

        public void DeleteContact(string numberToRemove, Dictionary<string,Contact> dict)
        {
            if (dict.ContainsKey(numberToRemove))
            {
                dict.Remove(numberToRemove);
            }
            else
            {
                Console.WriteLine("There is no contact with given number, please check data and try again.");
            }
            
        }
    }
}
