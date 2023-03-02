using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ContactBook
{
    internal class Contact
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string contactNumber { get; set; }

        public Contact(string firstName, string lastName, string contactNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.contactNumber = contactNumber;
        }

        
        public bool checkNameFormating(string name)
        {
            string namePattern = "[a-zA-Z]{3,}";
            bool isNameMatchPattern = Regex.IsMatch(name, namePattern);
            if (isNameMatchPattern) return true;
            return false;
        }

        public bool checkPhoneNumberFormating(string phoneNumber)
        {
            string phoneNumberPattern = "[0-9]{3}-[0-9]{3}-[0-9]{3}";
            bool isNumberMatchPattern = Regex.IsMatch(phoneNumber, phoneNumberPattern);
            if(isNumberMatchPattern) return true;
            return false;
        }

    }
}
