using Dental360TestDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectTeam13Dental360
{
    public partial class AdminControls : Form
    {
        Dental360Entities context;
        DataSet dataSet = new DataSet();
        public AdminControls()
        {
            InitializeComponent();
            context = new Dental360Entities();

            InitializeFormControls();
            //buttonAllAppointments.Click += ButtonAllAppointments_Click;
            //buttonAllPatients.Click += ButtonAllPatients_Click;
            //buttonAllServices.Click += ButtonAllServices_Click;
            //buttonAllStaff.Click += ButtonAllStaff_Click;
            //buttonBackupXml.Click += ButtonBackupXml_Click;
            //buttonUpdateStaff.Click += ButtonUpdateStaff_Click;
        }

        /// <summary>
        /// On click event handler for buttonAllAppointments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAllAppointments_Click(object sender, EventArgs e)
        {
            ShowAllAppointments();
        }

        /// <summary>
        /// Function to display all appointments in the datagridview
        /// </summary>
        private void ShowAllAppointments()
        {
            try
            {
                context.Appointments.Load();

                //Getting all appointments and displaying
                var appointmentsQuery = context.Appointments
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

                dataGridViewAdminControls.DataSource = appointmentsQuery;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        /// <summary>
        /// On click event handler for buttonAllStaff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAllStaff_Click(object sender, EventArgs e)
        {
            ShowAllStaff();
        }

        /// <summary>
        /// On click event handler for buttonAllPatients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAllPatients_Click(object sender, EventArgs e)
        {
            ShowAllPatients();
        }

        /// <summary>
        /// Function to display all patients in the datagridview
        /// </summary>
        private void ShowAllPatients()
        {
            try
            {
                context.Patients.Load();

                //Getting all patients and displaying
                var patientQuery = context.Patients
                                  .Select(x => new PatientData
                                  {
                                      Phone = x.PatientPhone,
                                      FirstName = x.PatientFirstName,
                                      LastName = x.PatientLastName,
                                      Email = x.PatientEmail,
                                  }).ToList();

                dataGridViewAdminControls.DataSource = patientQuery;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Onclick event handler for buttonAllServices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAllServices_Click(object sender, EventArgs e)
        {
            ShowAllServices();
        }

        /// <summary>
        /// Function to show all staff
        /// </summary>
        private void ShowAllStaff()
        {
            try
            {
                context.Staffs.Load();
                //Getting all staff and displaying
                var staffQuery = context.Staffs
                                  .Select(x => new StaffData
                                  {
                                      StaffId = x.StaffId,
                                      FirstName = x.StaffFirstName,
                                      LastName = x.StaffLastName,
                                      PhoneNumber = x.StaffPhoneNumber,
                                      Email = x.StaffEmail
                                  }).ToList();

                dataGridViewAdminControls.DataSource = staffQuery;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Function to show all services
        /// </summary>
        private void ShowAllServices()
        {
            try
            {
                context.Services.Load();
                //Getting all services and displaying
                var serviceQuery = context.Services
                                  .Select(x => new ServiceData
                                  {
                                      ServiceID = x.ServiceId,
                                      ServiceName = x.ServiceName,
                                      Price = x.ServicePrice,
                                      TimeTaken = x.ServiceTimeTaken,
                                  }).ToList();

                dataGridViewAdminControls.DataSource = serviceQuery;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Function to initialize form controls
        /// </summary>
        public void InitializeFormControls()
        {
            dataGridViewAdminControls.BorderStyle = BorderStyle.None;
            dataGridViewAdminControls.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewAdminControls.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewAdminControls.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewAdminControls.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewAdminControls.BackgroundColor = Color.White;
            dataGridViewAdminControls.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            dataGridViewAdminControls.EnableHeadersVisualStyles = false;
            dataGridViewAdminControls.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewAdminControls.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewAdminControls.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            
        }

        /// <summary>
        /// Class for getters and setters for ServiceData
        /// </summary>
        private class ServiceData
        {
            [DisplayName("Service ID")]
            public int ServiceID { get; set; }

            [DisplayName("Service Name")]
            public string ServiceName { get; set; }

            [DisplayName("Service Price")]
            public decimal Price { get; set; }

            [DisplayName("Time Taken")]
            public int TimeTaken { get; set; }
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

        /// <summary>
        /// Class for getters and setter for StaffData
        /// </summary>
        private class StaffData
        {
            [DisplayName("Staff ID")]
            public int StaffId { get; set; }

            [DisplayName("First Name")]
            public string FirstName { get; set; }

            [DisplayName("Last Name")]
            public string LastName { get; set; }

            [DisplayName("Phone Number")]
            public string PhoneNumber { get; set; }

            [DisplayName("Email")]
            public string Email { get; set; }

        }

        /// <summary>
        /// Class for getters and setters for PatientData
        /// </summary>
        private class PatientData
        {
            [DisplayName("Patient Phone Number")]
            public string Phone { get; set; }

            [DisplayName("First Name")]
            public string FirstName { get; set; }

            [DisplayName("Last Name")]
            public string LastName { get; set; }

            [DisplayName("Email")]
            public string Email { get; set; }
        }

        /// <summary>
        /// On click event handler for buttonBackupXml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBackupXml_Click(object sender, EventArgs e)
        {
            CreateXMLBackup();
            MessageBox.Show("Back Up created!");
        }

        /// <summary>
        /// FUnction to create xml back up
        /// </summary>
        public void CreateXMLBackup()
        {
            try
            {
                // This method will save all the data in the tables to different XML files
                XElement ClientsXML = new XElement("Patients",
                    (from patient in context.Patients
                     select new
                     {
                         patient.PatientFirstName,
                         patient.PatientLastName,
                         patient.PatientEmail,
                         patient.PatientPhone,
                     }).ToList().Select(
                        c => new XElement("Patient",
                            new XElement("FirstName", c.PatientFirstName),
                            new XElement("LastName", c.PatientLastName),
                            new XElement("Email", c.PatientEmail),
                            new XElement("Phone", c.PatientPhone)
                    )));

                ClientsXML.Save("XMLPatients.xml");

                XElement StaffXML = new XElement("Staff",
                   (from staff in context.Staffs
                    select new
                    {
                        staff.StaffId,
                        staff.StaffFirstName,
                        staff.StaffLastName,
                        staff.StaffPhoneNumber,
                        staff.StaffEmail
                    }).ToList().Select(
                       s => new XElement("Staff",
                           new XElement("StaffId", s.StaffId),
                           new XElement("FirstName", s.StaffFirstName),
                           new XElement("LastName", s.StaffLastName),
                           new XElement("Email", s.StaffEmail),
                           new XElement("PhoneNumber", s.StaffPhoneNumber)
                   )));

                StaffXML.Save("XMLStaff.xml");


                XElement ServiceXML = new XElement("Services",
                   (from service in context.Services
                    select new
                    {
                        service.ServiceId,
                        service.ServiceName,
                        service.ServicePrice,
                        service.ServiceTimeTaken
                    }).ToList().Select(
                       s => new XElement("Services",
                           new XElement("ServiceId", s.ServiceId),
                           new XElement("ServiceName", s.ServiceName),
                           new XElement("Price", s.ServicePrice),
                           new XElement("TimeTaken", s.ServiceTimeTaken)
                   )));

                ServiceXML.Save("XMLService.xml");



                XElement AppointmentsXML = new XElement("Appointments",
                 (from appointment in context.Appointments
                  select new
                  {
                      appointment.AppointmentId,
                      appointment.PatientPhone,
                      appointment.ServiceId,
                      appointment.StaffId,
                      appointment.AppointmentDate,
                      appointment.AppointmentStartTime,
                      appointment.AppointmentEndTime

                  }).ToList().Select(
                     a => new XElement("Appointments",
                         new XElement("AppointmentId", a.AppointmentId),
                         new XElement("PatientPhone", a.PatientPhone),
                         new XElement("ServiceId", a.ServiceId),
                         new XElement("StaffId", a.StaffId),
                         new XElement("AppointmentDate", a.AppointmentDate),
                         new XElement("AppointmentStartTime", a.AppointmentStartTime),
                         new XElement("AppointmentEndTime", a.AppointmentEndTime)
                 )));

                AppointmentsXML.Save("XMLAppointments.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// On click even handler for buttonUpdateStaff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdateStaff_Click(object sender, EventArgs e)
        {
            try
            {
                context.Staffs.Load();

                dataGridViewAdminControls.DataSource = context.Staffs.Local.ToBindingList();

                //Making StaffId read only so that user cannot change it
                dataGridViewAdminControls.Columns["StaffId"].ReadOnly = true;

                //saving the changes
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// On click event handler for buttonNewStaff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNewStaff_Click(object sender, EventArgs e)
        {
            NewStaff ns = new NewStaff();
            ns.ShowDialog();
        }

        /// <summary>
        /// On click event handler for buttonNewPatient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNewPatient_Click(object sender, EventArgs e)
        {
            NewPatient np = new NewPatient();
            np.ShowDialog();
        }

        /// <summary>
        /// On click event handler for buttonNewService
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNewService_Click(object sender, EventArgs e)
        {
            NewService nService = new NewService();
            nService.ShowDialog();
        }

        /// <summary>
        /// On click event handler for buttonUpdatePatient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdatePatient_Click(object sender, EventArgs e)
        {
            try
            {
                context.Patients.Load();

                dataGridViewAdminControls.DataSource = context.Patients.Local.ToBindingList();
                dataGridViewAdminControls.Columns["PatientFirstName"].ReadOnly = true;
                dataGridViewAdminControls.Columns["PatientPhone"].ReadOnly = true;

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// On click event handler for buttonUpdateService
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdateService_Click(object sender, EventArgs e)
        {

            try
            {
                context.Services.Load();

                dataGridViewAdminControls.DataSource = context.Services.Local.ToBindingList();
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       // private void buttonRestoreBackup_Click(object sender, EventArgs e)
        //{
          //  DataTable dataTableStaff = new DataTable();
            //dataTableStaff.ReadXml();
            //dataGridViewAdminControls.DataSource = dataTableStaff;
            //MessageBox.Show("BackUp Restored");
        //}

            /// <summary>
            /// Onclick event handler for buttonDeleteStaff
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        private void ButtonDeleteStaff_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    context.Staffs.Load();
                    ShowAllStaff();

                    if (dataGridViewAdminControls.SelectedRows.Count > 0)
                    {
                        //getting the staff id to be deleted from the datagridview
                        int toBeDeleted = Convert.ToInt32(dataGridViewAdminControls.Rows[0].Cells[0].Value.ToString());

                        //query to select the staff id to be deleted from the database
                        var selectedStaff = context.Staffs
                        .Where(x => x.StaffId == toBeDeleted)
                        .Select(x => x).FirstOrDefault();


                        context.Staffs.Remove(selectedStaff);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            
        }

        /// <summary>
        /// On click event handler for buttonSalesReport
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSalesReport_Click(object sender, EventArgs e)
        {
            SalesReport sr = new SalesReport();
            sr.ShowDialog();
        }

        private void ButtonDeletePatient_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    context.Patients.Load();
                    ShowAllPatients();

                    if (dataGridViewAdminControls.SelectedRows.Count > 0)
                    {
                        //getting the patient phone to be deleted from the datagridview
                        string toBeDeleted = dataGridViewAdminControls.Rows[0].Cells[0].Value.ToString();

                        //query to select patient phone to be deleted from the database
                        var selectedPatient = context.Patients
                        .Where(x => x.PatientPhone == toBeDeleted)
                        .Select(x => x).FirstOrDefault();

                        //Removing the patient
                        context.Patients.Remove(selectedPatient);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ButtonDeleteService_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    context.Services.Load();
                    ShowAllServices();

                    if (dataGridViewAdminControls.SelectedRows.Count > 0)
                    {
                        //getting the service id to be deleted from the datagridview
                        int toBeDeleted = Convert.ToInt32(dataGridViewAdminControls.Rows[0].Cells[0].Value.ToString());

                        //query to select service id to be deleted from the database
                        var selectedService = context.Services
                        .Where(x => x.ServiceId == toBeDeleted)
                        .Select(x => x).FirstOrDefault();

                        //Removing the Service
                        context.Services.Remove(selectedService);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
    }

