using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    
    public partial class ContactForm : Form
    {
        //instance of Contact to be filled with data and used to add to customer object
        private Contact contact;
        /// <summary>
        /// Constructor, sets the Contact object to the one passed on opening
        /// form and adds the enums of Countries to the combobox.
        /// </summary>
        public ContactForm(Contact contact)
        {
            InitializeComponent();
            this.contact = contact;
            GetCountries();
            UpdateGUI();
        }
        /// <summary>
        /// This method is used to update the GUI with information form the contact object
        /// passed to form when opened. If the contact is new, empty strings and None(enum)
        /// will be entered, otherwise contact information from selected customer is entered.
        /// </summary>
        private void UpdateGUI()
        {
            //gets the adress, emiai, and phone objects stored in the contact object.
            Email email = contact.Email;
            Phone phone = contact.Phone;
            Adress adress = contact.Adress;
            //following lines adds text to the textboxed connected to the corresponding data
            txtFirstName.Text = contact.FirstName;
            txtSurname.Text = contact.Surname;
            txtHomePhone.Text = phone.HomeNumber;
            txtOfficePhone.Text = phone.OfficeNumber;
            txtEmailPrivate.Text = email.PersonalEmail;
            txtEmailOffice.Text = email.OfficeEmail;
            txtStreet.Text = adress.Street;
            txtCity.Text = adress.City;
            txtZipCode.Text = adress.ZipCode;
            //sets the selected item of the combobox to the country stored in adress countries enum
            //using hte GetCountry() method with the adress.Country property as argument
            cboxCountries.SelectedItem = GetCounry(adress.Country);
        }
        /// <summary>
        /// Method used for setting the values of the countries combobox. 
        /// Replaces "_" in country names with " " and adds the array of strings 
        /// to combobox.
        /// </summary>
        private void GetCountries()
        {
            string[] countries = Enum.GetNames(typeof(Countries));
            for (int i = 0; i < countries.Length; i++)
            {
                countries[i] = countries[i].Replace("_", " ");
            }
            cboxCountries.DataSource = countries;
        }
        /// <summary>
        /// Reads input from textboxes and combobox. No validation of data needed
        /// (all strings and enum), data will be checked later.
        /// </summary>
        private void ReadInput()
        {
            contact.FirstName = txtFirstName.Text;
            contact.Surname = txtSurname.Text;
            contact.Phone = new Phone(txtHomePhone.Text, txtOfficePhone.Text);
            contact.Email = new Email(txtEmailPrivate.Text, txtEmailOffice.Text);
            contact.Adress = new Adress(txtStreet.Text, txtCity.Text, txtZipCode.Text, SetCountry());

        }
        /// <summary>
        /// This method takes the text representation of a country in the comboxbox
        /// and replaces " " with "_" in order to convert the string to an enum
        /// using the Enum.Parse. This enum is then returned
        /// </summary>
        /// <returns>enum Countries value to be added to Contact object adress field</returns>
        private Countries SetCountry()
        {
            string strCountry = cboxCountries.Text;
            strCountry = strCountry.Replace(" ", "_");
            Countries country = (Countries)Enum.Parse(typeof(Countries), strCountry);
            return country;
        }
        /// <summary>
        /// This method takes the Countries enum from a Contact objects adress field
        /// and converts that to a string and replaces "_" with " "
        /// in order to set the combobox item to the correct country.
        /// </summary>
        /// <param name="country">Countries enum stored in a Contact objects adress field</param>
        /// <returns>string with "_" replaced with " "</returns>
        private string GetCounry(Countries country)
        {
            string strCountry = country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;
        }
        /// <summary>
        /// if user clicks the cancel button, the cancel variable is set to true
        /// </summary>

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// this method is called whenever the form is instrcuted to close. It checks user is
        /// closing using "cancel, X or alt+f4" or using the "OK" button. 
        /// </summary>
        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form = (Form)sender;

            if(form.DialogResult == DialogResult.Cancel)
            {
                //a message to be shown to user, warning about information loss on closing
                string message = "You are about to close the form. Any changes made " +
                    "will be lost.\nProceed?";
                //opens up a message box displaying the message and YES/NO buttons
                if (MessageBox.Show(message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    //of no was clicked, the form is to remain open
                    e.Cancel = true;//will cancel the closing event
                }
            }

            else
            {
                //reads all input data, see method for details
                ReadInput();
                //checks to see if sufficient information has been added
                bool ok = contact.CheckData();
                //if not enough data
                if (!ok)
                {
                    MessageBox.Show("Please enter necessary information.\nAtleast a name (first or surname),\n" +
                        "atleast one phone OR one emial,\n" +
                        "and a city and countyr must be selected");
                    //cancels the closing event, causing form to remain open
                    e.Cancel = true;
                }
            }

        }
    }
}
