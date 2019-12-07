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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam13Dental360
{
    public partial class FirstScreen : Form
    {
        Dental360Entities context;
        public FirstScreen()
        {
            InitializeComponent();
            context = new Dental360Entities();
            this.Load += FirstScreen_Load;
            //buttonBookAppointment.Click += ButtonBookAppointment_Click;
            //buttonSearchPatientStaff.Click += ButtonSearchPatientStaff_Click;
            //buttonCheckSchedule.Click += ButtonCheckSchedule_Click;
            //buttonAdminControls.Click += ButtonAdminControls_Click;
            //buttonExit.Click += ButtonExit_Click;

        }

        /// <summary>
        /// On click event Handler for buttonSearchPatientStaff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearchPatientStaff_Click(object sender, EventArgs e)
        {
            SearchPatient_Staff searchPatientStaff = new SearchPatient_Staff();
            searchPatientStaff.ShowDialog();
        }

        /// <summary>
        /// On click event handler for buttonCheckSchedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCheckSchedule_Click(object sender, EventArgs e)
        {
            CheckAppointmentSchedule checkSchedule = new CheckAppointmentSchedule();
            checkSchedule.ShowDialog();
        }

        /// <summary>
        /// On click event handler for buttonBookAppointment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBookAppointment_Click(object sender, EventArgs e)
        {
            BookAppointment b = new BookAppointment();
            b.ShowDialog();
        }

        /// <summary>
        /// function to seed data
        /// </summary>
        public void SeedData()
        {
            try
            {
                // Loading all tables and Inserting data in all the tables
                context.Patients.Load();
                context.Staffs.Load();
                context.Services.Load();
                context.Appointments.Load();

                context.Database.Log = (s => Debug.Write(s));

                context.Patients.Local.Clear();
                context.SaveChanges();

                List<Patient> patientList = new List<Patient>()
                  {
                               new Patient {  PatientPhone="7785674324",PatientFirstName="Miranda",PatientLastName="Mountain",PatientEmail="mirandamountain@gmail.com" },
                               new Patient {  PatientPhone="7785936788",PatientFirstName="James",PatientLastName="Garfield",PatientEmail="jamesgarfield@gmail.com" },
                               new Patient {  PatientPhone="7781563976",PatientFirstName="Tanisha",PatientLastName="Gaur",PatientEmail="tanishagaur112@gmail.com" },
                               new Patient {  PatientPhone="7788450642",PatientFirstName="Nicholas",PatientLastName="Sparks",PatientEmail="nicholassparks@gmail.com" },
                               new Patient {  PatientPhone="7788965032",PatientFirstName="Christian",PatientLastName="Lamingo",PatientEmail="chrislamingo@gmail.com" },
                               new Patient {  PatientPhone="6048629064",PatientFirstName="Allyson",PatientLastName="Morales",PatientEmail="allymorales12@gmail.com" },
                               new Patient {  PatientPhone="6040274572",PatientFirstName="Tanner",PatientLastName="Mountain",PatientEmail="tannermountain@gmail.com" },
                               new Patient {  PatientPhone="6047593963",PatientFirstName="Jashan",PatientLastName="Randhawa",PatientEmail="jashrandhawa64@gmail.com" },
                               new Patient {  PatientPhone="6049754378",PatientFirstName="Piyush",PatientLastName="Gupta",PatientEmail="piyushguot28@gmail.com" },
                               new Patient {  PatientPhone="7787497397",PatientFirstName="Evan",PatientLastName="Quinn",PatientEmail="quinnevan@gmail.com" },

                           };
                context.Patients.AddRange(patientList);
                context.SaveChanges();

                context.Staffs.Local.Clear();
                context.SaveChanges();

                context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Staff', RESEED, 0)");
                context.SaveChanges();

                List<Staff> staffList = new List<Staff>() {
                new Staff {  StaffPhoneNumber="6045321162",StaffFirstName="Dr. Ravi",StaffLastName="Kumar",StaffEmail="ravikumar@gmail.com" },
                new Staff {  StaffPhoneNumber="6046897902",StaffFirstName="Dr. Jason",StaffLastName="Brown",StaffEmail="jasonbrown@gmail.com" },
                new Staff {  StaffPhoneNumber="6046282930",StaffFirstName="Dr. Stan",StaffLastName="Smith",StaffEmail="drstan@gmail.com" },
                new Staff {  StaffPhoneNumber="7789920992",StaffFirstName="Dr. Gavin",StaffLastName="Conedo",StaffEmail="gavinconedowork@gmail.com" },
                new Staff {  StaffPhoneNumber="7787810292",StaffFirstName="Dr. Harvey",StaffLastName="Evans",StaffEmail="harveyevans@gmail.com" },
                new Staff {  StaffPhoneNumber="6044739608",StaffFirstName="Dr. Aaliyah",StaffLastName="Kaur",StaffEmail="aaliyahk@gmail.com" },
                new Staff {  StaffPhoneNumber="7784738359",StaffFirstName="Dr. Navpreet",StaffLastName="Kaur",StaffEmail="navkaur32@gmail.com" },
                new Staff {  StaffPhoneNumber="6046763963",StaffFirstName="Dr. Fred",StaffLastName="White",StaffEmail="fredwhite@gmail.com" },
                new Staff {  StaffPhoneNumber="7780275639",StaffFirstName="Dr. Elena",StaffLastName="Chang",StaffEmail="drelenachang@gmail.com" },
                new Staff {  StaffPhoneNumber="6046937925",StaffFirstName="Dr. Adam",StaffLastName="Smith",StaffEmail="adamsmith@gmail.com" },
            };

                context.Staffs.AddRange(staffList);
                context.SaveChanges();

                context.Services.Load();
                context.Services.Local.Clear();

                context.SaveChanges();
                context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Service', RESEED, 0)");
                context.SaveChanges();

                List<Service> serviceList = new List<Service>()
            {
                new Service{ ServiceName="Dental Examinations", ServicePrice=108.00m, ServiceTimeTaken=20},
                new Service{ ServiceName="Dental Crowns", ServicePrice=564.00m, ServiceTimeTaken=30},
                new Service{ ServiceName="Dental Sealants", ServicePrice=20.00m, ServiceTimeTaken=30},
                new Service{ ServiceName="Nutritional Consultation", ServicePrice=36.00m, ServiceTimeTaken=20},
                new Service{ ServiceName="Pediatric Dentistry", ServicePrice=30.00m, ServiceTimeTaken=45},
                new Service{ ServiceName="Dental Emergencies", ServicePrice=132.00m, ServiceTimeTaken=45},
                new Service{ ServiceName="Professional Dental Cleaning", ServicePrice=160.00m, ServiceTimeTaken=30},
                new Service{ ServiceName="Tooth (and Wisdom Tooth) Extractions", ServicePrice=116.00m, ServiceTimeTaken=45},
                new Service{ ServiceName="Dental Bridges", ServicePrice=300.00m, ServiceTimeTaken=30},
                new Service{ ServiceName="Oral Cancer Screening", ServicePrice=10.00m, ServiceTimeTaken=30},
                new Service{ ServiceName="Professional Fluoride Treatment", ServicePrice=20.00m, ServiceTimeTaken=45},
                new Service{ ServiceName="Root Canal", ServicePrice=376.00m, ServiceTimeTaken=30},
                new Service{ ServiceName="Tooth Coloured Dental Fillings", ServicePrice=116.00m, ServiceTimeTaken=25},
                new Service{ ServiceName="Dentures", ServicePrice=800.00m, ServiceTimeTaken=30},
                new Service{ ServiceName="Oral Hygiene Instructions", ServicePrice=36.00m, ServiceTimeTaken=15},
                new Service{ ServiceName="Dental Bonding", ServicePrice=170.00m, ServiceTimeTaken=60},
                new Service{ ServiceName="Dental Implants", ServicePrice=2256.00m, ServiceTimeTaken=120},
                new Service{ ServiceName="Orthodontic Treatment (Braces)", ServicePrice=500.00m, ServiceTimeTaken=60},
            };

                context.Services.AddRange(serviceList);
                context.SaveChanges();

                context.Appointments.Load();

                context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Appointment', RESEED, 0)");
                context.SaveChanges();
                context.Appointments.Local.Clear();
                context.SaveChanges();

                context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Appointment', RESEED, 0)");
                context.SaveChanges();

                context.Appointments.Load();

                context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Appointment', RESEED, 0)");
                context.SaveChanges();
                context.Appointments.Local.Clear();
                context.SaveChanges();

                context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Appointment', RESEED, 0)");
                context.SaveChanges();

                List<Appointment> bookingDataList = new List<Appointment>()
                 {
                     new Appointment{PatientPhone=patientList[0].PatientPhone, ServiceId=serviceList[0].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(-20),StaffId=staffList[0].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(-20), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[0].PatientPhone, ServiceId=serviceList[0].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(-30),StaffId=staffList[0].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(-30), AppointmentEndTime=DateTime.Now.AddHours(-1.2)},
                     new Appointment{PatientPhone=patientList[0].PatientPhone, ServiceId=serviceList[0].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(-40),StaffId=staffList[0].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(-40), AppointmentEndTime=DateTime.Now.AddHours(-1.2)},
                     new Appointment{PatientPhone=patientList[0].PatientPhone, ServiceId=serviceList[0].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(-31),StaffId=staffList[0].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(-31), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[0].PatientPhone, ServiceId=serviceList[0].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(-42),StaffId=staffList[0].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(-42), AppointmentEndTime=DateTime.Now.AddHours(-1.2)},
                     new Appointment{PatientPhone=patientList[0].PatientPhone, ServiceId=serviceList[0].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(15),StaffId=staffList[0].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(15), AppointmentEndTime=DateTime.Now.AddHours(-1.2)},
                     new Appointment{PatientPhone=patientList[0].PatientPhone, ServiceId=serviceList[0].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(30),StaffId=staffList[0].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(30), AppointmentEndTime=DateTime.Now.AddHours(-1.2)},

                     new Appointment{PatientPhone=patientList[1].PatientPhone, ServiceId=serviceList[1].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(-20),StaffId=staffList[1].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(-20), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[1].PatientPhone, ServiceId=serviceList[1].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(-4),StaffId=staffList[1].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(-4), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[1].PatientPhone, ServiceId=serviceList[1].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(-70),StaffId=staffList[1].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(-70), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[1].PatientPhone, ServiceId=serviceList[1].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(-8),StaffId=staffList[1].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(-8), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[1].PatientPhone, ServiceId=serviceList[1].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(10),StaffId=staffList[1].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(10), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[1].PatientPhone, ServiceId=serviceList[1].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(20),StaffId=staffList[1].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(20), AppointmentEndTime=DateTime.Now.AddHours(-1)},


                     new Appointment{PatientPhone=patientList[2].PatientPhone, ServiceId=serviceList[2].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(11),StaffId=staffList[2].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(11), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[2].PatientPhone, ServiceId=serviceList[2].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(29),StaffId=staffList[2].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(29), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[2].PatientPhone, ServiceId=serviceList[2].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(-20),StaffId=staffList[2].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(-20), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[2].PatientPhone, ServiceId=serviceList[2].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(-40),StaffId=staffList[2].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(-40), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[2].PatientPhone, ServiceId=serviceList[2].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(-30),StaffId=staffList[2].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(-30), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[2].PatientPhone, ServiceId=serviceList[2].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(-21),StaffId=staffList[2].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(-21), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[2].PatientPhone, ServiceId=serviceList[2].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(-22),StaffId=staffList[2].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(-22), AppointmentEndTime=DateTime.Now.AddHours(-1)},


                     new Appointment{PatientPhone=patientList[3].PatientPhone, ServiceId=serviceList[3].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(-9),StaffId=staffList[3].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(-9), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[3].PatientPhone, ServiceId=serviceList[3].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(-6),StaffId=staffList[3].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(-6), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[3].PatientPhone, ServiceId=serviceList[3].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(-50),StaffId=staffList[3].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(-50), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[3].PatientPhone, ServiceId=serviceList[3].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(-56),StaffId=staffList[3].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(-56), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[3].PatientPhone, ServiceId=serviceList[3].ServiceId, AppointmentDate=DateTime.Today.AddYears(0).AddDays(-23),StaffId=staffList[3].StaffId,AppointmentStartTime=DateTime.Now.AddYears(0).AddDays(-23), AppointmentEndTime=DateTime.Now.AddHours(-1)},

                     new Appointment{PatientPhone=patientList[4].PatientPhone, ServiceId=serviceList[4].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(-20),StaffId=staffList[4].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(-20), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[4].PatientPhone, ServiceId=serviceList[4].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(-30),StaffId=staffList[4].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(-30), AppointmentEndTime=DateTime.Now.AddHours(-1.2)},
                     new Appointment{PatientPhone=patientList[4].PatientPhone, ServiceId=serviceList[4].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(-40),StaffId=staffList[4].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(-40), AppointmentEndTime=DateTime.Now.AddHours(-1.2)},
                     new Appointment{PatientPhone=patientList[4].PatientPhone, ServiceId=serviceList[4].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(-31),StaffId=staffList[4].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(-31), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[4].PatientPhone, ServiceId=serviceList[4].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(-42),StaffId=staffList[4].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(-42), AppointmentEndTime=DateTime.Now.AddHours(-1.2)},
                     new Appointment{PatientPhone=patientList[4].PatientPhone, ServiceId=serviceList[4].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(15),StaffId=staffList[4].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(15), AppointmentEndTime=DateTime.Now.AddHours(-1.2)},
                     new Appointment{PatientPhone=patientList[4].PatientPhone, ServiceId=serviceList[4].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(30),StaffId=staffList[4].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(30), AppointmentEndTime=DateTime.Now.AddHours(-1.2)},

                     new Appointment{PatientPhone=patientList[5].PatientPhone, ServiceId=serviceList[5].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(-20),StaffId=staffList[5].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(-20), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[5].PatientPhone, ServiceId=serviceList[5].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(-4),StaffId=staffList[5].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(-4), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[5].PatientPhone, ServiceId=serviceList[5].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(-70),StaffId=staffList[5].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(-70), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[5].PatientPhone, ServiceId=serviceList[5].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(-8),StaffId=staffList[5].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(-8), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[5].PatientPhone, ServiceId=serviceList[5].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(10),StaffId=staffList[5].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(10), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[5].PatientPhone, ServiceId=serviceList[5].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(20),StaffId=staffList[5].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(20), AppointmentEndTime=DateTime.Now.AddHours(-1)},


                     new Appointment{PatientPhone=patientList[6].PatientPhone, ServiceId=serviceList[6].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(11),StaffId=staffList[6].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(11), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[6].PatientPhone, ServiceId=serviceList[6].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(29),StaffId=staffList[6].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(29), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[6].PatientPhone, ServiceId=serviceList[6].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(-20),StaffId=staffList[6].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(-20), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[6].PatientPhone, ServiceId=serviceList[6].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(-40),StaffId=staffList[6].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(-40), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[6].PatientPhone, ServiceId=serviceList[6].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(-30),StaffId=staffList[6].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(-30), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[6].PatientPhone, ServiceId=serviceList[6].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(-21),StaffId=staffList[6].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(-21), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[6].PatientPhone, ServiceId=serviceList[6].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(-22),StaffId=staffList[6].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(-22), AppointmentEndTime=DateTime.Now.AddHours(-1)},


                     new Appointment{PatientPhone=patientList[7].PatientPhone, ServiceId=serviceList[7].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(-9),StaffId=staffList[7].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(-9), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[7].PatientPhone, ServiceId=serviceList[7].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(-6),StaffId=staffList[7].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(-6), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[7].PatientPhone, ServiceId=serviceList[7].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(-50),StaffId=staffList[7].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(-50), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[7].PatientPhone, ServiceId=serviceList[7].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(-56),StaffId=staffList[7].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(-56), AppointmentEndTime=DateTime.Now.AddHours(-1)},
                     new Appointment{PatientPhone=patientList[7].PatientPhone, ServiceId=serviceList[7].ServiceId, AppointmentDate=DateTime.Today.AddYears(-1).AddDays(-23),StaffId=staffList[7].StaffId,AppointmentStartTime=DateTime.Now.AddYears(-1).AddDays(-23), AppointmentEndTime=DateTime.Now.AddHours(-1)},

                };
                context.Appointments.AddRange(bookingDataList);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }

        }

        /// <summary>
        /// On form load event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstScreen_Load(object sender, EventArgs e)
        {
            SeedData();
        }

        /// <summary>
        /// On click event handler for buttonExit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// On click event handler for buttonAdminControls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdminControls_Click(object sender, EventArgs e)
        {
            AdminControls adminControls = new AdminControls();
            adminControls.ShowDialog();
        }
    }
}
