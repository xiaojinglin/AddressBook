using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {

             AddressItem[] addressList =
                {
                    new AddressItem("John", "Doe", "1234567890", "XXXXX", "XXXXX"),
                    new AddressItem("Mike", "Doe", "1234567890", "XXXXX", "XXXXX"),
                    new AddressItem("Lily", "Doe", "1234567890", "XXXXX", "XXXXX")  
                };

            string entry = "";

            Console.WriteLine("Address Book");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1) View list");
            Console.WriteLine("2) Add address");
            Console.WriteLine("3) Search address");
            Console.WriteLine("4) Quit");

            while (true)
            {
                Console.WriteLine("Please select an option (1-4):");

                entry = Console.ReadLine();

                //Enter 4 to exit the program
                if(entry == "4")
                {
                    Console.WriteLine("GoodBye");

                    break;
                }

                //Enter 1 to view the address book
                else if (entry == "1")
                {
                    Console.WriteLine("View list");

                    foreach(AddressItem addressItem in addressList)
                    {
                        Console.WriteLine(addressItem.firstName +" " + 
                                          addressItem.lastName + ", " +
                                          addressItem.phone + ", " +
                                          addressItem.address + ", " +
                                          addressItem.email);
                    }
                }

                //Enter 2 to add new address to the address book
                else if (entry == "2")
                {
                    Console.WriteLine("Add address");

                    //Get the new address
                    Console.WriteLine("Please enter the first name: ");
                    string first = Console.ReadLine();

                    Console.WriteLine("Please enter the last name: ");
                    string last = Console.ReadLine();

                    Console.WriteLine("Please enter the phone number: ");
                    string phone = Console.ReadLine();

                    Console.WriteLine("Please enter the address: ");
                    string address = Console.ReadLine();

                    Console.WriteLine("Please enter email: ");
                    string email = Console.ReadLine();

                    //put the new address in a array
                    AddressItem[] newItem = { new AddressItem(first, last, phone, address, email) };

                    //assign a new array to concate the old and new address together
                    AddressItem[] newAddress = new AddressItem[addressList.Length + 1];

                    addressList.CopyTo(newAddress, 0);
                    newItem.CopyTo(newAddress, addressList.Length);

                    //update the old address book
                    addressList = new AddressItem[newAddress.Length];
                    newAddress.CopyTo(addressList,0);

                }

                //Enter 3 to search address
                else if (entry == "3")
                {
                    Console.WriteLine("Search address");
                    Console.WriteLine("Please enter a key word: ");

                    string keyWord = Console.ReadLine();
                    int count = 0;

                    foreach(AddressItem addressItem in addressList)
                    {
                        //Check whether there's any address contains the keyword
                        if(addressItem.firstName.ToLower().Contains(keyWord.ToLower())||
                           addressItem.lastName.ToLower().Contains(keyWord.ToLower()) ||
                           addressItem.phone.ToLower().Contains(keyWord.ToLower()) ||
                           addressItem.address.ToLower().Contains(keyWord.ToLower()) ||
                           addressItem.email.ToLower().Contains(keyWord.ToLower()))
                        {
                            count++;

                            Console.WriteLine(addressItem.firstName + " " + 
                                              addressItem.lastName + ", " +
                                              addressItem.phone + ", " +
                                              addressItem.address + ", " +
                                              addressItem.email);
                        }
                    }
                    if (count == 0)
                        Console.WriteLine("Sorry! Can't find the address you are looking for!");
                }
                else
                {
                    Console.WriteLine("Your entry is not valid!");
                }

            }
        }
    }
}
