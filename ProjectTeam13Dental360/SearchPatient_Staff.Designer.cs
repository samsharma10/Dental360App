namespace ProjectTeam13Dental360
{
    partial class SearchPatient_Staff
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
            this.labelSearchPatientStaff = new System.Windows.Forms.Label();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.labelSearchPatient = new System.Windows.Forms.Label();
            this.radioButtonPhoneNumber = new System.Windows.Forms.RadioButton();
            this.radioButtonLastName = new System.Windows.Forms.RadioButton();
            this.buttonPatientSearch = new System.Windows.Forms.Button();
            this.labelSearchStaff = new System.Windows.Forms.Label();
            this.labeEnterLastName = new System.Windows.Forms.Label();
            this.textBoxStaffLastName = new System.Windows.Forms.TextBox();
            this.buttonStaffSearch = new System.Windows.Forms.Button();
            this.textBoxPatientInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSearchPatientStaff
            // 
            this.labelSearchPatientStaff.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelSearchPatientStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSearchPatientStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchPatientStaff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSearchPatientStaff.Location = new System.Drawing.Point(0, 0);
            this.labelSearchPatientStaff.Name = "labelSearchPatientStaff";
            this.labelSearchPatientStaff.Size = new System.Drawing.Size(600, 37);
            this.labelSearchPatientStaff.TabIndex = 0;
            this.labelSearchPatientStaff.Text = "Search Patient or Staff";
            this.labelSearchPatientStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(5, 40);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.Size = new System.Drawing.Size(589, 180);
            this.dataGridViewSearch.TabIndex = 1;
            // 
            // labelSearchPatient
            // 
            this.labelSearchPatient.AutoSize = true;
            this.labelSearchPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchPatient.Location = new System.Drawing.Point(12, 233);
            this.labelSearchPatient.Name = "labelSearchPatient";
            this.labelSearchPatient.Size = new System.Drawing.Size(114, 20);
            this.labelSearchPatient.TabIndex = 2;
            this.labelSearchPatient.Text = "Search Patient";
            // 
            // radioButtonPhoneNumber
            // 
            this.radioButtonPhoneNumber.AutoSize = true;
            this.radioButtonPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPhoneNumber.Location = new System.Drawing.Point(44, 267);
            this.radioButtonPhoneNumber.Name = "radioButtonPhoneNumber";
            this.radioButtonPhoneNumber.Size = new System.Drawing.Size(180, 20);
            this.radioButtonPhoneNumber.TabIndex = 3;
            this.radioButtonPhoneNumber.TabStop = true;
            this.radioButtonPhoneNumber.Text = "Search by Phone Number";
            this.radioButtonPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // radioButtonLastName
            // 
            this.radioButtonLastName.AutoSize = true;
            this.radioButtonLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLastName.Location = new System.Drawing.Point(44, 293);
            this.radioButtonLastName.Name = "radioButtonLastName";
            this.radioButtonLastName.Size = new System.Drawing.Size(155, 20);
            this.radioButtonLastName.TabIndex = 4;
            this.radioButtonLastName.TabStop = true;
            this.radioButtonLastName.Text = "Search by Last Name";
            this.radioButtonLastName.UseVisualStyleBackColor = true;
            // 
            // buttonPatientSearch
            // 
            this.buttonPatientSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonPatientSearch.FlatAppearance.BorderSize = 0;
            this.buttonPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatientSearch.Location = new System.Drawing.Point(85, 360);
            this.buttonPatientSearch.Name = "buttonPatientSearch";
            this.buttonPatientSearch.Size = new System.Drawing.Size(84, 34);
            this.buttonPatientSearch.TabIndex = 5;
            this.buttonPatientSearch.Text = "Search";
            this.buttonPatientSearch.UseVisualStyleBackColor = false;
            this.buttonPatientSearch.Click += new System.EventHandler(this.ButtonPatientSearch_Click);
            // 
            // labelSearchStaff
            // 
            this.labelSearchStaff.AutoSize = true;
            this.labelSearchStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchStaff.Location = new System.Drawing.Point(351, 233);
            this.labelSearchStaff.Name = "labelSearchStaff";
            this.labelSearchStaff.Size = new System.Drawing.Size(99, 20);
            this.labelSearchStaff.TabIndex = 6;
            this.labelSearchStaff.Text = "Search Staff";
            // 
            // labeEnterLastName
            // 
            this.labeEnterLastName.AutoSize = true;
            this.labeEnterLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeEnterLastName.Location = new System.Drawing.Point(380, 269);
            this.labeEnterLastName.Name = "labeEnterLastName";
            this.labeEnterLastName.Size = new System.Drawing.Size(136, 16);
            this.labeEnterLastName.TabIndex = 7;
            this.labeEnterLastName.Text = "Enter Staff Last Name";
            // 
            // textBoxStaffLastName
            // 
            this.textBoxStaffLastName.Location = new System.Drawing.Point(383, 293);
            this.textBoxStaffLastName.Name = "textBoxStaffLastName";
            this.textBoxStaffLastName.Size = new System.Drawing.Size(152, 20);
            this.textBoxStaffLastName.TabIndex = 8;
            this.textBoxStaffLastName.TextChanged += new System.EventHandler(this.TextBoxStaffLastName_TextChanged);
            // 
            // buttonStaffSearch
            // 
            this.buttonStaffSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonStaffSearch.FlatAppearance.BorderSize = 0;
            this.buttonStaffSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStaffSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStaffSearch.Location = new System.Drawing.Point(409, 330);
            this.buttonStaffSearch.Name = "buttonStaffSearch";
            this.buttonStaffSearch.Size = new System.Drawing.Size(84, 34);
            this.buttonStaffSearch.TabIndex = 9;
            this.buttonStaffSearch.Text = "Search";
            this.buttonStaffSearch.UseVisualStyleBackColor = false;
            this.buttonStaffSearch.Click += new System.EventHandler(this.ButtonStaffSearch_Click);
            // 
            // textBoxPatientInput
            // 
            this.textBoxPatientInput.Location = new System.Drawing.Point(44, 330);
            this.textBoxPatientInput.Name = "textBoxPatientInput";
            this.textBoxPatientInput.Size = new System.Drawing.Size(167, 20);
            this.textBoxPatientInput.TabIndex = 10;
            this.textBoxPatientInput.TextChanged += new System.EventHandler(this.TextBoxPatientInput_TextChanged);
            // 
            // SearchPatient_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 406);
            this.Controls.Add(this.textBoxPatientInput);
            this.Controls.Add(this.buttonStaffSearch);
            this.Controls.Add(this.textBoxStaffLastName);
            this.Controls.Add(this.labeEnterLastName);
            this.Controls.Add(this.labelSearchStaff);
            this.Controls.Add(this.buttonPatientSearch);
            this.Controls.Add(this.radioButtonLastName);
            this.Controls.Add(this.radioButtonPhoneNumber);
            this.Controls.Add(this.labelSearchPatient);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.labelSearchPatientStaff);
            this.Name = "SearchPatient_Staff";
            this.Text = "Search Patient or Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearchPatientStaff;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.Label labelSearchPatient;
        private System.Windows.Forms.RadioButton radioButtonPhoneNumber;
        private System.Windows.Forms.RadioButton radioButtonLastName;
        private System.Windows.Forms.Button buttonPatientSearch;
        private System.Windows.Forms.Label labelSearchStaff;
        private System.Windows.Forms.Label labeEnterLastName;
        private System.Windows.Forms.TextBox textBoxStaffLastName;
        private System.Windows.Forms.Button buttonStaffSearch;
        private System.Windows.Forms.TextBox textBoxPatientInput;
    }
}