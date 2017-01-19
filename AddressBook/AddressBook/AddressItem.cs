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
            //Sort order by last name
            return lastName.CompareTo(other.lastName);
        }

        //Show address details
        public void showAddressItem()
        {
            Console.WriteLine(this.firstName + " " + this.lastName + " " + this.phone + " " + this.address + " " + this.email);
        }
        
    }

    //Sort order by first name
    class LastComparer : IComparer<AddressItem>
    {
        public int Compare(AddressItem x, AddressItem y)
        {
            return x.firstName .CompareTo(y.firstName);
        }
    }

}
