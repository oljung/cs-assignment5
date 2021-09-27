using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /// <summary>
    /// Class for handling a contact's adress information. Provides properties for getting 
    /// and setting values to instance varibles and methods for getting formatted information
    /// for use in other classes.
    /// </summary>
    public class Adress
    {
        private string street;
        private string city;
        private string zipCode;
        private Countries country;

        /// <summary>
        /// Property connected to the street instance variable. 
        /// Both read and write access.
        /// </summary>
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        /// <summary>
        /// Property connected to the city instance variable. 
        /// Both read and write access.
        /// </summary>
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        /// <summary>
        /// Property connected to the zipCode instance variable. 
        /// Both read and write access.
        /// </summary>
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        /// <summary>
        /// Property connected to the country instance variable. 
        /// Both read and write access.
        /// </summary>
        public Countries Country
        {
            get { return country; }
            set { country = value; }

        }
        /// <summary>
        /// Default constructor, calls constructor with 1 parameter sending empty
        /// string as argument.
        /// </summary>
        public Adress():this(string.Empty)
        {

        }
        /// <summary>
        /// Constructor with 1 parameter. Calls constructor with 2 parameters, using
        /// own parameter as argument and empty string for other.
        /// </summary>
        /// <param name="street">string connected to the street instance variable</param>
        public Adress(string street):this(street, string.Empty)
        {

        }
        /// <summary>
        /// Constructor with 2 parameters. Calls constructor with 3 parameters, using
        /// own parameters as arguments and empty string for other.
        /// </summary>
        /// <param name="street">string connected to the street instance variable</param>
        /// <param name="city">string connected to the city instance variable</param>
        public Adress(string street, string city):this(street, city, string.Empty)
        {

        }
        /// <summary>
        /// Constructor with 3 parameters. Calls constructor with 4 parameters, using
        /// own parameters as arguments and sets the enumvalue for country to default value (None).
        /// </summary>
        /// <param name="street">string connected to the street instance variable</param>
        /// <param name="city">string connected to the city instance variable</param>
        /// <param name="zipCode">string connected to the zipCode instance variable</param>
        public Adress(string street, string city, string zipCode):this(street, city, zipCode, Countries.None)
        {

        }
        /// <summary>
        /// "Main" constructor with 4 parameters. Other constructors call this one
        /// if no value is set for country in argument it will be set to default value (None)
        /// </summary>
        /// <param name="street">string connected to the street instance variable</param>
        /// <param name="city">string connected to the city instance variable</param>
        /// <param name="zipCode">string connected to the zipCode instance variable</param>
        /// <param name="country">enum connected to the country instance variable, will be None be default</param>
        public Adress(string street, string city, string zipCode, Countries country)
        {
            this.street = street;
            this.city = city;
            this.zipCode = zipCode;
            this.country = country;
        }
        /// <summary>
        /// Copyconstructor.
        /// </summary>
        /// <param name="theOther">object of class to be copied</param>
        public Adress(Adress theOther)
        {
            this.street = theOther.street;
            this.city = theOther.city;
            this.zipCode = theOther.zipCode;
            this.country = theOther.country;
        }
        /// <summary>
        /// Provides a formatted string of adress information for use in other classes.
        /// </summary>
        /// <returns>returns formatted string</returns>
        public override string ToString()
        {
            string strOut = $"{street}\n{zipCode} {city}\n{country}\n";
            return strOut;
        }
    }
}
