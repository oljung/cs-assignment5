namespace Assignment5
{
    partial class MainForm
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
            this.lboxCustomers = new System.Windows.Forms.ListBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.lblOfficePhone = new System.Windows.Forms.Label();
            this.lblOfficeEmail = new System.Windows.Forms.Label();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblContactDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lboxCustomers
            // 
            this.lboxCustomers.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxCustomers.FormattingEnabled = true;
            this.lboxCustomers.ItemHeight = 14;
            this.lboxCustomers.Location = new System.Drawing.Point(19, 54);
            this.lboxCustomers.Name = "lboxCustomers";
            this.lboxCustomers.Size = new System.Drawing.Size(692, 312);
            this.lboxCustomers.TabIndex = 0;
            this.lboxCustomers.SelectedIndexChanged += new System.EventHandler(this.lboxCustomers_SelectedIndexChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(16, 38);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Location = new System.Drawing.Point(86, 38);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(134, 13);
            this.lblNames.TabIndex = 2;
            this.lblNames.Text = "Name (Surname, firstname)";
            // 
            // lblOfficePhone
            // 
            this.lblOfficePhone.AutoSize = true;
            this.lblOfficePhone.Location = new System.Drawing.Point(284, 38);
            this.lblOfficePhone.Name = "lblOfficePhone";
            this.lblOfficePhone.Size = new System.Drawing.Size(69, 13);
            this.lblOfficePhone.TabIndex = 3;
            this.lblOfficePhone.Text = "Office Phone";
            // 
            // lblOfficeEmail
            // 
            this.lblOfficeEmail.AutoSize = true;
            this.lblOfficeEmail.Location = new System.Drawing.Point(575, 38);
            this.lblOfficeEmail.Name = "lblOfficeEmail";
            this.lblOfficeEmail.Size = new System.Drawing.Size(66, 13);
            this.lblOfficeEmail.TabIndex = 4;
            this.lblOfficeEmail.Text = "Office E-mail";
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomerInfo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInfo.Location = new System.Drawing.Point(717, 54);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(333, 312);
            this.lblCustomerInfo.TabIndex = 5;
            this.lblCustomerInfo.Text = "CustomerInfo";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(49, 376);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(287, 376);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 32);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(519, 376);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 32);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblContactDetails
            // 
            this.lblContactDetails.AutoSize = true;
            this.lblContactDetails.Location = new System.Drawing.Point(830, 38);
            this.lblContactDetails.Name = "lblContactDetails";
            this.lblContactDetails.Size = new System.Drawing.Size(79, 13);
            this.lblContactDetails.TabIndex = 9;
            this.lblContactDetails.Text = "Contact Details";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 417);
            this.Controls.Add(this.lblContactDetails);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCustomerInfo);
            this.Controls.Add(this.lblOfficeEmail);
            this.Controls.Add(this.lblOfficePhone);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lboxCustomers);
            this.Name = "MainForm";
            this.Text = "Customer Registry by Patrik Österljung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxCustomers;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Label lblOfficePhone;
        private System.Windows.Forms.Label lblOfficeEmail;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblContactDetails;
    }
}

