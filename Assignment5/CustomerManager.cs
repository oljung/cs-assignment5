using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /// <summary>
    /// Class for managing customers for registry. Has methods for adding, editing and deleting
    /// customers and providing output information to be viewed by user.
    /// </summary>
    class CustomerManager
    {
        //list of customers
        private List<Customer> customers;
        //used for assigning customerId to customers, starts at 100 in this case.
        private int IdCounter = 100;

        /// <summary>
        /// Constructor for the class, creates a new list for customer variable.
        /// </summary>
        public CustomerManager()
        {
            customers = new List<Customer>();
        }
        /// <summary>
        /// Property used to get the current number of items in the list.
        /// Read access only.
        /// </summary>
        public int CustomerCount
        {
            get { return customers.Count; }
        }
        /// <summary>
        /// Creates a new customer using parameter contact as argument for constructor.
        /// Also assigns customer a customerId using the IDCounter and then adds it to the
        /// back of the customers list.
        /// </summary>
        /// <param name="contact">contactinformation for new customer</param>
        public void AddCustomer(Contact contact)
        {
            //creates a new customer using the passed contact object
            Customer newCustomer = new Customer(contact);
            //assign an Idnumber using the IdCounter in manager
            newCustomer.CustomerId = IdCounter;
            //add one to the counter, ensuring no dublicate IDs
            IdCounter++;
            //add the new customer to the back of the list
            customers.Add(newCustomer);
        }
        /// <summary>
        /// Method for editing contact information of a customer. Index should be checked before 
        /// passed using CustomerManager.CheckIndex().
        /// </summary>
        /// <param name="newContactInfo">new infomration to be added to customer object</param>
        /// <param name="index">index in the list where the object to be changed is located</param>
        public void EditCustomer(Contact newContactInfo, int index)
        {
            //changes the contactinfo of the object at provided index by
            //creating a new copy of the provided contactinfo
            customers[index].Contact = new Contact(newContactInfo);
        }
        /// <summary>
        /// Method used to check if a valid index is passed to methods
        /// affecting the customer list. 
        /// </summary>
        /// <param name="index">index to be checked against count in list</param>
        /// <returns>true if valid, false if not</returns>
        public bool CheckIndex(int index)
        {
            bool ok = false;
            if(index >= 0 && index < customers.Count)
            {
                ok = true;
            }
            return ok;
        }
        /// <summary>
        /// Method for deleting an item at specified index. Index should be checked before 
        /// passed using CustomerManager.CheckIndex().
        /// </summary>
        /// <param name="index">index of item to be deleted</param>
        public void DeleteCustomer(int index)
        {
            //removes item of passed index
            customers.RemoveAt(index);
        }
        /// <summary>
        /// Method used to get contact info from customer at specified index.
        /// </summary>
        /// <param name="index">index to get data from</param>
        /// <returns>Contact object stored in customer object</returns>
        public Contact GetCustomerContact(int index)
        {
            Contact contactInfo = customers[index].Contact;
            return contactInfo;
        }
        /// <summary>
        /// Prepares an array of strings containing customer info for use in 
        /// listbox.
        /// </summary>
        /// <returns>array of strings for listbox.</returns>
        public string[] GetCustomerInfoStrings()
        {
            string[] output = null;
            if (customers.Count > 0)
            {
                output = new string[customers.Count];
                for (int i = 0; i < customers.Count; i++)
                {
                    output[i] = customers[i].GetCustomerInfo();
                }
            }

            return output;
        }
    }
}
