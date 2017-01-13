using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressItem
    {
        public readonly string firstName;
        public readonly string lastName;
        public readonly string phone;
        public readonly string address;
        public readonly string email;

        public AddressItem (string firstName, string lastName, string phone, string address, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.address = address;
            this.email = email;
        }

    }
}
