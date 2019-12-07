namespace ProjectTeam13Dental360
{
    partial class BookAppointment
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
            this.labelBookAppointment = new System.Windows.Forms.Label();
            this.labelSelectService = new System.Windows.Forms.Label();
            this.listBoxServices = new System.Windows.Forms.ListBox();
            this.listBoxStaff = new System.Windows.Forms.ListBox();
            this.labelSelectDentist = new System.Windows.Forms.Label();
            this.labelPickDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelPickTime = new System.Windows.Forms.Label();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonBookAppointment = new System.Windows.Forms.Button();
            this.buttonAddNewPatient = new System.Windows.Forms.Button();
            this.dataGridViewBookAppointment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBookAppointment
            // 
            this.labelBookAppointment.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelBookAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBookAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookAppointment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBookAppointment.Location = new System.Drawing.Point(0, 0);
            this.labelBookAppointment.Name = "labelBookAppointment";
            this.labelBookAppointment.Size = new System.Drawing.Size(871, 37);
            this.labelBookAppointment.TabIndex = 0;
            this.labelBookAppointment.Text = "Book an Appointment";
            this.labelBookAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSelectService
            // 
            this.labelSelectService.AutoSize = true;
            this.labelSelectService.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectService.Location = new System.Drawing.Point(12, 42);
            this.labelSelectService.Name = "labelSelectService";
            this.labelSelectService.Size = new System.Drawing.Size(102, 18);
            this.labelSelectService.TabIndex = 1;
            this.labelSelectService.Text = "Select Service";
            // 
            // listBoxServices
            // 
            this.listBoxServices.FormattingEnabled = true;
            this.listBoxServices.Location = new System.Drawing.Point(13, 63);
            this.listBoxServices.Name = "listBoxServices";
            this.listBoxServices.Size = new System.Drawing.Size(132, 134);
            this.listBoxServices.TabIndex = 2;
            // 
            // listBoxStaff
            // 
            this.listBoxStaff.FormattingEnabled = true;
            this.listBoxStaff.Location = new System.Drawing.Point(187, 63);
            this.listBoxStaff.Name = "listBoxStaff";
            this.listBoxStaff.Size = new System.Drawing.Size(133, 134);
            this.listBoxStaff.TabIndex = 3;
            // 
            // labelSelectDentist
            // 
            this.labelSelectDentist.AutoSize = true;
            this.labelSelectDentist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectDentist.Location = new System.Drawing.Point(184, 42);
            this.labelSelectDentist.Name = "labelSelectDentist";
            this.labelSelectDentist.Size = new System.Drawing.Size(99, 18);
            this.labelSelectDentist.TabIndex = 4;
            this.labelSelectDentist.Text = "Select Dentist";
            // 
            // labelPickDate
            // 
            this.labelPickDate.AutoSize = true;
            this.labelPickDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPickDate.Location = new System.Drawing.Point(342, 63);
            this.labelPickDate.Name = "labelPickDate";
            this.labelPickDate.Size = new System.Drawing.Size(78, 16);
            this.labelPickDate.TabIndex = 5;
            this.labelPickDate.Text = "Select Date";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(345, 83);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(140, 20);
            this.dateTimePickerDate.TabIndex = 6;
            // 
            // labelPickTime
            // 
            this.labelPickTime.AutoSize = true;
            this.labelPickTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPickTime.Location = new System.Drawing.Point(342, 117);
            this.labelPickTime.Name = "labelPickTime";
            this.labelPickTime.Size = new System.Drawing.Size(80, 16);
            this.labelPickTime.TabIndex = 7;
            this.labelPickTime.Text = "Select Time";
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(345, 137);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.Size = new System.Drawing.Size(140, 20);
            this.dateTimePickerTime.TabIndex = 8;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(564, 60);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(98, 16);
            this.labelPhone.TabIndex = 9;
            this.labelPhone.Text = "Phone Number";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(565, 85);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(73, 16);
            this.labelFirstName.TabIndex = 10;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(564, 112);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(73, 16);
            this.labelLastName.TabIndex = 11;
            this.labelLastName.Text = "Last Name";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(564, 139);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 16);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "Email";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(668, 56);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(143, 20);
            this.textBoxPhone.TabIndex = 13;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(668, 83);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(143, 20);
            this.textBoxFirstName.TabIndex = 14;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(668, 108);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(143, 20);
            this.textBoxLastName.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(668, 135);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(191, 20);
            this.textBoxEmail.TabIndex = 16;
            // 
            // buttonBookAppointment
            // 
            this.buttonBookAppointment.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonBookAppointment.FlatAppearance.BorderSize = 0;
            this.buttonBookAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookAppointment.Location = new System.Drawing.Point(345, 174);
            this.buttonBookAppointment.Name = "buttonBookAppointment";
            this.buttonBookAppointment.Size = new System.Drawing.Size(140, 44);
            this.buttonBookAppointment.TabIndex = 17;
            this.buttonBookAppointment.Text = "Book Appointment";
            this.buttonBookAppointment.UseVisualStyleBackColor = false;
            this.buttonBookAppointment.Click += new System.EventHandler(this.ButtonBookAppointment_Click);
            // 
            // buttonAddNewPatient
            // 
            this.buttonAddNewPatient.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAddNewPatient.FlatAppearance.BorderSize = 0;
            this.buttonAddNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewPatient.Location = new System.Drawing.Point(604, 174);
            this.buttonAddNewPatient.Name = "buttonAddNewPatient";
            this.buttonAddNewPatient.Size = new System.Drawing.Size(131, 30);
            this.buttonAddNewPatient.TabIndex = 18;
            this.buttonAddNewPatient.Text = "Add New Patient";
            this.buttonAddNewPatient.UseVisualStyleBackColor = false;
            this.buttonAddNewPatient.Click += new System.EventHandler(this.ButtonAddNewPatient_Click);
            // 
            // dataGridViewBookAppointment
            // 
            this.dataGridViewBookAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookAppointment.Location = new System.Drawing.Point(5, 241);
            this.dataGridViewBookAppointment.Name = "dataGridViewBookAppointment";
            this.dataGridViewBookAppointment.Size = new System.Drawing.Size(866, 150);
            this.dataGridViewBookAppointment.TabIndex = 19;
            // 
            // BookAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(871, 396);
            this.Controls.Add(this.dataGridViewBookAppointment);
            this.Controls.Add(this.buttonAddNewPatient);
            this.Controls.Add(this.buttonBookAppointment);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.labelPickTime);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelPickDate);
            this.Controls.Add(this.labelSelectDentist);
            this.Controls.Add(this.listBoxStaff);
            this.Controls.Add(this.listBoxServices);
            this.Controls.Add(this.labelSelectService);
            this.Controls.Add(this.labelBookAppointment);
            this.Name = "BookAppointment";
            this.Text = "Book an Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBookAppointment;
        private System.Windows.Forms.Label labelSelectService;
        private System.Windows.Forms.ListBox listBoxServices;
        private System.Windows.Forms.ListBox listBoxStaff;
        private System.Windows.Forms.Label labelSelectDentist;
        private System.Windows.Forms.Label labelPickDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelPickTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonBookAppointment;
        private System.Windows.Forms.Button buttonAddNewPatient;
        private System.Windows.Forms.DataGridView dataGridViewBookAppointment;
    }
}