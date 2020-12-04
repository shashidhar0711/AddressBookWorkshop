using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookWorkshop
{
    public class AddressBookRepo
    {
        /// created address book list
        List<AddressBookModel> addressBookList = new List<AddressBookModel>();
        AddressBookRegex addressBookRegex = new AddressBookRegex();

        /// <summary>
        /// Addings the contact.
        /// </summary>
        public void AddContact()
        {
            Console.WriteLine("Enter your First Name: ");
            string firstName = Console.ReadLine();
            addressBookRegex.ValidateFirstName(firstName);
            Console.WriteLine("Enter your Last Name: ");
            string lastName = Console.ReadLine();
            addressBookRegex.ValidateLastName(lastName);
            Console.WriteLine("Enter your Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your City: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter your State: ");
            string state = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code: ");
            string zipCode = Console.ReadLine();
            addressBookRegex.ValidateZipCode(zipCode);
            Console.WriteLine("Enter your Phone Number: ");
            string phoneNumber = Console.ReadLine();
            addressBookRegex.ValidatePhoneNumber(phoneNumber);
            Console.WriteLine("Enter your Email Id ;");
            string eMailId = Console.ReadLine();
            addressBookRegex.ValidateEmailId(eMailId);

            AddressBookModel addressBook = new AddressBookModel(firstName, lastName, address, city, state, zipCode, phoneNumber, eMailId);
            this.addressBookList.Add(addressBook);
            Console.WriteLine("Contact added successFull..");
        }

        /// <summary>
        /// Displays the contact.
        /// </summary>
        public void DisplayContact()
        {
            if (addressBookList.Count != 0)
            {
                for (int index = 0; index < addressBookList.Count; index++)
                {
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("First Name : " + addressBookList[index].FirstName);
                    Console.WriteLine("Last Name : " + addressBookList[index].LastName);
                    Console.WriteLine("Address : " + addressBookList[index].Address);
                    Console.WriteLine("City : " + addressBookList[index].City);
                    Console.WriteLine("State : " + addressBookList[index].State);
                    Console.WriteLine("Phone Number : " + addressBookList[index].PhoneNumber);
                    Console.WriteLine("Zip Code : " + addressBookList[index].ZipCode);
                    Console.WriteLine("Email : " + addressBookList[index].eMailId);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("No contact to display");
            }
        }
    }
}
