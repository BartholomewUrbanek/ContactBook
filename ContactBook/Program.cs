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
                Console.WriteLine("\n Choose option: \n 1.Add new contact to book. \n 2.Delete contact from book. \n 3.Display all contacts. \n 4.Exit.");

                int menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        optionController.AddContact();
                        break;

                    case 2:
                        optionController.DeleteContact();
                        break;
                    case 3:
                        foreach (KeyValuePair<string, Contact> entry in dictionary)
                        {
                            Console.WriteLine($"{ entry.Key} {entry.Value.firstName} {entry.Value.lastName}");
                        }
                        break;
                    case 4:
                        fileHandler.saveToFile(phoneBookPatch, dictionary);
                        menuControl = true;
                        break;





                }
            }

        }
    }
}

