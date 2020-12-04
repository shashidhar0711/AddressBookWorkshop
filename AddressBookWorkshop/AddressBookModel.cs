using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookWorkshop
{
    /// <summary>
    /// Address Book Model Class
    /// </summary>
    public class AddressBookModel
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zipCode;
        public string phoneNumber;
        public string eMailId;

        public AddressBookModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBookModel"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zipCode">The zip code.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="emailId">The email identifier.</param>
        public AddressBookModel(string firstName,string lastName, string address, string city, string state, string zipCode, string phoneNumber,string eMailId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.eMailId = eMailId;
        }
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        
        public string FirstName { get => this.firstName; set => this.firstName = value; }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        
        public string LastName { get => this.lastName; set => this.lastName = value; }
        /// <summary>
        /// Gets or sets the adderss.
        /// </summary>
        /// <value>
        /// The adderss.
        /// </value>
        public string Address { get => this.address; set => this.address = value; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get => this.city; set => this.city = value; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State { get => this.state; set => this.state = value; }

        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        /// <value>
        /// The zip code.
        /// </value>
        public string ZipCode { get => this.zipCode; set => this.zipCode = value; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public string PhoneNumber { get => this.phoneNumber; set => this.phoneNumber = value; }

        /// <summary>
        /// Gets or sets the email identifier.
        /// </summary>
        /// <value>
        /// The email identifier.
        /// </value>
        public string EmailID { get => this.eMailId; set => this.eMailId = value; }
    }
}
