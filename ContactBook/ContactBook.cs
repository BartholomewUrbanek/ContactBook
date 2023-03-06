using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    internal class ContactBook
    {
        public Dictionary<string,Contact> contactBookDictionary;
        public ContactBook(Dictionary<string,Contact> contactBookDictionary)
        {
            this.contactBookDictionary = contactBookDictionary;
        }

        public void AddContact(Contact person)
        {
            if (contactBookDictionary.ContainsKey(person.contactNumber))
            {
                Console.WriteLine($"\n Contact with this number is already in phone book:");
                var existingContact = contactBookDictionary[person.contactNumber];
                Console.WriteLine($"\n\n{existingContact.firstName} {existingContact.lastName} {existingContact.contactNumber}");
            }
            else
            {
                contactBookDictionary.Add(person.contactNumber, person);
                Console.WriteLine("\n Contact added to phone book.");
            }

        }

        public void DeleteContact(string numberToRemove)
        {
            if (contactBookDictionary.ContainsKey(numberToRemove))
            {
                contactBookDictionary.Remove(numberToRemove);
            }
            else
            {
                Console.WriteLine("There is no contact with given number, please check data and try again.");
            }

        }

        
    }
}

