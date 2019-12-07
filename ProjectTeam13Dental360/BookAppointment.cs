using Dental360TestDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam13Dental360
{
    public partial class BookAppointment : Form
    {
        Dental360Entities context;
        public BookAppointment()
        {
            InitializeComponent();
            context = new Dental360Entities();
            this.Load += BookAppointment_Load;

            //Initializing form components
            InitializeFormControls();

            //Calling AutoCompletePhoneNumber function
            AutoCompletePhoneNumber();

            textBoxPhone.KeyDown += TextBoxPhone_KeyDown;
            //buttonAddNewPatient.Click += ButtonAddNewPatient_Click;
            //buttonBookAppointment.Click += ButtonBookAppointment_Click;
        }

        /// <summary>
        /// On click event handler for buttonBookAppointment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBookAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                //Loading tables to get data
                context.Appointments.Load();
                context.SaveChanges();

                context.Staffs.Load();
                context.SaveChanges();

                context.Services.Load();
                context.SaveChanges();

                //Getting the selected Service and Staff name from their respective listboxes
                string serviceNametxt = listBoxServices.SelectedItem.ToString();
                string staffName = listBoxStaff.SelectedItem.ToString();

                //Validating the user input
                if (Validation())
                {
                    MessageBox.Show("Sorry, Vaildation Failed!");
                    return;
                }

                //Once the Service Name is selected and saved in a local string variable,
                //the below query will fetch the service Time of that Service name to calculate the Service End Time
                var serviceTime = context.Services
                                  .Where(s => s.ServiceName == serviceNametxt)
                                  .Select(s => s.ServiceTimeTaken).FirstOrDefault().ToString();

                //The fetched result is converted to Double as the time is in string format
                double serveTime = Convert.ToDouble(serviceTime);

                //Getting the selected Date and time for the appointment. Here, if the User is trying to book
                //For the past date(It will compare with the current time of the system), he wont be allowed
                //to do so

                //The value of the joined DateTime picker objects is stored in one DateTime object - selectedDate
                DateTime selectedDate = dateTimePickerDate.Value.Date +
                                  dateTimePickerTime.Value.TimeOfDay;

                //Getting the current time for the comparison
                DateTime date = DateTime.Now;

                //If the selected time in dateTimePickerDate is less the current time
                // that means the user is trying to book in the past, therfore this should prompt the user 
                if (selectedDate < date)
                {
                    MessageBox.Show("Cannot book appointments in past");
                    return;
                }

                // Calculating the Service end time now that we have user entered booking time and service time
                //This value will be stored in database once the user finally books the appointment 
                DateTime serviceEndTime = selectedDate.AddMinutes(serveTime);

                //The Service Name is selected and saved in a local string variable above,
                //the below query will fetch the service ID of that Service name 
                int serviceId = context.Services
                               .Where(s => s.ServiceName == serviceNametxt)
                               .Select(s => s.ServiceId).FirstOrDefault();


                //The Staff Name is selected and saved in a local string variable above,
                //the below query will fetch the Staff ID of that Service name 
                int staffId = context.Staffs
                    .Where(x => x.StaffFirstName == staffName)
                    .Select(x => x.StaffId).FirstOrDefault();

                // In the query below, we are checking the service end time of the selected date
                //If the selected time selected by user is less than the end time of the service the staff is already 
                //doing, it will prompt the user with the message that the user is busy at the moment and 
                //then user has to select different time or different Staff
                var serviceEndtimeCheck = from x in context.Appointments
                                          where x.StaffId == staffId
                                          && x.AppointmentDate.Day == selectedDate.Day
                                          && x.AppointmentDate.Month == selectedDate.Month
                                          && x.AppointmentDate.Year == selectedDate.Year
                                          && x.AppointmentStartTime <= selectedDate
                                          && x.AppointmentEndTime >= selectedDate
                                          select x.AppointmentEndTime;


                if (serviceEndtimeCheck.Count() > 0)
                {
                    MessageBox.Show("This staff is busy at this time, Please book another staff");
                    return;
                }

                //Once all validations are done, User will be able to book an appointment
                //for the patient that has been entered in the patient detail text boxes
                Appointment appointment = new Appointment { PatientPhone = textBoxPhone.Text, ServiceId = serviceId, StaffId = staffId, AppointmentDate = selectedDate, AppointmentStartTime = selectedDate, AppointmentEndTime = serviceEndTime };
                context.Appointments.Add(appointment);
                context.SaveChanges();

                //Fetching the new Primary key just to display one new record.
                int newPK = appointment.AppointmentId;

                
                context.Appointments.Load();

                //Adding the new appointment to the booking table and then showing int the data grid view
                var bookingDetailsquery = context.Appointments
                    .Where(x => x.AppointmentId >= newPK)
                    .Select(x => new AppointmentData
                    {
                        AppointmentId = x.AppointmentId,
                        PatientPhone = x.PatientPhone,
                        ServiceName = x.Service.ServiceName,
                        StaffName = x.Staff.StaffFirstName,
                        AppointmentDate = x.AppointmentDate,
                        AppointmentStartTime = x.AppointmentStartTime,
                        AppointmentEndTime = x.AppointmentEndTime

                    }).ToList();

                dataGridViewBookAppointment.Refresh();
                dataGridViewBookAppointment.DataSource = bookingDetailsquery;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        /// <summary>
        /// On click event handler for buttonAddNewPatient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddNewPatient_Click(object sender, EventArgs e)
        {
            AddNewPatient();
        }

        /// <summary>
        /// Function to add a new patient
        /// </summary>
        private void AddNewPatient()
        {
            try
            {
                context.Patients.Load();

                //Getting all the entered details of the patient
                string patientFirstName = textBoxFirstName.Text.Trim();
                string patientLastName = textBoxLastName.Text.Trim();
                string patientEmail = textBoxEmail.Text.Trim();
                string patientPhone = textBoxPhone.Text.Trim();


                //Validating the user input
                if (Validation())
                {
                    MessageBox.Show("Validation Failed!! Cannot insert");
                    return;
                }

                //After validation, new patient will be added
                List<Patient> patientList = new List<Patient>()
            {
                         new Patient { PatientPhone=patientPhone,PatientFirstName=patientFirstName,PatientLastName=patientLastName,PatientEmail=patientEmail},
            };

                context.Patients.AddRange(patientList);
                context.SaveChanges();

                //prompting user that the client is added
                MessageBox.Show("New Client is added");
                context.Patients.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Funtion to initialize form controls
        /// </summary>
        public void InitializeFormControls()
        {

            dateTimePickerTime.ShowUpDown = true;
            dateTimePickerTime.CustomFormat = "HH:mm";
            dateTimePickerTime.Format = DateTimePickerFormat.Custom;
            dataGridViewBookAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            buttonAddNewPatient.Enabled = false;
            dataGridViewBookAppointment.BorderStyle = BorderStyle.None;
            dataGridViewBookAppointment.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewBookAppointment.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewBookAppointment.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewBookAppointment.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewBookAppointment.BackgroundColor = Color.White;

            dataGridViewBookAppointment.EnableHeadersVisualStyles = false;
            dataGridViewBookAppointment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewBookAppointment.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewBookAppointment.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //populating list boxes
            try
            {
                var serviceList = context.Services
                            .Select(s => s.ServiceName).Distinct().ToList();

                listBoxServices.DataSource = serviceList;

                var staffNameList = context.Staffs
                    .Select(s => s.StaffFirstName).ToList();

                listBoxStaff.DataSource = staffNameList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Key down event handler for textBoxPhone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxPhone_KeyDown(object sender, KeyEventArgs e)
        {

            context.Patients.Load();

            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    string phoneNumberEntered = textBoxPhone.Text;
                    bool result = false;

                    // If the phone number is already existing in the database, it will show up and details will be filled automatically
                    var matchPhoneNumber = context.Patients
                        .Where(x => x.PatientPhone == phoneNumberEntered)
                        .Select(x => x.PatientPhone);


                    if (matchPhoneNumber.Count() > 0)
                    {
                        result = true;

                    }

                    //if phone number matches the phone number entered, the Autodetails method is called to fill other text boxes
                    if (result)
                    {
                        AutoFillDetails(phoneNumberEntered);
                    }

                    //if the result is false, then clear textboxes and enable the Add new client button
                    else
                    {
                        textBoxFirstName.Text = "";
                        textBoxLastName.Text = "";
                        textBoxEmail.Text = "";
                        buttonAddNewPatient.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        /// <summary>
        /// Function to auto complete phone number
        /// </summary>
        private void AutoCompletePhoneNumber()
        {

            context.Patients.Load();
            //setting autocomplete properties to the the textBoxPhone
            textBoxPhone.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxPhone.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collectionPhoneNum = new AutoCompleteStringCollection();

            var clientPhoneNumber = from a in context.Patients
                                    where a.PatientPhone.StartsWith(textBoxPhone.Text)
                                    select a.PatientPhone;

            collectionPhoneNum.AddRange(clientPhoneNumber.ToArray());

            textBoxPhone.AutoCompleteCustomSource = collectionPhoneNum;
        }

        /// <summary>
        /// Fuction to auto fill details of the patient
        /// </summary>
        /// <param name="phoneNumber"></param>
        public void AutoFillDetails(string phoneNumber)
        {
            try
            {
                // takes the phone number, and get the details
                var patientDetails = context.Patients
                    .Where(x => x.PatientPhone == phoneNumber)
                    .Select(x => x);

                //populate when the phone number matches
                foreach (Patient c in patientDetails)
                {
                    textBoxFirstName.Text = c.PatientFirstName;
                    textBoxLastName.Text = c.PatientLastName;
                    textBoxEmail.Text = c.PatientEmail;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BookAppointment_Load(object sender, EventArgs e)
        {
            try
            {
                context.Patients.Load();
                context.Staffs.Load();
                context.Services.Load();
                context.Appointments.Load();
                context.Database.Log = (s => Debug.Write(s));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Funtion to validate the user input
        /// </summary>
        /// <returns></returns>
        public Boolean Validation()
        {
            string patientFirstName = textBoxFirstName.Text.Trim();
            string patientLastName = textBoxLastName.Text.Trim();
            string patientEmail = textBoxEmail.Text.Trim();
            string patientPhone = textBoxPhone.Text.Trim();

            

            long phoneNum;

            if (long.TryParse(patientPhone, out phoneNum) == false || string.IsNullOrEmpty(patientPhone) || patientPhone.Length != 10)
            {
                MessageBox.Show("Phone Number Not correct");
                return true;
            }

            if (string.IsNullOrEmpty(patientFirstName))
            {
                MessageBox.Show("Client First Name cant be null");
                return true;
            }
            if (string.IsNullOrEmpty(patientLastName))
            {
                MessageBox.Show("Client Last Name cant be null");
                return true;
            }

            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (string.IsNullOrEmpty(patientEmail) || Regex.IsMatch(patientEmail, pattern) == false)
            {
                MessageBox.Show("Not a valid Email address");
                return true;
            }

            return false;
        }

        /// <summary>
        /// Class for getters and setters for AppointmentData
        /// </summary>
        private class AppointmentData
        {
            [DisplayName("Appointment ID")]
            public int AppointmentId { get; set; }

            [DisplayName("Patient Phone")]
            public string PatientPhone { get; set; }

            [DisplayName("Service ID")]
            public string ServiceName { get; set; }

            [DisplayName("Staff ID")]
            public string StaffName { get; set; }

            [DisplayName("Appointment Date")]
            public DateTime AppointmentDate { get; set; }

            [DisplayName("Appointment StartTime")]
            public DateTime AppointmentStartTime { get; set; }

            [DisplayName("Appointment EndTime")]
            public DateTime AppointmentEndTime { get; set; }


        }
    }
}
