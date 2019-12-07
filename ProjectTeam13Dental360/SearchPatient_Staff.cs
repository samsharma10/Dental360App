using Dental360TestDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam13Dental360
{
    public partial class SearchPatient_Staff : Form
    {
        Dental360Entities context;
        public SearchPatient_Staff()
        {
            InitializeComponent();
            context = new Dental360Entities();
            InitializeFormControls();
            //buttonPatientSearch.Click += ButtonPatientSearch_Click;
            //buttonStaffSearch.Click += ButtonStaffSearch_Click;
            textBoxPatientInput.TextChanged += TextBoxPatientInput_TextChanged;
            textBoxStaffLastName.TextChanged += TextBoxStaffLastName_TextChanged;

        }

        /// <summary>
        /// Function for to search patient
        /// </summary>
        private void SearchPatient()
        {
            if (radioButtonPhoneNumber.Checked)
            {
                try
                {
                    

                    string phoneNumber = textBoxPatientInput.Text;

                    //query to get patient from phone number or if user simply clicks the search button without enetering any value in phone number textbox
                    var searchPatientQuery =
                        from searchPatientList in context.Patients
                        where searchPatientList.PatientPhone.StartsWith(phoneNumber) || phoneNumber == null
                        orderby searchPatientList.PatientPhone
                        select new PatientData
                        {
                            FirstName = searchPatientList.PatientFirstName,
                            LastName = searchPatientList.PatientLastName,
                            Phone = searchPatientList.PatientPhone,
                            Email = searchPatientList.PatientEmail,
                        };

                    dataGridViewSearch.DataSource = searchPatientQuery.ToList();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.InnerException.Message);

                }
            }
            else if (radioButtonLastName.Checked)
            {
                try
                {
                    
                    string searchPatientLastName = textBoxPatientInput.Text;


                    //query to get patient from last Name or if user simply clicks the search button without enetering any value in last name textbox
                    var searchPatientQuery =
                        from patientList in context.Patients
                        where patientList.PatientLastName.StartsWith(searchPatientLastName) || searchPatientLastName == null
                        orderby patientList.PatientPhone
                        select new PatientData
                        {
                            Phone = patientList.PatientPhone,
                            FirstName = patientList.PatientFirstName,
                            LastName = patientList.PatientLastName,
                            Email = patientList.PatientEmail,
                        };

                    
                    dataGridViewSearch.DataSource = searchPatientQuery.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        /// <summary>
        /// Function to search staff
        /// </summary>
        private void SearchStaff()
        {
            try
            {
                string searchLastName = textBoxStaffLastName.Text;


                //query to get staff member from last Name or if user simply clicks the search button without enetering any value in last name textbox
                var searchStaffQuery =
                    from staffList in context.Staffs
                    where staffList.StaffLastName.StartsWith(searchLastName) || searchLastName == null
                    orderby staffList.StaffId
                    select new StaffData
                    {
                        StaffId = staffList.StaffId,
                        FirstName = staffList.StaffFirstName,
                        LastName = staffList.StaffLastName,
                        PhoneNumber = staffList.StaffPhoneNumber,
                        Email = staffList.StaffEmail,
                    };

                
                dataGridViewSearch.DataSource = searchStaffQuery.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        /// <summary>
        /// Class for gettes and setters for StaffData
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
        /// On click event handler for buttonPatientSarch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPatientSearch_Click(object sender, EventArgs e)
        {
            SearchPatient();
        }

        /// <summary>
        /// On click event handler for buttonStaffSearch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStaffSearch_Click(object sender, EventArgs e)
        {
            SearchStaff();
        }

        /// <summary>
        /// Text changed event handler for textBoxPatientInput
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxPatientInput_TextChanged(object sender, EventArgs e)
        {
            SearchPatient();
        }

        /// <summary>
        /// Text CHanged event handler for textBoxStaffLastName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxStaffLastName_TextChanged(object sender, EventArgs e)
        {
            SearchStaff();
        }

        /// <summary>
        /// Function to initialize form controls
        /// </summary>
        public void InitializeFormControls() {
            dataGridViewSearch.BorderStyle = BorderStyle.None;
            dataGridViewSearch.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewSearch.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewSearch.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridViewSearch.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewSearch.BackgroundColor = Color.White;
            dataGridViewSearch.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            dataGridViewSearch.EnableHeadersVisualStyles = false;
            dataGridViewSearch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewSearch.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridViewSearch.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        }
}
