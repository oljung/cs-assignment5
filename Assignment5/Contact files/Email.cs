using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /// <summary>
    /// Class for handling contact information in form of e-mail. Provides properties for 
    /// instance fields and methods for getting formatted string of information
    /// </summary>
    public class Email
    {
        //private email adress
        private string personalEmail;
        //work related email adress
        private string officeEmail;

        /// <summary>
        /// Property connected to the private e-mail: personalEmail varible.
        /// Both read and write access.
        /// </summary>
        public string PersonalEmail
        {
            get { return personalEmail; }
            set { personalEmail = value; }
        }
        /// <summary>
        /// Property connected to the work related e-mail: officeEmail variable.
        /// Both read and write access.
        /// </summary>
        public string OfficeEmail
        {
            get { return officeEmail; }
            set { officeEmail = value; }
        }
        /// <summary>
        /// Default constructor. Calls the constructor with one parameter sending 
        /// empty string as argument.
        /// </summary>
        public Email():this(string.Empty)
        {

        }
        /// <summary>
        /// Constructor with parameter connected to the private e-mail. Call constructor with
        /// two parameters sending its own parameter value as agrument one and emtpy string 
        /// as argument two.
        /// </summary>
        /// <param name="personal">string connected to the personalEmail variable</param>
        public Email(string personal):this(personal, string.Empty)
        {

        }
        /// <summary>
        /// "Main" constructor of the class with most parameters. This is where all coding takes place
        /// </summary>
        /// <param name="personal">string connected to the personalEmail variable</param>
        /// <param name="office">string connected to the officeEmail variable</param>
        public Email(string personal, string office)
        {
            personalEmail = personal;
            officeEmail = office;
        }
        /// <summary>
        /// Copyconstructor.
        /// </summary>
        /// <param name="theOther">object to be copied</param>
        public Email(Email theOther)
        {
            this.personalEmail = theOther.personalEmail;
            this.officeEmail = theOther.officeEmail;
        }

        /// <summary>
        /// Prepares a string of e-mail information, formatted to be used in other 
        /// classes.
        /// </summary>
        /// <returns>formatted string with e-mailz</returns>
        public override string ToString()
        {
            string priv = "Private";
            string office = "Office";
            string strOut = "\n" + "Emails" + "\n";

            strOut += $" {priv,-10} {personalEmail, -10}\n";
            strOut += $" {office,-10} {officeEmail, -10}\n\n";

            return strOut;
        }
    }
}
