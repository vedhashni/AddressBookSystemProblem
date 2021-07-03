using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    /// <summary>
    /// To Create Contacts
    /// </summary>
    class AddressBook
    {
        public string FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email;
        public static List<AddressBook> Person = new List<AddressBook>();
       
        // Getting details of contacts
        public static void Getdetails()
        {
            AddressBook addressBook = new AddressBook();
            Console.WriteLine("Enter First Name : ");
             addressBook.FirstName= Console.ReadLine();
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

            Person.Add(addressBook);
        }
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
            if (Person.Count == 0)
            {
                Console.WriteLine("Your address book contacts are empty.");
                Console.ReadKey();
                return;
            }
            
            foreach (var addressBook in Person)
            {
                DisplayContact(addressBook);
            }
            Console.ReadKey();
        }
    }
}
