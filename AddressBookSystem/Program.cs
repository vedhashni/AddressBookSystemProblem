using System;

namespace AddressBookSystem
{
    /// <summary>
    /// To create and add contact details
    /// To Edit contacts
    /// To delete the contact
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System!");
            int option = int.Parse(Console.ReadLine());
            
            //'1' - is used to create and add contact details
            //'2' - is used to edit contacts
            //'3' - is used to delete the contact
            switch (option)
            {
                case 1:
                    AddressBook.Getdetails();
                    AddressBook.AddContact();
                    break;

                case 2:
                    AddressBook.Getdetails();
                    AddressBook.EditCon();
                    break;

                case 3:
                    AddressBook.Getdetails();
                    AddressBook.DeleteCon();
                    break;

                case 4:
                    return;

                default:
                    break;
            }
        }
    }
}
