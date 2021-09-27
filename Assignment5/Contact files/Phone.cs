using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /// <summary>
    /// Class for handling information on contact phone numbers
    /// </summary>
    public class Phone
    {
        //private phone number
        private string homeNumber;
        //work related phone number
        private string officeNumber;
        /// <summary>
        /// Property connected to private phone number: homeNumber.
        /// Both read and write access.
        /// </summary>
        public string HomeNumber
        {
            get { return homeNumber; }
            set { homeNumber = value; }
        }
        /// <summary>
        /// Property connected to the work related phone number: officeNumber.
        /// Both read and write access
        /// </summary>
        public string OfficeNumber
        {
            get { return officeNumber; }
            set { officeNumber = value; }
        }
        /// <summary>
        /// Default constructor, calls constructor with one parameter sending 
        /// empty string as argument.
        /// </summary>
        public Phone():this(string.Empty)
        {

        }
        /// <summary>
        /// Constructor with one parameter for private phone number connected to the 
        /// homeNumber instance variable, calls constructor with 2 parameters using "home"
        /// parameter as first argument and emtpy string as second argument.
        /// </summary>
        /// <param name="home">takes argument for private phone number as string</param>
        public Phone(string home):this(home, string.Empty)
        {

        }
        /// <summary>
        /// Constructor for the class with parameters for the home and work related phone numbers.
        /// This is the constructor with the most parameters.
        /// </summary>
        /// <param name="home"></param>
        /// <param name="office"></param>
        public Phone(string home, string office)
        {
            homeNumber = home;
            officeNumber = office;
        }
        /// <summary>
        /// Copyconstructor.
        /// </summary>
        /// <param name="theOther">object to be copied</param>
        public Phone(Phone theOther)
        {
            homeNumber = theOther.homeNumber;
            officeNumber = theOther.officeNumber;
        }
        /// <summary>
        /// Prepares a string of phone information, formatted to be used in other 
        /// classes.
        /// </summary>
        /// <returns>formatted string with phone numbers</returns>
        public override string ToString()
        {
            string home = "Home";
            string office = "Office";
            string strOut = "\n" + "Phone Numbers" + "\n";

            strOut += $" {home,-10} {homeNumber,-10}\n";
            strOut += $" {office,-10} {officeNumber,-10}\n\n";

            return strOut;
        }
    }
}
