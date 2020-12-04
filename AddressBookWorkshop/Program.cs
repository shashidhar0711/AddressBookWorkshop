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
            addressBookRepo.BookManagementView();
        }
    }
}
