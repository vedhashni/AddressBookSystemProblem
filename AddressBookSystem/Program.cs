using System;

namespace AddressBookSystem
{
    /// <summary>
    /// To create and add contact details
    /// To Edit contacts
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System!");
            int option = int.Parse(Console.ReadLine());
            
            //'1' - is used to create and add contact details
            //'2' - is used to edit contacts
            switch (option)
            {
                case 1:
                    AddressBook.Getdetails();
                    AddressBook.AddContact();
                    break;

                case 2:
                    AddressBook.EditCon();
                    break;

                case 3:
                    return;

                default:
                    break;
            }
        }
    }
}
