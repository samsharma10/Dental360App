namespace ProjectTeam13Dental360
{
    partial class NewService
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
            this.labelAddService = new System.Windows.Forms.Label();
            this.labelServiceName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTimeTaken = new System.Windows.Forms.Label();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxTimeTaken = new System.Windows.Forms.TextBox();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddService
            // 
            this.labelAddService.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelAddService.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddService.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAddService.Location = new System.Drawing.Point(0, 0);
            this.labelAddService.Name = "labelAddService";
            this.labelAddService.Size = new System.Drawing.Size(387, 38);
            this.labelAddService.TabIndex = 0;
            this.labelAddService.Text = "Add Service";
            this.labelAddService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelServiceName
            // 
            this.labelServiceName.AutoSize = true;
            this.labelServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServiceName.Location = new System.Drawing.Point(13, 55);
            this.labelServiceName.Name = "labelServiceName";
            this.labelServiceName.Size = new System.Drawing.Size(107, 20);
            this.labelServiceName.TabIndex = 1;
            this.labelServiceName.Text = "Service Name";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(13, 84);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 20);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Price";
            // 
            // labelTimeTaken
            // 
            this.labelTimeTaken.AutoSize = true;
            this.labelTimeTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeTaken.Location = new System.Drawing.Point(12, 113);
            this.labelTimeTaken.Name = "labelTimeTaken";
            this.labelTimeTaken.Size = new System.Drawing.Size(177, 20);
            this.labelTimeTaken.TabIndex = 3;
            this.labelTimeTaken.Text = "Time Taken (in minutes)";
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Location = new System.Drawing.Point(204, 54);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(159, 20);
            this.textBoxServiceName.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(204, 83);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 5;
            // 
            // textBoxTimeTaken
            // 
            this.textBoxTimeTaken.Location = new System.Drawing.Point(204, 112);
            this.textBoxTimeTaken.Name = "textBoxTimeTaken";
            this.textBoxTimeTaken.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimeTaken.TabIndex = 6;
            // 
            // buttonAddService
            // 
            this.buttonAddService.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAddService.FlatAppearance.BorderSize = 0;
            this.buttonAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddService.Location = new System.Drawing.Point(128, 159);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(126, 37);
            this.buttonAddService.TabIndex = 7;
            this.buttonAddService.Text = "Add Service";
            this.buttonAddService.UseVisualStyleBackColor = false;
            this.buttonAddService.Click += new System.EventHandler(this.ButtonAddService_Click);
            // 
            // NewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(387, 208);
            this.Controls.Add(this.buttonAddService);
            this.Controls.Add(this.textBoxTimeTaken);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxServiceName);
            this.Controls.Add(this.labelTimeTaken);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelServiceName);
            this.Controls.Add(this.labelAddService);
            this.Name = "NewService";
            this.Text = "Add Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddService;
        private System.Windows.Forms.Label labelServiceName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTimeTaken;
        private System.Windows.Forms.TextBox textBoxServiceName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxTimeTaken;
        private System.Windows.Forms.Button buttonAddService;
    }
}