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
    public partial class NewService : Form
    {
        Dental360Entities context;
        public NewService()
        {
            InitializeComponent();
            context = new Dental360Entities();
        }

        /// <summary>
        /// On click event handler for buttonAddService
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddService_Click(object sender, EventArgs e)
        {
            try
            {
                //Validating user input
                if (Validation())
                {
                    MessageBox.Show("Sorry, Vaildation Failed!");
                    return;
                }
                else
                {
                    string serviceName = textBoxServiceName.Text.Trim();
                    decimal servicePrice = System.Convert.ToDecimal(textBoxPrice.Text.Trim());
                    int serviceTimeTaken = Int32.Parse(textBoxTimeTaken.Text.Trim());

                    //Adding new service
                    List<Service> serviceList = new List<Service>()
            {
                         new Service { ServiceName=serviceName,ServicePrice=servicePrice,ServiceTimeTaken=serviceTimeTaken},
            };

                    context.Services.AddRange(serviceList);
                    context.SaveChanges();
                     
                    MessageBox.Show("New Service is added");
                    context.Services.Load();
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
        /// <returns> false </returns>
        public Boolean Validation()
        {
            string serviceName = textBoxServiceName.Text.Trim();
            decimal price = System.Convert.ToDecimal(textBoxPrice.Text.Trim());
            int timeTaken = Int32.Parse(textBoxTimeTaken.Text.Trim());

            //Validation if the service name is empty
            if (string.IsNullOrEmpty(serviceName))
            {
                MessageBox.Show("Service Name cant be null");
                return true;
            }

            //Validation if the service time is negative
            if(timeTaken < 0)
            {
                MessageBox.Show("Service Time cannot be negative");
            }

            return false;
        }
    }

}
