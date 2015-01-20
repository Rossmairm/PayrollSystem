namespace PayrollProgram
{
    partial class frmMain
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
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.btnCalculatePay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(30, 27);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(94, 13);
            this.lblHourlyRate.TabIndex = 0;
            this.lblHourlyRate.Text = "Enter Hourly Rate ";
            this.lblHourlyRate.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(172, 27);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(104, 13);
            this.lblHoursWorked.TabIndex = 1;
            this.lblHoursWorked.Text = "Enter Hours Worked";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(114, 112);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(10, 13);
            this.lblDisplay.TabIndex = 2;
            this.lblDisplay.Text = " ";
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(175, 60);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(95, 20);
            this.txtHoursWorked.TabIndex = 2;
            this.txtHoursWorked.TextChanged += new System.EventHandler(this.txtHoursWorked_TextChanged);
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(33, 60);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(95, 20);
            this.txtHourlyRate.TabIndex = 1;
            this.txtHourlyRate.TextChanged += new System.EventHandler(this.txtHourlyRate_TextChanged);
            // 
            // btnCalculatePay
            // 
            this.btnCalculatePay.Location = new System.Drawing.Point(33, 245);
            this.btnCalculatePay.Name = "btnCalculatePay";
            this.btnCalculatePay.Size = new System.Drawing.Size(62, 46);
            this.btnCalculatePay.TabIndex = 3;
            this.btnCalculatePay.Text = "Calculate Pay";
            this.btnCalculatePay.UseVisualStyleBackColor = true;
            this.btnCalculatePay.Click += new System.EventHandler(this.btnCalculatePay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(119, 245);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 46);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(208, 245);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 46);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCalculatePay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(310, 334);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculatePay);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblHourlyRate);
            this.Name = "frmMain";
            this.Text = "Mark Rossmair– Employee Pay Calculator ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Button btnCalculatePay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

