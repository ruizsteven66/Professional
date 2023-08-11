namespace DonationsList
{
    partial class DonationsList
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
            this.BtnAddDonation = new System.Windows.Forms.Button();
            this.typeOfDonation = new System.Windows.Forms.GroupBox();
            this.rdPersonal = new System.Windows.Forms.RadioButton();
            this.rdBusiness = new System.Windows.Forms.RadioButton();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.typeOfDonation.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAddDonation
            // 
            this.BtnAddDonation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddDonation.Location = new System.Drawing.Point(23, 32);
            this.BtnAddDonation.Name = "BtnAddDonation";
            this.BtnAddDonation.Size = new System.Drawing.Size(180, 131);
            this.BtnAddDonation.TabIndex = 0;
            this.BtnAddDonation.Text = "Add Donation";
            this.BtnAddDonation.UseVisualStyleBackColor = true;
            this.BtnAddDonation.Click += new System.EventHandler(this.BtnAddDonation_Click);
            // 
            // typeOfDonation
            // 
            this.typeOfDonation.Controls.Add(this.rdPersonal);
            this.typeOfDonation.Controls.Add(this.rdBusiness);
            this.typeOfDonation.Location = new System.Drawing.Point(23, 199);
            this.typeOfDonation.Name = "typeOfDonation";
            this.typeOfDonation.Size = new System.Drawing.Size(212, 73);
            this.typeOfDonation.TabIndex = 1;
            this.typeOfDonation.TabStop = false;
            this.typeOfDonation.Text = "Type Of Donation";
            // 
            // rdPersonal
            // 
            this.rdPersonal.AutoSize = true;
            this.rdPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPersonal.Location = new System.Drawing.Point(26, 31);
            this.rdPersonal.Name = "rdPersonal";
            this.rdPersonal.Size = new System.Drawing.Size(79, 20);
            this.rdPersonal.TabIndex = 5;
            this.rdPersonal.TabStop = true;
            this.rdPersonal.Text = "Personal";
            this.rdPersonal.UseVisualStyleBackColor = true;
            this.rdPersonal.Click += new System.EventHandler(this.BtnAddDonation_Click);
            // 
            // rdBusiness
            // 
            this.rdBusiness.AutoSize = true;
            this.rdBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBusiness.Location = new System.Drawing.Point(111, 31);
            this.rdBusiness.Name = "rdBusiness";
            this.rdBusiness.Size = new System.Drawing.Size(80, 20);
            this.rdBusiness.TabIndex = 6;
            this.rdBusiness.TabStop = true;
            this.rdBusiness.Text = "Business";
            this.rdBusiness.UseVisualStyleBackColor = true;
            this.rdBusiness.Click += new System.EventHandler(this.BtnAddDonation_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(23, 301);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(433, 212);
            this.listBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFirstName.Location = new System.Drawing.Point(400, 50);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(100, 22);
            this.TxtFirstName.TabIndex = 7;
            this.TxtFirstName.Click += new System.EventHandler(this.BtnAddDonation_Click);
            // 
            // TxtLastName
            // 
            this.TxtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastName.Location = new System.Drawing.Point(400, 88);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(100, 22);
            this.TxtLastName.TabIndex = 8;
            this.TxtLastName.Click += new System.EventHandler(this.BtnAddDonation_Click);
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhoneNumber.Location = new System.Drawing.Point(400, 126);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.TxtPhoneNumber.TabIndex = 9;
            this.TxtPhoneNumber.Click += new System.EventHandler(this.BtnAddDonation_Click);
            // 
            // TxtAge
            // 
            this.TxtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAge.Location = new System.Drawing.Point(400, 160);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(100, 22);
            this.TxtAge.TabIndex = 10;
            this.TxtAge.Click += new System.EventHandler(this.BtnAddDonation_Click);
            // 
            // DonationsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(524, 543);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtPhoneNumber);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.typeOfDonation);
            this.Controls.Add(this.BtnAddDonation);
            this.Name = "DonationsList";
            this.Text = "Donation List";
            this.typeOfDonation.ResumeLayout(false);
            this.typeOfDonation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddDonation;
        private System.Windows.Forms.GroupBox typeOfDonation;
        private System.Windows.Forms.RadioButton rdPersonal;
        private System.Windows.Forms.RadioButton rdBusiness;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.TextBox TxtAge;
    }
}

