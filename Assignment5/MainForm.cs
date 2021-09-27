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
    

    public partial class MainForm : Form
    {

        private CustomerManager customerManager = new CustomerManager();
        
        public MainForm()
        {
            InitializeComponent();
            UpdateGUI();
        }
        /// <summary>
        /// This method is used to update the form with current information.
        /// </summary>
        void UpdateGUI()
        {
            //clears information in listbox
            lboxCustomers.Items.Clear();
            //clears information in info box
            lblCustomerInfo.Text = string.Empty;
            //creates an array of strings to be added to listbox containing information about customers
            string[] cusomerList = customerManager.GetCustomerInfoStrings();
            //GetCustomerInfoStrings() returns null if there are no items in customer list
            if(cusomerList != null)
            {
                //add array of strings to listbox
                lboxCustomers.Items.AddRange(cusomerList);
            }
        }
        /// <summary>
        /// When "Add" button is clicked, a new Contact object is created. It is then sent as
        /// reference to the Contactform, which is opened as a DialogResult. If OK button
        /// in form is pressed, a new customer will be added to the list using the AddCustomer() method
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create a new, empty, contact to be passed to the ContactForm
            Contact contact = new Contact();
            //Create a new version of ContactForm with the empty Contact object as reference
            Form contactForm = new ContactForm(contact);
            //Set the title of form to inform on what operations is to be performed
            contactForm.Text = "Add new customer";
            //Open ContactForm as a DialogResult
            DialogResult dialogResult = contactForm.ShowDialog();
            //If OK button is clicked and information is valid
            if(dialogResult == DialogResult.OK)
            {
                //Create new customer and add to list
                customerManager.AddCustomer(contact);
                //Uptade GUI with new inforamtion
                UpdateGUI();
            }
        }
        /// <summary>
        /// When "Edit" button is clicked, selected index is checked using
        /// CheckIndex method. If valid index, a new Contact object is created
        /// by copying the Contact object of the customer at specified index.
        /// This new Contact object is sent to the ContactForm for editing, if OK
        /// is clicked and information is valid it is then saved to the customer at
        /// specified index.
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool ok = customerManager.CheckIndex(lboxCustomers.SelectedIndex);
            if (ok)
            {
                //create a copy of the contact information in customer object
                Contact contact = new Contact(customerManager.GetCustomerContact(lboxCustomers.SelectedIndex));
                //create a new form for contactinformation using the copy from customer object.
                Form contactForm = new ContactForm(contact);
                //set the title
                contactForm.Text = "Edit customer";
                //opens the form as a DialogResult
                DialogResult dialogResult = contactForm.ShowDialog();
                //if OK button is clicked and data valid
                if(dialogResult == DialogResult.OK)
                {
                    //save the edited contact object to the selected index
                    //(this index cannot be changed mid process, as ShowDialog() locks parent window)
                    customerManager.EditCustomer(contact, lboxCustomers.SelectedIndex);
                    //update GUI after edit to display correct information
                    UpdateGUI();
                }
            }
            else
            {
                MessageBox.Show("Invalid index, please select an item in the list", "Error");
            }
        }
        /// <summary>
        /// Method for handling selection different index in listbox. Displays information
        /// about selected customer in the info box "lblCustomerInfo.
        /// </summary>

        private void lboxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool ok = customerManager.CheckIndex(lboxCustomers.SelectedIndex);
            if (ok)
            {
                //gets contact object from selected customer
                Contact contact = customerManager.GetCustomerContact(lboxCustomers.SelectedIndex);
                //set labeltext to prepared string from contact object.
                lblCustomerInfo.Text = contact.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //check if valid index is selected
            bool ok = customerManager.CheckIndex(lboxCustomers.SelectedIndex);
            //if valid index
            if (ok)
            {
                //calls the delete method from CustomerManager to delete selected customer
                customerManager.DeleteCustomer(lboxCustomers.SelectedIndex);
                //update GUI to keed information in listbox accurate.
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("Invalid index, please select an item in the list", "Error");
            }
        }
    }
}
