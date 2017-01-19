using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creat a address list and initializate it 
            AddressList addressList = new AddressList();
             addressList.MyAddressList = new List<AddressItem> 
                {
                    new AddressItem() { firstName = "John", lastName = "Lin", phone = 1234567890, address = "XXXXX", email = "XXXXX" },
                    new AddressItem() { firstName = "Mike", lastName = "Doe", phone = 1234567890, address = "XXXXX", email = "XXXXX" },
                    new AddressItem() { firstName = "Lily", lastName = "Doe", phone = 1234567890, address = "XXXXX", email = "XXXXX" }  
                };

            string entry = "";
            AddressItem item = new AddressItem();

            Console.WriteLine("Address Book");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1) View list");
            Console.WriteLine("2) Add address");
            Console.WriteLine("3) Search address");
            Console.WriteLine("4) Delete address");
            Console.WriteLine("5) Quit");

            while (true)
            {
                Console.WriteLine("Please select an option (1-4):");

                entry = Console.ReadLine();

                try
                {
                    switch (entry)
                    {
                        //Show address list
                        case "1":
                            Console.WriteLine("View list");
                            addressList.showAddressList();
                            break;

                        //Add new address
                        case "2":
                            item.firstName = getEntry("first name");
                            item.lastName = getEntry("last name");

                            item.phone = int.Parse(getEntry("phone name"));

                            item.address = getEntry("address name");
                            item.email = getEntry("email name");
                            addressList.AddAddress(item);
                            break;

                        //Search address
                        case "3":
                            string keyWord = getEntry("key word");
                            addressList.searchAddress(keyWord);
                            break;

                        //Delete address
                        case "4":
                            int itemNumber = int.Parse(getEntry("item number you want to delete"));
                            addressList.deleteAddress(itemNumber);
                            break;

                        //Quit the system
                        case "5":
                            Console.WriteLine("GoodBye");
                            break;
                    }
                    if (entry == "5")
                        break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid phone number");
                }
            }
        }

        //Get entry from the input
        public static string getEntry(string s)
        {
            Console.WriteLine("Please enter the " + s + " :");
            return Console.ReadLine();
        }
    }
}
