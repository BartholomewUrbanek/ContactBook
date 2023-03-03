using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    internal class OptionController
    {
        private ContactValidator contactValidator;
        private ContactBook contactBook;

        public OptionController(ContactBook contactBook)
        {
            this.contactBook = contactBook;    
            contactValidator = new ContactValidator();
        }

        public void AddContact()
        {
            Contact newContact = new Contact(String.Empty, String.Empty, String.Empty);
            string userInput;

            while (newContact.firstName == String.Empty)
            {
                Console.WriteLine("Imput first name.");
                userInput = Console.ReadLine();
                if (contactValidator.isNameValid(userInput) == true)
                {
                    newContact.firstName = userInput;
                }
                else
                {
                    Console.WriteLine("First name must be at least three characters long and contains only letters.");
                }
            }

            while (newContact.lastName == String.Empty)
            {
                Console.WriteLine("Imput last name.");
                userInput = Console.ReadLine();
                if (contactValidator.isNameValid(userInput) == true)
                {
                    newContact.lastName = userInput;
                }
                else
                {
                    Console.WriteLine("Last name must be at least three characters long and contains only letters.");
                }
            }

            while (newContact.contactNumber == String.Empty)
            {
                Console.WriteLine("Imput phone number in format XXX-XXX-XXX");
                userInput = Console.ReadLine();
                if (contactValidator.isPhoneNumberValid(userInput) == true)
                {
                    newContact.contactNumber = userInput;
                }
                else
                {
                    Console.WriteLine("Phone number must be in format XXX-XXX-XXX.");
                }
            }
            contactBook.AddContact(newContact);
        }

        public void DeleteContact()
        {
            Console.WriteLine("Imput number to delete from the book.");
            string numberToDelete = Console.ReadLine();
            contactBook.DeleteContact(numberToDelete);
        }

        
    }
}
