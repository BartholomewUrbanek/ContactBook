using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ContactBook
{
    internal class ContactValidator
    {
        const string NamePattern = "^[a-zA-Z]{3,}$";
        const string PhonePattern = "^[0-9]{3}-[0-9]{3}-[0-9]{3}$";
        public bool isNameValid(string name)
        {
            return Regex.IsMatch(name,NamePattern);
        }

        public bool isPhoneNumberValid(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, PhonePattern);
        }
    }
}
