namespace ContactBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string phoneBookPatch = currentDirectory + @"\phoneBook.csv";

            Dictionary<string, Contact> contactBookDictionary = new Dictionary<string, Contact>();

            AddDeleteContact currentContact = new AddDeleteContact();

            bool menuControl = false;

            while(menuControl != true)
            {
                Console.WriteLine("\n Choose option: \n 1.Add new contact to book. \n 2.Delete contact from book. \n 3.Display all contacts. \n 4.Save to file. \n 5.Exit." );

                int menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        Contact contact1 = new Contact(String.Empty, String.Empty, String.Empty);
                        Console.WriteLine("Imput first name.");
                        contact1.firstName = Console.ReadLine().ToUpper();
                        Console.WriteLine("Imput last name.");
                        contact1.lastName = Console.ReadLine().ToUpper();
                        Console.WriteLine("Imput phone number in format XXX-XXX-XXX");
                        contact1.contactNumber = Console.ReadLine();
                        currentContact.AddContact(contact1, contactBookDictionary);
                        break;

                    case 2:
                        Console.WriteLine("Imput number to delete from the book.");
                        string numberToDelete = Console.ReadLine();
                        currentContact.DeleteContact(numberToDelete,contactBookDictionary);
                        break;
                    case 3:
                        foreach (KeyValuePair<string, Contact> entry in contactBookDictionary)
                        {
                            Console.WriteLine($"{ entry.Key} {entry.Value.firstName} {entry.Value.lastName}");
                        }
                        break;
                    case 4:
                        foreach (KeyValuePair<string, Contact> entry in contactBookDictionary)
                        {
                            string lineToSave = ($"{ entry.Key},{entry.Value.firstName},{entry.Value.lastName}");
                            using (StreamWriter sw = File.AppendText(phoneBookPatch))
                            {
                                sw.WriteLine(lineToSave);
                            }
                        }
                        break;
                    case 5:
                        menuControl = true;
                        break;
                }
            }

        }
    }
}

