using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Customer
    {
        //customers contact information
        private Contact contact;
        //ID-number for fast identification
        private int customerId;
        /// <summary>
        /// Property connected to customerId varible.
        /// Both read and write access.
        /// </summary>
        public int CustomerId
        {
            set { customerId = value; }
            get { return customerId; }
        }
        /// <summary>
        /// Property connected to the contact instance varrable. 
        /// Both read and write acces, returns Contact object.
        /// </summary>
        public Contact Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        /// <summary>
        /// Constructor for the class, a contact in passed when creating a new customer.
        /// No customer should be created without contact, hence no default constructor.
        /// </summary>
        /// <param name="contact">contactinformation in form of object to be stored in customer info</param>
        public Customer(Contact contact)
        {
            this.contact = contact;
        }

        public string GetCustomerInfo()
        {
            string names = $"{contact.Surname.ToUpper()}, {contact.FirstName}";
            string strOut = $"{customerId}\t{names,-30}{contact.GetOfficeNumber(),-30}{contact.GetOfficeEmail(),-20}";
            return strOut;
        }
    }
}
