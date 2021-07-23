using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace AddressBookSystem
{
    /// <summary>
    /// To Create Contacts
    /// To Add Contacts
    /// To Edit Contacts
    /// To delete contact
    /// </summary>
    public interface IAddressBookSystem
    {
        //void GetCustomer();

        void ListingPeople();
        void RemovePeople();
    }
    // Getting details of contacts
    public class AddrBook : IAddressBookSystem
    {
        public List<AddrBook> people;
        public AddrBook()
        {
            people = new List<AddrBook>();
        }

        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public string Addresses;
        public string City;
        public string State;
        public string ZipCode;
        public string PhoneNum;
        public string EmailId;

        public AddrBook(string FirstName, string LastName, string Addresses, string City, string State, string ZipCode, string PhoneNum, string EmailId)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Addresses = Addresses;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;
            this.PhoneNum= PhoneNum;
            this.EmailId = EmailId;

        }

        public void GetCustomer(string firstName, string lastName, string phoneNum, string address, string city, string state, string zipCode, string emailId)
        {
            AddrBook person = new AddrBook(firstName, lastName, phoneNum, address, city, state, zipCode, emailId);
            if (people.Count == 0)
            {
                people.Add(person);
            }
            else
            {
                AddrBook people = this.people.Find(a => a.FirstName.Equals(firstName));
                if (people == null)
                {
                    AddrBook p = new AddrBook(firstName, lastName, address, city, state, phoneNum, zipCode, emailId);
                    this.people.Add(p);
                }
                else
                {
                    Console.WriteLine("record is already exists");
                }
            }
        }



  public void PrintCustomer(AddrBook person)
    {
        Console.WriteLine("First Name: " + person.FirstName);
        Console.WriteLine("Last Name: " + person.LastName);
        Console.WriteLine("Phone Number: " + person.PhoneNumber);
        Console.WriteLine("Address : " + person.Addresses);
        Console.WriteLine("City : " + person.City);
        Console.WriteLine("State : " + person.State);
        Console.WriteLine("ZipCode : " + person.ZipCode);
        Console.WriteLine("Phone Number: " + person.PhoneNum);
        Console.WriteLine("Email Id: " + person.EmailId);
        Console.WriteLine("-------------------------------------------");
    }
    //Modify the details
   
        public void Modify()
    {
        if (people.Count != 0)
        {
            Console.WriteLine("Enter the contact to modify:");
            string Modified = Console.ReadLine();
            foreach (var person in people)
            {
                if (person.FirstName.ToUpper() == Modified.ToUpper())
                {
                    while (true)
                    {
                        Console.WriteLine("Enter the option to modify the property: ");
                        Console.WriteLine("Enter 1 to Change First name ");
                        Console.WriteLine("Enter 2 to Change Last name ");
                        Console.WriteLine("Enter 3 to Change Phone Number ");
                        Console.WriteLine("Enter 4 to Change Address ");
                        Console.WriteLine("Enter 5 to Change City ");
                        Console.WriteLine("Enter 6 to Change State ");
                        Console.WriteLine("Enter 7 to Change Pincode ");
                        Console.WriteLine("Enter 8 to Exit ");
                        int Check = Convert.ToInt32(Console.ReadLine());
                        switch (Check)
                        {
                            case 1:
                                Console.WriteLine("Enter the New First Name: ");
                                person.FirstName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the New Last Name: ");
                                person.LastName = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter the New Phone Number: ");
                                person.PhoneNum = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter the New Address: ");
                                person.Addresses = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Enter the New City: ");
                                person.City = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Enter the New State: ");
                                person.State = Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("Enter the New Pin Code: ");
                                person.ZipCode = Console.ReadLine();
                                break;
                            case 8:
                                return;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Enter the valid name!");
                }

            }
            }
        }
        //Listing the user entered details or modified details
        
        public void ListingPeople()
        {
            if (people.Count == 0)
            {
                Console.WriteLine("Your address book is empty.");
                Console.ReadKey();
                return;
                
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var person in people)
            {
                PrintCustomer(person);
            }
            return;
            //Console.WriteLine("\nPress any key to continue.");

            //Console.ReadKey();

        }
        
        
        //Removing the field using Lambda Function
        public void RemovePeople()
        {
            Console.WriteLine("Enter the first name of the person you would like to remove.");
           
            string firstName = Console.ReadLine();
            AddrBook person = people.FirstOrDefault(x => x.FirstName.ToUpper() == firstName.ToUpper());
            if (person == null)
            {
                
                Console.WriteLine("That person could not be found..");

                return;
            }
            Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
            //  PrintCustomer(person);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                people.Remove(person);
                Console.WriteLine("\nPerson removed ");

            }
        }

        //Is used for searching 
        public void Search(List<AddrBook> people, string cityname, string statename)
        {

            AddrBook addrBook = new AddrBook();
            var result = people.FindAll(a => a.City.Equals(cityname) || a.State.Equals(statename));
            if (result.Count != 0)
            {
                foreach (var m in result)
                {
                    PrintCustomer(m);
                }
            }
            else
            {
                Console.WriteLine("No person details available");
            }
        }
    }
}



