using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AddressBookWorkshop
{
    public class AddressBookRegex
    {
        /// <summary>
        /// The first name regex pattern
        /// </summary>
        public const string FIRST_NAME = "^[A-Z][a-z]{3,}$";

        /// <summary>
        /// The last name regex pattern
        /// </summary>
        public const string LAST_NAME = "^[A-Z][a-z]{3,}$";

        /// <summary>
        /// The zipcode regex pattern
        /// </summary>
        public const string ZIPCODE = "^[0-9]{6}$";

        /// <summary>
        /// The email identifier regex pattern
        /// </summary>
        public const string EMAIL_ID = "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*@[0-9a-zA-Z]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2})*$";

        /// <summary>
        /// The mobile number regex pattern
        /// </summary>
        public const string MOBILE_NUMBER = "^[1-9][0-9]{0,2}[ ][1-9][0-9]{9}$";

        /// <summary>
        /// Validates the first name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <exception cref="AddressBookWorkshop.AddressBookCustomException">Invalid First Name</exception>
        public void ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, FIRST_NAME))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_FIRST_NAME, "Invalid First Name");
            }
        }

        /// <summary>
        /// Validates the last name.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        /// <exception cref="AddressBookWorkshop.AddressBookCustomException">Invalid Last Name</exception>
        public void ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, LAST_NAME))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_LAST_NAME, "Invalid Last Name");
            }
        }

        /// <summary>
        /// Validates the zip code.
        /// </summary>
        /// <param name="zipCode">The zip code.</param>
        /// <exception cref="AddressBookWorkshop.AddressBookCustomException">Invalid Zip Code</exception>
        public void ValidateZipCode(string zipCode)
        {
            if (Regex.IsMatch(zipCode, ZIPCODE))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_ZIPCODE, "Invalid Zip Code");
            }
        }

        /// <summary>
        /// Validates the phone number.
        /// </summary>
        /// <param name="phoneNumber">The phone number.</param>
        /// <exception cref="AddressBookWorkshop.AddressBookCustomException">Invalid Phone Number</exception>
        public void ValidatePhoneNumber(string phoneNumber)
        {
            if (Regex.IsMatch(phoneNumber, MOBILE_NUMBER))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_PHONE_NUMBER, "Invalid Phone Number");
            }
        }

        /// <summary>
        /// Validates the email identifier.
        /// </summary>
        /// <param name="eMail">The e mail.</param>
        /// <exception cref="AddressBookWorkshop.AddressBookCustomException">Invalid Email Id</exception>
        public void ValidateEmailId(string eMail)
        {
            if (Regex.IsMatch(eMail, EMAIL_ID))
            {
                return;
            }
            else
            {
                throw new AddressBookCustomException(AddressBookCustomException.ExceptionType.INVALID_EMAIL, "Invalid Email Id");
            }
        }
    }
}
