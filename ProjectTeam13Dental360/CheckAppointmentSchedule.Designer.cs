namespace ProjectTeam13Dental360
{
    partial class CheckAppointmentSchedule
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
            this.labelCheckAppointmentSchedule = new System.Windows.Forms.Label();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.labelStaffId = new System.Windows.Forms.Label();
            this.labelSelectDate = new System.Windows.Forms.Label();
            this.labeTotalAppointments = new System.Windows.Forms.Label();
            this.textBoxStaffId = new System.Windows.Forms.TextBox();
            this.textBoxTotalAppointments = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.buttonCheckSchedule = new System.Windows.Forms.Button();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelFinished = new System.Windows.Forms.Label();
            this.labelOngoing = new System.Windows.Forms.Label();
            this.labelUpcoming = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCheckAppointmentSchedule
            // 
            this.labelCheckAppointmentSchedule.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelCheckAppointmentSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCheckAppointmentSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckAppointmentSchedule.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCheckAppointmentSchedule.Location = new System.Drawing.Point(0, 0);
            this.labelCheckAppointmentSchedule.Name = "labelCheckAppointmentSchedule";
            this.labelCheckAppointmentSchedule.Size = new System.Drawing.Size(746, 42);
            this.labelCheckAppointmentSchedule.TabIndex = 0;
            this.labelCheckAppointmentSchedule.Text = "Check Appointment Schedule";
            this.labelCheckAppointmentSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(5, 45);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.Size = new System.Drawing.Size(734, 161);
            this.dataGridViewAppointments.TabIndex = 1;
            // 
            // labelStaffId
            // 
            this.labelStaffId.AutoSize = true;
            this.labelStaffId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaffId.Location = new System.Drawing.Point(25, 231);
            this.labelStaffId.Name = "labelStaffId";
            this.labelStaffId.Size = new System.Drawing.Size(48, 16);
            this.labelStaffId.TabIndex = 2;
            this.labelStaffId.Text = "Staff Id";
            // 
            // labelSelectDate
            // 
            this.labelSelectDate.AutoSize = true;
            this.labelSelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectDate.Location = new System.Drawing.Point(25, 260);
            this.labelSelectDate.Name = "labelSelectDate";
            this.labelSelectDate.Size = new System.Drawing.Size(78, 16);
            this.labelSelectDate.TabIndex = 3;
            this.labelSelectDate.Text = "Select Date";
            // 
            // labeTotalAppointments
            // 
            this.labeTotalAppointments.AutoSize = true;
            this.labeTotalAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeTotalAppointments.Location = new System.Drawing.Point(25, 289);
            this.labeTotalAppointments.Name = "labeTotalAppointments";
            this.labeTotalAppointments.Size = new System.Drawing.Size(124, 16);
            this.labeTotalAppointments.TabIndex = 4;
            this.labeTotalAppointments.Text = "Total Appointments";
            // 
            // textBoxStaffId
            // 
            this.textBoxStaffId.Location = new System.Drawing.Point(195, 226);
            this.textBoxStaffId.Name = "textBoxStaffId";
            this.textBoxStaffId.Size = new System.Drawing.Size(134, 20);
            this.textBoxStaffId.TabIndex = 5;
            // 
            // textBoxTotalAppointments
            // 
            this.textBoxTotalAppointments.Location = new System.Drawing.Point(195, 284);
            this.textBoxTotalAppointments.Name = "textBoxTotalAppointments";
            this.textBoxTotalAppointments.Size = new System.Drawing.Size(134, 20);
            this.textBoxTotalAppointments.TabIndex = 7;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(195, 255);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(134, 20);
            this.dateTimePickerDate.TabIndex = 8;
            // 
            // buttonCheckSchedule
            // 
            this.buttonCheckSchedule.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCheckSchedule.FlatAppearance.BorderSize = 0;
            this.buttonCheckSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckSchedule.Location = new System.Drawing.Point(394, 247);
            this.buttonCheckSchedule.Name = "buttonCheckSchedule";
            this.buttonCheckSchedule.Size = new System.Drawing.Size(170, 38);
            this.buttonCheckSchedule.TabIndex = 9;
            this.buttonCheckSchedule.Text = "Check Schedule";
            this.buttonCheckSchedule.UseVisualStyleBackColor = false;
            this.buttonCheckSchedule.Click += new System.EventHandler(this.ButtonCheckSchedule_Click);
            // 
            // labelRed
            // 
            this.labelRed.BackColor = System.Drawing.Color.Red;
            this.labelRed.Location = new System.Drawing.Point(612, 234);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(16, 15);
            this.labelRed.TabIndex = 10;
            // 
            // labelBlue
            // 
            this.labelBlue.BackColor = System.Drawing.Color.SkyBlue;
            this.labelBlue.Location = new System.Drawing.Point(612, 260);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(16, 15);
            this.labelBlue.TabIndex = 11;
            // 
            // labelGreen
            // 
            this.labelGreen.BackColor = System.Drawing.Color.LightGreen;
            this.labelGreen.Location = new System.Drawing.Point(612, 284);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(16, 15);
            this.labelGreen.TabIndex = 12;
            // 
            // labelFinished
            // 
            this.labelFinished.AutoSize = true;
            this.labelFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinished.Location = new System.Drawing.Point(634, 236);
            this.labelFinished.Name = "labelFinished";
            this.labelFinished.Size = new System.Drawing.Size(59, 16);
            this.labelFinished.TabIndex = 13;
            this.labelFinished.Text = "Finished";
            // 
            // labelOngoing
            // 
            this.labelOngoing.AutoSize = true;
            this.labelOngoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOngoing.Location = new System.Drawing.Point(634, 260);
            this.labelOngoing.Name = "labelOngoing";
            this.labelOngoing.Size = new System.Drawing.Size(59, 16);
            this.labelOngoing.TabIndex = 14;
            this.labelOngoing.Text = "Ongoing";
            // 
            // labelUpcoming
            // 
            this.labelUpcoming.AutoSize = true;
            this.labelUpcoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpcoming.Location = new System.Drawing.Point(634, 284);
            this.labelUpcoming.Name = "labelUpcoming";
            this.labelUpcoming.Size = new System.Drawing.Size(70, 16);
            this.labelUpcoming.TabIndex = 15;
            this.labelUpcoming.Text = "Upcoming";
            // 
            // CheckAppointmentSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(746, 328);
            this.Controls.Add(this.labelUpcoming);
            this.Controls.Add(this.labelOngoing);
            this.Controls.Add(this.labelFinished);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.buttonCheckSchedule);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.textBoxTotalAppointments);
            this.Controls.Add(this.textBoxStaffId);
            this.Controls.Add(this.labeTotalAppointments);
            this.Controls.Add(this.labelSelectDate);
            this.Controls.Add(this.labelStaffId);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Controls.Add(this.labelCheckAppointmentSchedule);
            this.Name = "CheckAppointmentSchedule";
            this.Text = "Check Appointment Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCheckAppointmentSchedule;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Label labelStaffId;
        private System.Windows.Forms.Label labelSelectDate;
        private System.Windows.Forms.Label labeTotalAppointments;
        private System.Windows.Forms.TextBox textBoxStaffId;
        private System.Windows.Forms.TextBox textBoxTotalAppointments;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button buttonCheckSchedule;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelFinished;
        private System.Windows.Forms.Label labelOngoing;
        private System.Windows.Forms.Label labelUpcoming;
    }
}