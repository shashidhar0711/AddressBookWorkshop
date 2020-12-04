using System;

namespace AddressBookWorkshop
{
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            /// created reference of object class
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            bool found = true;
            while(found)
            {
                Console.WriteLine("Welcome to AddressBook");
                Console.WriteLine("Enter your Choice: ");
                Console.WriteLine("Press 1 to Add your Contact: ");
                Console.WriteLine("Press 2 to Display the Contact: ");
                Console.WriteLine("press 3 to Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressBookRepo.AddContact();
                        break;
                    case 2:
                        addressBookRepo.DisplayContact();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Enter a Valid Choice Try again :");
                        break;
                }
            }
        }
    }
}
