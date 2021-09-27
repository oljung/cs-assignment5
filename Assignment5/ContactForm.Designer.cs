namespace Assignment5
{
    partial class ContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboxCountries = new System.Windows.Forms.ComboBox();
            this.gboxName = new System.Windows.Forms.GroupBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gboxEmailPhone = new System.Windows.Forms.GroupBox();
            this.txtEmailOffice = new System.Windows.Forms.TextBox();
            this.lblEmailOffice = new System.Windows.Forms.Label();
            this.txtEmailPrivate = new System.Windows.Forms.TextBox();
            this.lblEmailPrivate = new System.Windows.Forms.Label();
            this.txtOfficePhone = new System.Windows.Forms.TextBox();
            this.lblOfficePhone = new System.Windows.Forms.Label();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.gboxAdress = new System.Windows.Forms.GroupBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gboxName.SuspendLayout();
            this.gboxEmailPhone.SuspendLayout();
            this.gboxAdress.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxCountries
            // 
            this.cboxCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCountries.FormattingEnabled = true;
            this.cboxCountries.Location = new System.Drawing.Point(148, 110);
            this.cboxCountries.Name = "cboxCountries";
            this.cboxCountries.Size = new System.Drawing.Size(221, 21);
            this.cboxCountries.TabIndex = 0;
            // 
            // gboxName
            // 
            this.gboxName.Controls.Add(this.txtSurname);
            this.gboxName.Controls.Add(this.txtFirstName);
            this.gboxName.Controls.Add(this.lblSurname);
            this.gboxName.Controls.Add(this.lblFirstName);
            this.gboxName.Location = new System.Drawing.Point(19, 15);
            this.gboxName.Name = "gboxName";
            this.gboxName.Size = new System.Drawing.Size(436, 105);
            this.gboxName.TabIndex = 1;
            this.gboxName.TabStop = false;
            this.gboxName.Text = "Name";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(148, 55);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(221, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(148, 31);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(220, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(50, 62);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(50, 31);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // gboxEmailPhone
            // 
            this.gboxEmailPhone.Controls.Add(this.txtEmailOffice);
            this.gboxEmailPhone.Controls.Add(this.lblEmailOffice);
            this.gboxEmailPhone.Controls.Add(this.txtEmailPrivate);
            this.gboxEmailPhone.Controls.Add(this.lblEmailPrivate);
            this.gboxEmailPhone.Controls.Add(this.txtOfficePhone);
            this.gboxEmailPhone.Controls.Add(this.lblOfficePhone);
            this.gboxEmailPhone.Controls.Add(this.txtHomePhone);
            this.gboxEmailPhone.Controls.Add(this.lblHomePhone);
            this.gboxEmailPhone.Location = new System.Drawing.Point(19, 126);
            this.gboxEmailPhone.Name = "gboxEmailPhone";
            this.gboxEmailPhone.Size = new System.Drawing.Size(435, 127);
            this.gboxEmailPhone.TabIndex = 2;
            this.gboxEmailPhone.TabStop = false;
            this.gboxEmailPhone.Text = "E-mail and Phone";
            // 
            // txtEmailOffice
            // 
            this.txtEmailOffice.Location = new System.Drawing.Point(148, 104);
            this.txtEmailOffice.Name = "txtEmailOffice";
            this.txtEmailOffice.Size = new System.Drawing.Size(221, 20);
            this.txtEmailOffice.TabIndex = 7;
            // 
            // lblEmailOffice
            // 
            this.lblEmailOffice.AutoSize = true;
            this.lblEmailOffice.Location = new System.Drawing.Point(50, 111);
            this.lblEmailOffice.Name = "lblEmailOffice";
            this.lblEmailOffice.Size = new System.Drawing.Size(67, 13);
            this.lblEmailOffice.TabIndex = 6;
            this.lblEmailOffice.Text = "E-mail, office";
            // 
            // txtEmailPrivate
            // 
            this.txtEmailPrivate.Location = new System.Drawing.Point(148, 77);
            this.txtEmailPrivate.Name = "txtEmailPrivate";
            this.txtEmailPrivate.Size = new System.Drawing.Size(221, 20);
            this.txtEmailPrivate.TabIndex = 5;
            // 
            // lblEmailPrivate
            // 
            this.lblEmailPrivate.AutoSize = true;
            this.lblEmailPrivate.Location = new System.Drawing.Point(50, 84);
            this.lblEmailPrivate.Name = "lblEmailPrivate";
            this.lblEmailPrivate.Size = new System.Drawing.Size(73, 13);
            this.lblEmailPrivate.TabIndex = 4;
            this.lblEmailPrivate.Text = "E-mail, private";
            // 
            // txtOfficePhone
            // 
            this.txtOfficePhone.Location = new System.Drawing.Point(148, 48);
            this.txtOfficePhone.Name = "txtOfficePhone";
            this.txtOfficePhone.Size = new System.Drawing.Size(221, 20);
            this.txtOfficePhone.TabIndex = 3;
            // 
            // lblOfficePhone
            // 
            this.lblOfficePhone.AutoSize = true;
            this.lblOfficePhone.Location = new System.Drawing.Point(50, 55);
            this.lblOfficePhone.Name = "lblOfficePhone";
            this.lblOfficePhone.Size = new System.Drawing.Size(69, 13);
            this.lblOfficePhone.TabIndex = 2;
            this.lblOfficePhone.Text = "Office Phone";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(148, 21);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(220, 20);
            this.txtHomePhone.TabIndex = 1;
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(50, 28);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(69, 13);
            this.lblHomePhone.TabIndex = 0;
            this.lblHomePhone.Text = "Home Phone";
            // 
            // gboxAdress
            // 
            this.gboxAdress.Controls.Add(this.txtZipCode);
            this.gboxAdress.Controls.Add(this.txtCity);
            this.gboxAdress.Controls.Add(this.txtStreet);
            this.gboxAdress.Controls.Add(this.lblZipCode);
            this.gboxAdress.Controls.Add(this.lblCity);
            this.gboxAdress.Controls.Add(this.lblStreet);
            this.gboxAdress.Controls.Add(this.lblCountry);
            this.gboxAdress.Controls.Add(this.cboxCountries);
            this.gboxAdress.Location = new System.Drawing.Point(19, 259);
            this.gboxAdress.Name = "gboxAdress";
            this.gboxAdress.Size = new System.Drawing.Size(434, 158);
            this.gboxAdress.TabIndex = 3;
            this.gboxAdress.TabStop = false;
            this.gboxAdress.Text = "Adress";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(148, 79);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(221, 20);
            this.txtZipCode.TabIndex = 7;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(148, 53);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(220, 20);
            this.txtCity.TabIndex = 6;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(148, 28);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(220, 20);
            this.txtStreet.TabIndex = 5;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(50, 82);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(49, 13);
            this.lblZipCode.TabIndex = 4;
            this.lblZipCode.Text = "Zip code";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(50, 56);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(50, 31);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 2;
            this.lblStreet.Text = "Street";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(50, 113);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Country";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(72, 423);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(115, 32);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(286, 424);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 31);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 463);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gboxAdress);
            this.Controls.Add(this.gboxEmailPhone);
            this.Controls.Add(this.gboxName);
            this.Name = "ContactForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactForm_FormClosing);
            this.gboxName.ResumeLayout(false);
            this.gboxName.PerformLayout();
            this.gboxEmailPhone.ResumeLayout(false);
            this.gboxEmailPhone.PerformLayout();
            this.gboxAdress.ResumeLayout(false);
            this.gboxAdress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxCountries;
        private System.Windows.Forms.GroupBox gboxName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox gboxEmailPhone;
        private System.Windows.Forms.TextBox txtEmailOffice;
        private System.Windows.Forms.Label lblEmailOffice;
        private System.Windows.Forms.TextBox txtEmailPrivate;
        private System.Windows.Forms.Label lblEmailPrivate;
        private System.Windows.Forms.TextBox txtOfficePhone;
        private System.Windows.Forms.Label lblOfficePhone;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.GroupBox gboxAdress;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}