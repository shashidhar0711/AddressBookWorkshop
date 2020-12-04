using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookWorkshop
{
    public class AddressBookRegex
    {
        /// <summary>
        /// The first name regex pattern
        /// </summary>
        public const string FIRST_NAME = "^[A-Z][a-z]{2,}$";

        /// <summary>
        /// The last name regex pattern
        /// </summary>
        public const string LAST_NAME = "^[A-Z][a-z]{1,}$";

        /// <summary>
        /// The zipcode regex pattern
        /// </summary>
        public const string ZIPCODE = "^[1-9][0-9]{6}$";

        /// <summary>
        /// The email identifier regex pattern
        /// </summary>
        public const string EMAIL_ID = "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*@[0-9a-zA-Z]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2})*$";

        /// <summary>
        /// The mobile number regex pattern
        /// </summary>
        public const string MOBILE_NUMBER = "^[+][1-9][0-9]{0,2}[ ][1-9][0-9]{9}$";

    }
}
