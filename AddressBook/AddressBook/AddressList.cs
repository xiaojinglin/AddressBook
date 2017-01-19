using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressList
    {
        public List<AddressItem> MyAddressList { get; set; }

        //Show the address list
        public void showAddressList()
        {
            MyAddressList.Sort();
            int itemNumber = 1;
            foreach(AddressItem item in MyAddressList)
            {
                Console.Write(itemNumber++ + ". ");
                item.showAddressItem();
            }
        }

        //Add a new address item
        public void AddAddress(AddressItem item)
        {
            //Check whether the address we want to add to the list is a duplicated one
            AddressItem result = MyAddressList.Find(
                  delegate (AddressItem a)
                  {
                      return this.sameString(a.firstName, item.firstName) && 
                             this.sameString(a.lastName, item.lastName) &&
                             a.phone == item.phone &&
                             this.sameString(a.address, item.address) &&
                             this.sameString(a.email, item.email); 
                  });

            if (result == null)
            {
                MyAddressList.Add(item);
                Console.WriteLine("You Just successfully added a new address.");
            }
            else
            {
                Console.WriteLine("You have this todo in the list already.");
            }
        }

        //Search address items
        public void searchAddress(string keyWord)
        {
            string s = "";
            foreach(AddressItem item in MyAddressList)
            {
                int count = 0;
                s = item.firstName + item.lastName + item.phone.ToString() + item.address + item.email;
                if(s.ToLower().Contains(keyWord.ToLower()))
                {
                    item.showAddressItem();
                    count++;
                }
                Console.WriteLine("Find " + count + "items");
            }
        }

        //Delete address
        public void deleteAddress(int itemNumber)
        {
            if(MyAddressList .Count >itemNumber -1 )
            {
                MyAddressList.RemoveAt(itemNumber - 1);
                Console.WriteLine("You Just successfully deleted a new address!");
            }
            else
            {
                Console.WriteLine("You item number you enter does not exist!" + itemNumber);
            }
        }

        // Compare two string with space careless
        public bool sameString(string a, string b)
        {
            return a.Replace(" ", "").ToLower() == b.Replace(" ", "").ToLower();
        }
    }  
}
