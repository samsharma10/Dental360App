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
    public partial class NewStaff : Form
    {
        Dental360Entities context;
        public NewStaff()
        {
            InitializeComponent();
            context = new Dental360Entities(); 

        }

        /// <summary>
        /// On click event handler for buttonAddStaff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                //validating user input
                if (Validation())
                {
                    MessageBox.Show("Sorry, Vaildation Failed!");
                    return;
                }
                else
                {
                    string staffFirstName = textBoxFirstName.Text.Trim();
                    string staffLastName = textBoxLastName.Text.Trim();
                    string staffEmail = textBoxEmail.Text.Trim();
                    string staffPhone = textBoxPhone.Text.Trim();

                    //Adding new staff
                    List<Staff> staffList = new List<Staff>()
            {
                         new Staff { StaffPhoneNumber=staffPhone,StaffFirstName=staffFirstName,StaffLastName=staffLastName,StaffEmail=staffEmail},
            };

                    context.Staffs.AddRange(staffList);
                    context.SaveChanges();

                    context.Staffs.Load();
                    MessageBox.Show("New Staff is added");
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
        /// <returns>false</returns>
        public Boolean Validation()
        {
            string staffFirstName = textBoxFirstName.Text.Trim();
            string staffLastName = textBoxLastName.Text.Trim();
            string staffEmail = textBoxEmail.Text.Trim();
            string staffPhone = textBoxPhone.Text.Trim();



            long phoneNum;

            if (long.TryParse(staffPhone, out phoneNum) == false || string.IsNullOrEmpty(staffPhone) || staffPhone.Length != 10)
            {
                MessageBox.Show("Phone Number Not correct");
                return true;
            }

            if (string.IsNullOrEmpty(staffFirstName))
            {
                MessageBox.Show("Staff First Name cant be null");
                return true;
            }
            if (string.IsNullOrEmpty(staffLastName))
            {
                MessageBox.Show("Staff Last Name cant be null");
                return true;
            }

            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (string.IsNullOrEmpty(staffEmail) || Regex.IsMatch(staffEmail, pattern) == false)
            {
                MessageBox.Show("Not a valid Email address");
                return true;
            }

            return false;
        }

    }
}
