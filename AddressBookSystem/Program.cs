using System;
using System.Collections.Generic;
namespace AddressBookSystem
{
    /// <summary>
    /// To create and add contact details
    /// To Edit contacts
    /// To delete the contact
    /// </summary>
    class Program
    {
    //main Method-Calling the method present in AddrBook class by using switch case

            public static Dictionary<string, LinkedList<AddrBook.Person>> addressBook = new Dictionary<string, LinkedList<AddrBook.Person>>();
            static void Main(string[] args)
            {


                
            Console.WriteLine("Welcome to Address Book System!");
                Console.WriteLine("Enter the number of address books: ");
                int noOfAddressBook = Convert.ToInt32(Console.ReadLine());
                int noOfBooks = 0;
                while (noOfBooks < noOfAddressBook)
                {
                
                    Console.WriteLine("Enter the address book name : ");
                    string addressbookname = Console.ReadLine();
                    AddrBook addrBook = new AddrBook();
                    Console.WriteLine("Enter the no of contacts in the address book: ");
                    int noOfContact = Convert.ToInt32(Console.ReadLine());

                    while (noOfContact > 0)
                    {
                        Console.WriteLine("Enter the details of contact to be added: ");
                        addrBook.GetCustomer();
                        noOfContact--;
                        Console.WriteLine(" ");
                        addrBook.ListingPeople();
                    }
                    Console.WriteLine("1.To modify the details");
                    Console.WriteLine("2.To remove the details");
                    Console.WriteLine("3.Exit!");
                    //   int check = Convert.ToInt32(Console.ReadLine());
                    switch (Console.ReadLine())
                    {
                        case "1":
                            addrBook.Modify();
                            Console.WriteLine(" ");
                            addrBook.ListingPeople();
                            break;
                        case "2":
                            addrBook.RemovePeople();
                            Console.WriteLine(" ");
                            addrBook.ListingPeople();
                            break;
                        default:
                            Console.WriteLine("Enter valid option!");
                            break;


                    }
                    if (addressBook.ContainsKey(addressbookname))
                    {
                        Console.WriteLine("Existing address book name");
                        return;
                    }
                    else
                    {
                        addressBook.Add(addressbookname, addrBook.people);
                    }


                    noOfBooks++;
                }

                foreach (KeyValuePair<string, LinkedList<AddrBook.Person>> addr in addressBook)
                {
                    Console.WriteLine("The address Books are:{0}", addr.Key);

                }

            }
        }
