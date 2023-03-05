namespace ContactBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string phoneBookPatch = currentDirectory + @"\phoneBook.csv";
            ContactValidator contactValidator = new ContactValidator();
            FileHandler fileHandler = new FileHandler();
            var dictionary = fileHandler.readFile(phoneBookPatch);
            ContactBook contactBook = new ContactBook(dictionary);
            OptionController optionController = new OptionController(contactBook);

            bool menuControl = false;

            while (menuControl != true)
            {
                Console.WriteLine("\n Choose option: \n 1.Add new contact to book. \n 2.Delete contact from book. \n 3.Display all contacts. \n 4.Search for contact.  \n 5.Exit.");

                int menuChoice = 0;
                int.TryParse(Console.ReadLine(), out menuChoice);

                switch (menuChoice)
                {
                    case 1:
                        optionController.AddContact();
                        break;

                    case 2:
                        optionController.DeleteContact();
                        break;
                    case 3:
                        optionController.DisplayAllContacts();
                        break;
                    case 4:
                        optionController.DisplayByName();
                        break;
                    case 5:
                        fileHandler.saveToFile(phoneBookPatch, dictionary);
                        menuControl = true;
                        break;
                    default:
                        Console.WriteLine("Option you want to choose not found.");
                        break;




                }
            }

        }
    }
}

