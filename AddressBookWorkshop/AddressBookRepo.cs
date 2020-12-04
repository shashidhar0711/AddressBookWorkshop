﻿using System;
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
            try
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
            catch(AddressBookCustomException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Edits the contact.
        /// </summary>
        public void EditContact()
        {
            if (addressBookList.Count == 0)
            {
                Console.WriteLine("Contact List is Currently empty!!");
            }
            else
            {
                Console.WriteLine("Enter your First Name");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter your Last Name");
                string lastName = Console.ReadLine();

                /// By Looping Untill Condtions Ends
                for (int index = 0; index < addressBookList.Count; index++)
                {
                    /// Checking If Exist FirstName or not to purpose Edit
                    if (addressBookList[index].FirstName.Equals(firstName) && addressBookList[index].LastName.Equals(lastName))
                    {
                        /// It takes Choice to Edit at Particualar Position
                        int choice = UserChoiceForEdit();
                        EditContactList(addressBookList[index], choice);
                    }
                    else
                    {
                        Console.WriteLine("Does not Exist");
                    }
                }
            }

        }

        /// <summary>
        /// Users the choice for edit.
        /// </summary>
        /// <returns></returns>
        public int UserChoiceForEdit()
        {
            Console.WriteLine("1 : Enter to Edit FirstName");
            Console.WriteLine("2 : Enter to Edit LastName");
            Console.WriteLine("3 : Enter to Edit Address");
            Console.WriteLine("4 : Enter to Edit City");
            Console.WriteLine("5 : Enter to Edit State");
            Console.WriteLine("6 : Enter to Edit PhoneNumber");
            Console.WriteLine("7 : Enter to Edit Zip");
            int choice = Convert.ToInt32(Console.ReadLine());

            /// It returns the Choice
            return choice;
        }

        /// <summary>
        /// Edits the contact list.
        /// </summary>
        /// <param name="contact">The contact.</param>
        /// <param name="choice">The choice.</param>
        public void EditContactList(AddressBookModel addressBookModel, int choice)
        {
            try
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the first name");
                        string firstName = Console.ReadLine();
                        addressBookRegex.ValidateFirstName(firstName);
                        addressBookModel.FirstName = firstName;
                        break;
                    case 2:
                        Console.WriteLine("Enter the last name");
                        string lastName = Console.ReadLine();
                        addressBookRegex.ValidateLastName(lastName);
                        addressBookModel.LastName = lastName;
                        break;
                    case 3:
                        Console.WriteLine("Enter address");
                        string address = Console.ReadLine();
                        addressBookModel.Address = address;
                        break;
                    case 4:
                        Console.WriteLine("Enter city");
                        string city = Console.ReadLine();
                        addressBookModel.City = city;
                        break;
                    case 5:
                        Console.WriteLine("Enter state");
                        string state = Console.ReadLine();
                        addressBookModel.State = state;
                        break;
                    case 6:
                        Console.WriteLine("Enter Phone Number");
                        string phoneNumber = Console.ReadLine();
                        addressBookRegex.ValidatePhoneNumber(phoneNumber);
                        addressBookModel.PhoneNumber = phoneNumber;
                        break;
                    case 7:
                        Console.WriteLine("Enter Zip code");
                        string zipCode = Console.ReadLine();
                        addressBookRegex.ValidateZipCode(zipCode);
                        addressBookModel.ZipCode = zipCode;
                        break;
                    case 8:
                        Console.WriteLine("Enter Email Id");
                        string eMailId = Console.ReadLine();
                        addressBookRegex.ValidateEmailId(eMailId);
                        addressBookModel.EmailID = eMailId;
                        break;
                    default:
                        Console.WriteLine("Enter valid choice");
                        break;
                }
            }
            catch(AddressBookCustomException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Deletes the contact.
        /// </summary>
        public void DeleteContact()
        {
            Console.WriteLine("Enter your First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            string lastName = Console.ReadLine();

            for (int index = 0; index < this.addressBookList.Count; index++)
            {
                if (addressBookList[index].FirstName.Equals(firstName) && addressBookList[index].LastName.Equals(lastName))
                {
                    /// It Checks, if Exist Contact will be Removed or deleted
                    addressBookList.Remove(addressBookList[index]);
                    Console.WriteLine("Contact deleted Successfully");
                }
                else
                {
                    Console.WriteLine("Contacts Not Found!!");
                }
            }
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
                Console.WriteLine("No contact to display!!");
            }
        }
    }
}
