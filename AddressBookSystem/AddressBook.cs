using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    /// <summary>
    /// To Create Contacts
    /// To Add Contacts
    /// To Edit Contacts
    /// To delete contact
    /// </summary>
    class AddressBook
    {
        public string FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email;
        public static List<AddressBook> person = new List<AddressBook>();

        // Getting details of contacts
        public static void Getdetails()
        {
            
                AddressBook addressBook = new AddressBook();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter First Name : ");
                addressBook.FirstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name : ");
                addressBook.LastName = Console.ReadLine();
                Console.WriteLine("Enter Address: ");
                addressBook.Address = Console.ReadLine();
                Console.WriteLine("Enter City : ");
                addressBook.City = Console.ReadLine();
                Console.WriteLine("Enter State : ");
                addressBook.State = Console.ReadLine();
                Console.WriteLine("Enter Zip code : ");
                addressBook.Zip = Console.ReadLine();
                Console.WriteLine("Enter Phone Number : ");
                addressBook.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Enter Email : ");
                addressBook.Email = Console.ReadLine();

                person.Add(addressBook);
            }
        }

        // Contact Details are displayed
        public static void DisplayContact(AddressBook addressBook)
        {
            Console.WriteLine("First Name: " + addressBook.FirstName);
            Console.WriteLine("Last Name: " + addressBook.LastName);
            Console.WriteLine("Phone Number: " + addressBook.PhoneNumber);
            Console.WriteLine("Address : " + addressBook.Address);
            Console.WriteLine("City : " + addressBook.City);
            Console.WriteLine("State : " + addressBook.State);
            Console.WriteLine("ZipCode : " + addressBook.Zip);
            Console.WriteLine("Phone Number: " + addressBook.PhoneNumber);
            Console.WriteLine("EmailId: " + addressBook.Email);

        }
        public static void AddContact()
        {
            if (person.Count == 0)
            {
                Console.WriteLine("Your address book contacts are empty.");
                Console.ReadKey();
                return;
            }

            foreach (var addressBook in person)
            {
                DisplayContact(addressBook);
            }
            Console.ReadKey();
        }

        // Function is used to edit the contacts 
        public static void EditCon()
        {
            if (person.Count != 0)
            {
                string Modifyone = Console.ReadLine();
                foreach (var addressBook in person)
                {
                    if (addressBook.Equals(Modifyone))
                    {
                        while (true)
                        {
                            int ToChange = Convert.ToInt32(Console.ReadLine());
                            switch (ToChange)
                            {
                                case 1:
                                    Console.WriteLine("Enter the First Name: ");
                                    addressBook.FirstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the Last Name: ");
                                    addressBook.LastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the Phone Number: ");
                                    addressBook.PhoneNumber = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the Address: ");
                                    addressBook.Address = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter the City: ");
                                    addressBook.City = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter the State: ");
                                    addressBook.State = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter the Pin Code: ");
                                    addressBook.Zip = Console.ReadLine();
                                    break;
                                case 8:
                                    Console.WriteLine("Enter the Email: ");
                                    addressBook.Email = Console.ReadLine();
                                    break;

                                case 9:
                                    return;

                                default:
                                    break;

                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid Phone Number");
                    }
                }
            }
        }
        // Function to delete the contact

        public static void DeleteCon()
        {
            string ToRemove = Console.ReadLine();
            foreach (var addressBook in person)
            {
                if (addressBook.Equals(ToRemove))
                {
                    // Contact is deleted
                    person.Remove(addressBook);

                }
                else
                {
                    Console.WriteLine("Contact is not found");
                }
            }
        }
    }
}
          

