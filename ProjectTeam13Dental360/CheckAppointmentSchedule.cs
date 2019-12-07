using Dental360TestDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectTeam13Dental360
{
    public partial class CheckAppointmentSchedule : Form
    {
        Dental360Entities context;
        public CheckAppointmentSchedule()
        {
            InitializeComponent();
            context = new Dental360Entities();
            InitializeFormControls();
            //buttonCheckSchedule.Click += ButtonCheckSchedule_Click;
        }

        /// <summary>
        /// On click event handler for buttonCheckSchedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCheckSchedule_Click(object sender, EventArgs e)
        {
            CheckSchedule();
        }

        private void CheckSchedule()
        {
            try
            {
                context.Appointments.Load();

                //Picks the dateTime value from the form entered by user
                DateTime date = dateTimePickerDate.Value.Date;
                int staffId = -1;

                //checks if the user didn't enter any value for StaffId
                if (string.IsNullOrEmpty(textBoxStaffId.Text.Trim()))
                {
                    MessageBox.Show("Please enter the Staff Id");
                    return;
                }
                //Converts the StaffId string to integer
                else
                {
                    staffId = Convert.ToInt32(textBoxStaffId.Text.Trim());

                }

                // Fetching current time so that we can compare later if the booking is in progress or upcoming
                //They are differentiated by different color in the screen
                string currentTime = DateTime.Now.ToString("HH:mm");
                DateTime time = DateTime.Parse(currentTime);

                //This query will fetch all the bookings of the date selected. Also, if the staff_ID is entered, the data will be fetched for that Staff
                //Otherwise, it will show all the bookings of that date(selected in date time picker)
                var query = context.Appointments
                    .Where(x => x.StaffId == staffId && x.AppointmentDate.Day == date.Day && x.AppointmentDate.Month == date.Month && x.AppointmentDate.Year == date.Year || x.AppointmentDate.Day == date.Day && x.AppointmentDate.Month == date.Month && x.AppointmentDate.Year == date.Year && staffId == -1)
                    .Select(x => new AppointmentData
                    {
                        AppointmentID = x.AppointmentId,
                        PatientPhone = x.PatientPhone,
                        ServiceName = x.Service.ServiceName,
                        StaffName = x.Staff.StaffFirstName,
                        AppointmentDate = x.AppointmentDate,
                        AppointmentStartTime = x.AppointmentStartTime,
                        AppointmentEndTime = x.AppointmentEndTime
                    }).ToList();

                dataGridViewAppointments.DataSource = query;
                dataGridViewAppointments.Refresh();

                //Displaying the totalAppointments
                textBoxTotalAppointments.Text = query.Count().ToString();

                //needed to get the index of row 
                int counter = 0;

                foreach (AppointmentData a in query)
                {
                    //Appointments in past(Finished)
                    if (time > a.AppointmentEndTime)
                    {
                        dataGridViewAppointments.Rows[counter].DefaultCellStyle.BackColor = Color.Red;
                    }
                    //Appointments in progress(Ongoing)
                    else if (time > a.AppointmentStartTime && time < a.AppointmentEndTime)
                    {
                        dataGridViewAppointments.Rows[counter].DefaultCellStyle.BackColor = Color.SkyBlue;
                    }
                    //Appointments in future(Upcoming)
                    else
                    {
                        dataGridViewAppointments.Rows[counter].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    counter++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }
        /// <summary>
        /// Function to intialize form controls
        /// </summary>
        public void InitializeFormControls()
        {

            dataGridViewAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            textBoxTotalAppointments.ReadOnly = true;
            dataGridViewAppointments.BorderStyle = BorderStyle.None;
            dataGridViewAppointments.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewAppointments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewAppointments.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewAppointments.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewAppointments.BackgroundColor = Color.White;
            dataGridViewAppointments.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            dataGridViewAppointments.EnableHeadersVisualStyles = false;
            dataGridViewAppointments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewAppointments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewAppointments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        /// <summary>
        /// Class for getters and setters for AppointmentData
        /// 
        /// </summary>
        private class AppointmentData
        {
            [DisplayName("Appointment ID")]
            public int AppointmentID { get; set; }

            [DisplayName("Patient Phone")]
            public string PatientPhone { get; set; }

            [DisplayName("Service ID")]
            public string ServiceName { get; set; }

            [DisplayName("Staff ID")]
            public string StaffName { get; set; }

            [DisplayName("Appointment Date")]
            public DateTime AppointmentDate { get; set; }

            [DisplayName("Service StartTime")]
            public DateTime AppointmentStartTime { get; set; }

            [DisplayName("Appointment EndTime")]
            public DateTime AppointmentEndTime { get; set; }


        }

       
    }
}
