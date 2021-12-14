using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_1
{
    class Contact
    {
        #region Properties
        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        private string mail;
        public string eMail
        {
            get { return this.mail; }
            set { this.mail = value; }
        }
        #endregion

        #region Constructor
        public Contact(string name, string lastName, string phoneNumber, string mail)
        {
            this.Name = name;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.eMail = mail;
        }
        #endregion

        #region Methods
        public string ShowContact()
        {
            return $"Name: {Name}\nLastname: {LastName}\nPhone number: {PhoneNumber}\ne-Mail: {eMail}\n";
        }
        #endregion
    }
}
