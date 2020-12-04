using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookWorkshop
{
    public class AddressBookCustomException : Exception
    {
        /// <summary>
        /// Enum of Exception
        /// </summary>
        public enum ExceptionType
        {
            INVALID_FIRST_NAME, INVALID_LAST_NAME, INVALID_EMAIL, INVALID_ZIPCODE, INVALID_PHONE_NUMBER
        }
        /// <summary>
        /// Creating type Variable of ExceptionType
        /// </summary>
        public readonly ExceptionType exceptionType;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBookCustomException"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        public AddressBookCustomException(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
