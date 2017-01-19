using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    
    public class AddressItem : IComparable<AddressItem>
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int phone { get; set; }
        public string address { get; set; }
        public string email { get; set; }

        public int CompareTo(AddressItem other)
        {
            //Sort order first by last name, then by first.
            return (this.lastName+this.firstName).CompareTo(other.lastName+other.firstName);
        }

        //Show address details
        public void showAddressItem()
        {
            Console.WriteLine(this.firstName + " " + this.lastName + " " + this.phone + " " + this.address + " " + this.email);
        }       
    }
}
