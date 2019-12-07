namespace ProjectTeam13Dental360
{
    partial class FirstScreen
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
            this.labelLogo = new System.Windows.Forms.Label();
            this.buttonSearchPatientStaff = new System.Windows.Forms.Button();
            this.buttonCheckSchedule = new System.Windows.Forms.Button();
            this.buttonAdminControls = new System.Windows.Forms.Button();
            this.buttonBookAppointment = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogo
            // 
            this.labelLogo.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLogo.Location = new System.Drawing.Point(0, 0);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(363, 39);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "Dental 360";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSearchPatientStaff
            // 
            this.buttonSearchPatientStaff.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSearchPatientStaff.FlatAppearance.BorderSize = 0;
            this.buttonSearchPatientStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchPatientStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchPatientStaff.Location = new System.Drawing.Point(-2, 42);
            this.buttonSearchPatientStaff.Name = "buttonSearchPatientStaff";
            this.buttonSearchPatientStaff.Size = new System.Drawing.Size(365, 66);
            this.buttonSearchPatientStaff.TabIndex = 1;
            this.buttonSearchPatientStaff.Text = "Search Patient or Staff";
            this.buttonSearchPatientStaff.UseVisualStyleBackColor = false;
            this.buttonSearchPatientStaff.Click += new System.EventHandler(this.ButtonSearchPatientStaff_Click);
            // 
            // buttonCheckSchedule
            // 
            this.buttonCheckSchedule.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCheckSchedule.FlatAppearance.BorderSize = 0;
            this.buttonCheckSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckSchedule.Location = new System.Drawing.Point(-2, 114);
            this.buttonCheckSchedule.Name = "buttonCheckSchedule";
            this.buttonCheckSchedule.Size = new System.Drawing.Size(365, 66);
            this.buttonCheckSchedule.TabIndex = 2;
            this.buttonCheckSchedule.Text = "Check Appointment Schedule";
            this.buttonCheckSchedule.UseVisualStyleBackColor = false;
            this.buttonCheckSchedule.Click += new System.EventHandler(this.ButtonCheckSchedule_Click);
            // 
            // buttonAdminControls
            // 
            this.buttonAdminControls.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAdminControls.FlatAppearance.BorderSize = 0;
            this.buttonAdminControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminControls.Location = new System.Drawing.Point(-2, 186);
            this.buttonAdminControls.Name = "buttonAdminControls";
            this.buttonAdminControls.Size = new System.Drawing.Size(365, 66);
            this.buttonAdminControls.TabIndex = 3;
            this.buttonAdminControls.Text = "Admin Controls";
            this.buttonAdminControls.UseVisualStyleBackColor = false;
            this.buttonAdminControls.Click += new System.EventHandler(this.ButtonAdminControls_Click);
            // 
            // buttonBookAppointment
            // 
            this.buttonBookAppointment.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonBookAppointment.FlatAppearance.BorderSize = 0;
            this.buttonBookAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookAppointment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBookAppointment.Location = new System.Drawing.Point(-2, 258);
            this.buttonBookAppointment.Name = "buttonBookAppointment";
            this.buttonBookAppointment.Size = new System.Drawing.Size(365, 66);
            this.buttonBookAppointment.TabIndex = 4;
            this.buttonBookAppointment.Text = "Book Appointment / New Patient";
            this.buttonBookAppointment.UseVisualStyleBackColor = false;
            this.buttonBookAppointment.Click += new System.EventHandler(this.ButtonBookAppointment_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(136, 330);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(82, 33);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // FirstScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(363, 369);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBookAppointment);
            this.Controls.Add(this.buttonAdminControls);
            this.Controls.Add(this.buttonCheckSchedule);
            this.Controls.Add(this.buttonSearchPatientStaff);
            this.Controls.Add(this.labelLogo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FirstScreen";
            this.Text = "Welcome!";
            this.Load += new System.EventHandler(this.FirstScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Button buttonSearchPatientStaff;
        private System.Windows.Forms.Button buttonCheckSchedule;
        private System.Windows.Forms.Button buttonAdminControls;
        private System.Windows.Forms.Button buttonBookAppointment;
        private System.Windows.Forms.Button buttonExit;
    }
}

