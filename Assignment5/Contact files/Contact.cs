using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Contact
    {
        //contact's first name
        private string firstName;
        //contact's surname
        private string surname;
        //object of class Adress for handling contact's adress information
        private Adress adress;
        //object of class Phone for handling contact's phone information
        private Phone phone;
        //object of class Email for handling contact's email information
        private Email email;

        /// <summary>
        /// Property connected to the firstName varibale.
        /// Both read and write access.
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        /// <summary>
        /// Property connected to the surname variable.
        /// Both read and write acccess.
        /// </summary>
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        /// <summary>
        /// Property connected to phone instance variable.
        /// Both read and write access.
        /// </summary>
        public Phone Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        /// <summary>
        /// Property connected to adress instance variable.
        /// Both read and write access.
        /// </summary>
        public Adress Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        /// <summary>
        /// Property connected to email instance variable.
        /// Both read and write access.
        /// </summary>
        public Email Email
        {
            get { return email; }
            set { email = value; }
        }
        /// <summary>
        /// Default constructor. Calls the constructor with one parameter sending 
        /// empty string as argument.
        /// </summary>
        public Contact():this(string.Empty)
        {

        }
        /// <summary>
        /// Constructor with parameter connected to the private e-mail. Call constructor with
        /// two parameters sending its own parameter value as agrument one and emtpy string 
        /// as argument two.
        /// </summary>
        /// <param name="firstName">string connected to the firstName instance variable</param>
        public Contact(string firstName):this(firstName, string.Empty)
        {

        }
        /// <summary>
        /// "Main" constructor. Takes arguments for names and other constructors calls this.
        /// In this constructor the objects from other classes are instanciated using their
        /// default constructors.
        /// </summary>
        /// <param name="firstName">string connected to the firstName instance variable</param>
        /// <param name="surname">string connected to the surname instance variable</param>
        public Contact(string firstName, string surname)
        {
            this.firstName = firstName;
            this.surname = surname;
            adress = new Adress();//creates an instance of Adress using default constructor
            phone = new Phone();//creates an instance of Phone using default constructor
            email = new Email();//creates an instance of Email using default constructor
        }
        /// <summary>
        /// Copyconstructor copying the instance varibles of the class and calling
        /// copyconstructors to copy the objects of other classes. If not the contact copy
        /// would have refences to the old contact's instances of adress, phone and email resulting
        /// in a faulty copy and duplication of information.
        /// </summary>
        /// <param name="theOther"></param>
        public Contact(Contact theOther)
        {
            this.firstName = theOther.firstName;
            this.surname = theOther.surname;
            this.adress = new Adress(theOther.adress);//creates a copy of adress for the new copy of contact
            this.phone = new Phone(theOther.phone);//creates a copy of phone for the new copy of contact
            this.email = new Email(theOther.email);//creates a copy of email for the new copy of contact
        }
        /// <summary>
        /// Prepares a formatted string for viewing all information about a contact
        /// for use in some form of contact manager or similar.
        /// </summary>
        /// <returns>formatted string </returns>
        public override string ToString()
        {
            string strOut = $"{firstName} {surname}\n";
            strOut += adress.ToString();//formatted string from adress class
            strOut += email.ToString();//formatted string from email class
            strOut += phone.ToString();//formatted string from phone class
            return strOut;
        }
        /// <summary>
        /// This method checks if there is suffiecient contact info registered for a contact.
        /// Will return false if there is no name, neither phone nor email, city or country i missing
        /// </summary>
        /// <returns>true is sufficient information is registered</returns>
        public bool CheckData()
        {
            bool nameOk = true;//checks if a name has been registered
            bool adressOk = true;//checks if city and country has been registered
            bool contactInfoOk = true;//added checks for either phone or email
            //if both firstName and surname are emtpy, will set nameOk to false
            if(string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(surname))
            {
                nameOk = false;
            }
            //if city string is emtpy or countyr is none will set adressOk to false
            if(string.IsNullOrEmpty(adress.City) || adress.Country == Countries.None)
            {
                adressOk = false;
            }
            //if both numbers AND both emails are empty strings will set contactInfoOk to false
            //how would you contact a customer with neither phone nor email?
            if(string.IsNullOrEmpty(phone.HomeNumber) && string.IsNullOrEmpty(phone.OfficeNumber) && string.IsNullOrEmpty(email.PersonalEmail) && string.IsNullOrEmpty(email.OfficeEmail))
            {
                contactInfoOk = false;
            }
            return nameOk && adressOk && contactInfoOk;
        }
        /// <summary>
        /// Returns a contacts office phone number, or private phone if
        /// no office number is given. If both are empty, returns "No number added"
        /// </summary>
        /// <returns>a number if one exists for the contact, "No number added" if not</returns>
        public string GetOfficeNumber()
        {
            if (!string.IsNullOrEmpty(phone.OfficeNumber))
            {
                return phone.OfficeNumber;
            }
            else
            {
                if (!string.IsNullOrEmpty(phone.HomeNumber))
                {
                    return phone.HomeNumber;
                }
                else
                {
                    return "No number added";
                }
            }
        }
        /// <summary>
        /// Returns a contacts office email, or private email if
        /// no office email is given. If both are empty, returns "No email added"
        /// </summary>
        /// <returns>an email if one exists for the contact, "No email added" if not</returns>
        public string GetOfficeEmail()
        {
            if (!string.IsNullOrEmpty(email.OfficeEmail))
            {
                return email.OfficeEmail;
            }
            else
            {
                if (!string.IsNullOrEmpty(email.PersonalEmail))
                {
                    return email.PersonalEmail;
                }
                else
                {
                    return "No email added";
                }
            }
        }
    }
}
