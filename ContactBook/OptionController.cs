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
            var kvp = new KeyValuePair<string, Contact>(numberToDelete, contactBook.contactBookDictionary.GetValueOrDefault(numberToDelete));
            Console.WriteLine($"\n\nAre you sure you want to delete following contact? [Y/N] \n{kvp.Key} {kvp.Value.firstName} {kvp.Value.lastName}");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "y") contactBook.DeleteContact(numberToDelete);
        }

        public void DisplayAllContacts()
        {
            foreach (KeyValuePair<string, Contact> entry in contactBook.contactBookDictionary)
            {
                Console.WriteLine($"{ entry.Key} {entry.Value.firstName} {entry.Value.lastName}");
            }
        }

        public void DisplayByName()
        {
            List<string> contactList = new List<string>();
            Console.WriteLine("What is the name or number of the person you are looking for?");
            string userInput = Console.ReadLine().ToLower();
            foreach (KeyValuePair<string, Contact> entry in contactBook.contactBookDictionary)
            {
                string fullName = entry.Value.firstName + " " + entry.Value.lastName;

                // If full name user input is firstName + lastName it is working, if lastName+firstName isnt. 
                if (entry.Value.firstName.ToLower().Contains(userInput) | entry.Value.lastName.ToLower().Contains(userInput) | fullName.ToLower().Contains(userInput) | entry.Value.contactNumber == userInput)
                {
                    contactList.Add($"{entry.Key} {entry.Value.firstName} {entry.Value.lastName}");
                }
            }
            if (contactList.Count != 0)
            {
                Console.WriteLine("\nHere is a list of all contacts matching your request:");
                foreach (string contact in contactList)
                {
                    Console.WriteLine(contact);
                }
            }
            else
            {
                Console.WriteLine("\nThere are no contacts in the phone book that match your request.");
            }
        }
    }
}
