namespace ProjectTeam13Dental360
{
    partial class NewStaff
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
            this.components = new System.ComponentModel.Container();
            this.labelAddStaff = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dental360DBDataSet = new ProjectTeam13Dental360.Dental360DBDataSet();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.staffBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonAddStaff = new System.Windows.Forms.Button();
            this.staffTableAdapter = new ProjectTeam13Dental360.Dental360DBDataSetTableAdapters.StaffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dental360DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddStaff
            // 
            this.labelAddStaff.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelAddStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddStaff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAddStaff.Location = new System.Drawing.Point(0, 0);
            this.labelAddStaff.Name = "labelAddStaff";
            this.labelAddStaff.Size = new System.Drawing.Size(363, 39);
            this.labelAddStaff.TabIndex = 0;
            this.labelAddStaff.Text = "Add Staff";
            this.labelAddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(12, 64);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(86, 20);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(12, 94);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(86, 20);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(12, 123);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(115, 20);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Phone Number";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(12, 153);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "StaffFirstName", true));
            this.textBoxFirstName.Location = new System.Drawing.Point(138, 63);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(139, 20);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.dental360DBDataSet;
            // 
            // dental360DBDataSet
            // 
            this.dental360DBDataSet.DataSetName = "Dental360DBDataSet";
            this.dental360DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource1, "StaffLastName", true));
            this.textBoxLastName.Location = new System.Drawing.Point(138, 94);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(139, 20);
            this.textBoxLastName.TabIndex = 6;
            // 
            // staffBindingSource1
            // 
            this.staffBindingSource1.DataMember = "Staff";
            this.staffBindingSource1.DataSource = this.dental360DBDataSet;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource2, "StaffPhoneNumber", true));
            this.textBoxPhone.Location = new System.Drawing.Point(138, 122);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(139, 20);
            this.textBoxPhone.TabIndex = 7;
            // 
            // staffBindingSource2
            // 
            this.staffBindingSource2.DataMember = "Staff";
            this.staffBindingSource2.DataSource = this.dental360DBDataSet;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dental360DBDataSet, "Staff.StaffEmail", true));
            this.textBoxEmail.Location = new System.Drawing.Point(138, 152);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(208, 20);
            this.textBoxEmail.TabIndex = 8;
            // 
            // buttonAddStaff
            // 
            this.buttonAddStaff.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAddStaff.FlatAppearance.BorderSize = 0;
            this.buttonAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStaff.Location = new System.Drawing.Point(129, 207);
            this.buttonAddStaff.Name = "buttonAddStaff";
            this.buttonAddStaff.Size = new System.Drawing.Size(96, 39);
            this.buttonAddStaff.TabIndex = 9;
            this.buttonAddStaff.Text = "Add Staff";
            this.buttonAddStaff.UseVisualStyleBackColor = false;
            this.buttonAddStaff.Click += new System.EventHandler(this.ButtonAddStaff_Click);
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // NewStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(363, 258);
            this.Controls.Add(this.buttonAddStaff);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelAddStaff);
            this.Name = "NewStaff";
            this.Text = "Add Staff";
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dental360DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddStaff;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonAddStaff;
        private Dental360DBDataSet dental360DBDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private Dental360DBDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.BindingSource staffBindingSource1;
        private System.Windows.Forms.BindingSource staffBindingSource2;
    }
}