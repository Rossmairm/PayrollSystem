using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollProgram
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHourlyRate.Clear();
            txtHoursWorked.Clear();
            lblDisplay.Text = "";

            


        }

        private void txtHourlyRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoursWorked_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculatePay_Click(object sender, EventArgs e)
        {
            double rate;
            double hours;
            double beforePay;
            double stateTax;
            double fedTax;
            double FICA;
            double finalPay;

            rate = double.Parse(txtHourlyRate.Text);
            hours = double.Parse(txtHoursWorked.Text);
             
            beforePay = rate * hours;
            stateTax = beforePay * .035;
            fedTax = beforePay * .15;
            FICA = (beforePay * .062) + (beforePay * .029);
            finalPay = beforePay - (stateTax + fedTax + FICA);


            lblDisplay.Text = "Before deuctions = $" + beforePay + "\n State Tax = $" + stateTax + "\n Fed Tax = $" + fedTax + "\n FICA tax = $" + FICA + "\n Final Pay = $ " + finalPay;
        
        }
        
        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
