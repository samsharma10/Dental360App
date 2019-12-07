namespace ProjectTeam13Dental360
{
    partial class SalesReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelSalesReport = new System.Windows.Forms.Label();
            this.chartSalesReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonPreviousYear = new System.Windows.Forms.Button();
            this.buttonCurrentYear = new System.Windows.Forms.Button();
            this.labelMonths = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSalesReport
            // 
            this.labelSalesReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelSalesReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalesReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSalesReport.Location = new System.Drawing.Point(0, 0);
            this.labelSalesReport.Name = "labelSalesReport";
            this.labelSalesReport.Size = new System.Drawing.Size(649, 41);
            this.labelSalesReport.TabIndex = 0;
            this.labelSalesReport.Text = "Sales Report";
            this.labelSalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chartSalesReport
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSalesReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSalesReport.Legends.Add(legend1);
            this.chartSalesReport.Location = new System.Drawing.Point(27, 62);
            this.chartSalesReport.Name = "chartSalesReport";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sales";
            series1.XValueMember = "Month";
            series1.YValueMembers = "Price in $";
            this.chartSalesReport.Series.Add(series1);
            this.chartSalesReport.Size = new System.Drawing.Size(433, 324);
            this.chartSalesReport.TabIndex = 1;
            this.chartSalesReport.Text = "chart1";
            // 
            // buttonPreviousYear
            // 
            this.buttonPreviousYear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonPreviousYear.FlatAppearance.BorderSize = 0;
            this.buttonPreviousYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreviousYear.Location = new System.Drawing.Point(510, 277);
            this.buttonPreviousYear.Name = "buttonPreviousYear";
            this.buttonPreviousYear.Size = new System.Drawing.Size(120, 43);
            this.buttonPreviousYear.TabIndex = 2;
            this.buttonPreviousYear.Text = "Previous Year";
            this.buttonPreviousYear.UseVisualStyleBackColor = false;
            this.buttonPreviousYear.Click += new System.EventHandler(this.ButtonPreviousYear_Click);
            // 
            // buttonCurrentYear
            // 
            this.buttonCurrentYear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCurrentYear.FlatAppearance.BorderSize = 0;
            this.buttonCurrentYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCurrentYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCurrentYear.Location = new System.Drawing.Point(510, 343);
            this.buttonCurrentYear.Name = "buttonCurrentYear";
            this.buttonCurrentYear.Size = new System.Drawing.Size(120, 43);
            this.buttonCurrentYear.TabIndex = 3;
            this.buttonCurrentYear.Text = "Current Year";
            this.buttonCurrentYear.UseVisualStyleBackColor = false;
            this.buttonCurrentYear.Click += new System.EventHandler(this.ButtonCurrentYear_Click);
            // 
            // labelMonths
            // 
            this.labelMonths.AutoSize = true;
            this.labelMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonths.Location = new System.Drawing.Point(148, 370);
            this.labelMonths.Name = "labelMonths";
            this.labelMonths.Size = new System.Drawing.Size(93, 16);
            this.labelMonths.TabIndex = 4;
            this.labelMonths.Text = "Months -------->";
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(649, 405);
            this.Controls.Add(this.labelMonths);
            this.Controls.Add(this.buttonCurrentYear);
            this.Controls.Add(this.buttonPreviousYear);
            this.Controls.Add(this.chartSalesReport);
            this.Controls.Add(this.labelSalesReport);
            this.Name = "SalesReport";
            this.Text = "Sales Report";
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSalesReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalesReport;
        private System.Windows.Forms.Button buttonPreviousYear;
        private System.Windows.Forms.Button buttonCurrentYear;
        private System.Windows.Forms.Label labelMonths;
    }
}