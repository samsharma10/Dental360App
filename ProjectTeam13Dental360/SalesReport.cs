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
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectTeam13Dental360
{

    public partial class SalesReport : Form
    {
        Dental360Entities context;
        DateTime date = DateTime.Today;
        public SalesReport()
        {
            InitializeComponent();
            context = new Dental360Entities();
        }

        private void SaleReport(int year)
        {
            try
            {
                context.Appointments.Load();
                //Making a Series chart named Sales
                //Fetchng Value for X and Y axis which is Month and Sales(in that month) respectively
                chartSalesReport.Series["Sales"].XValueMember = "Month";
                chartSalesReport.Series["Sales"].YValueMembers = "Sales";
                

                //query to select Sales and month
                var querySalesReport = context.Appointments
                    .Where(i => i.AppointmentDate.Year == year)
                     .GroupBy(i => i.AppointmentDate.Month)
                     .Select(i => new
                     {
                         Sales = i.Sum(f => f.Service.ServicePrice),
                         Month = i.Key
                     }).ToList();
                //Feeding the query result to the chart
                chartSalesReport.DataSource = querySalesReport;
                chartSalesReport.DataBind();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// On click event handler for buttonCurrentYear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCurrentYear_Click(object sender, EventArgs e)
        {
            SaleReport(date.Year);
        }

        /// <summary> 
        /// On click event handler for buttonPreviousYear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPreviousYear_Click(object sender, EventArgs e)
        {
            SaleReport(date.Year - 1);
        }
    } }
