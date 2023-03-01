using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
