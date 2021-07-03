using System;

namespace AddressBookSystem
{
    /// <summary>
    /// To create and add contact details
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System!");
            int option = int.Parse(Console.ReadLine());
            
            //'1' - is used to create and add contact details

            switch (option)
            {
                case 1:
                    AddressBook.Getdetails();
                    AddressBook.AddContact();
                    break;

                case 2:
                    return;

                default:
                    break;
            }
        }
    }
}
