using Dental360TestDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam13Dental360
{
    public partial class NewPatient : Form
    {
        Dental360Entities context;
        public NewPatient()
        {
            InitializeComponent();
            context = new Dental360Entities();
        }

        /// <summary>
        /// On click event handler for buttonAddPatient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddPatient_Click(object sender, EventArgs e)
        {
            try
            {
                //Validating the user input
                if (Validation())
                {
                    MessageBox.Show("Sorry, Vaildation Failed!");
                    return;
                }
                else
                {
                    string patientFirstName = textBoxFirstName.Text.Trim();
                    string patientLastName = textBoxLastName.Text.Trim();
                    string patientEmail = textBoxEmail.Text.Trim();
                    string patientPhone = textBoxPhone.Text.Trim();

                    //Adding new patient
                    List<Patient> patientList = new List<Patient>()
            {
                         new Patient { PatientPhone=patientPhone,PatientFirstName=patientFirstName,PatientLastName=patientLastName,PatientEmail=patientEmail},
            };

                    context.Patients.AddRange(patientList);
                    context.SaveChanges();

                    MessageBox.Show("New Patient is added");
                    context.Patients.Load();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Function for validation of user input
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
                MessageBox.Show("Patient First Name cant be null");
                return true;
            }
            if (string.IsNullOrEmpty(patientLastName))
            {
                MessageBox.Show("Patient Last Name cant be null");
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
        
    }
}
