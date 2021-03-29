using CustomerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City_Power_Company_V3
// Application to calculate electricity bill based on customer/user type
// Author: Anthony Okwananke
// Date: January, 2020
{
    public  partial class ElectricityBill : Form
    {
        //form level variable

        List<Customer> customer = new List<Customer>(); // empty list

        const decimal R_BASE_CH = 6.00m; //residential user base charge
        const decimal R_RATE = 0.052m;   //residential user rate/kwh
        const decimal C_BASE_CH = 60.00m; //commercial user base charge for first 1000 kwh
        const decimal C_RATE = 0.045m; //commercial user rate/kwh after first 1000 kwh
        const decimal IP_BASE_CH = 76.00m; //industrial user peak period base charge for first 1000 kwh
        const decimal IP_RATE = 0.065m; //industrial user peak period rate/kwh after first 1000 kwh 
        const decimal IO_BASE_CH = 40.00m; //industrial user off peak period base charge for first 1000 kwh
        const decimal IO_RATE = 0.028m; //industrial user off peak period rate/kwh after first 1000 kwh

        public ElectricityBill()
        {
            InitializeComponent();
        }

        //Calculate charge based on energy consumption
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //local variables

            decimal kwh = 0; //kwh used
            decimal peakKwh = 0;
            decimal offPeakKwh = 0;
            decimal Amount; // charge amount calculated

            
            if (rdBtnResidential.Checked)
            {
                if (Validator.IsNonNegativeInt32(txtKwh, "KWH Used"))
                    kwh = Convert.ToDecimal(txtKwh.Text);
                Amount = R_BASE_CH + (R_RATE * kwh);
            }

            else //if (rdBtnCommercial.Checked)
            {
                if (Validator.IsNonNegativeInt32(txtKwh, "KWH Used"))
                    kwh = Convert.ToDecimal(txtKwh.Text);
                if (kwh <= 1000)
                {
                    Amount = C_BASE_CH;

                }

                else
                {
                    Amount = C_BASE_CH + (C_RATE * (kwh - 1000));

                }
            }
            if (rdBtnIndustrial.Checked)  //else
            {
                if (Validator.IsNonNegativeInt32(txtPeakKwh, "Peak KWH Used"))
                    peakKwh = Convert.ToDecimal(txtPeakKwh.Text);

                if (Validator.IsNonNegativeInt32(txtOffPeakKwh, "OffPeak KWH Used"))
                    offPeakKwh = Convert.ToDecimal(txtOffPeakKwh.Text);



                if ((peakKwh < 1000) && (offPeakKwh < 1000))
                {
                    Amount = IP_BASE_CH + IO_BASE_CH;
                }

                else if ((peakKwh > 1000) && (offPeakKwh < 1000))
                {
                    Amount = (IP_BASE_CH + (IP_RATE * (peakKwh - 1000))) + IO_BASE_CH;
                }

                else if (peakKwh < 1000 && offPeakKwh > 1000)
                {
                    Amount = (IP_BASE_CH + IO_BASE_CH + (IO_RATE * (offPeakKwh - 1000)));
                }

                else
                {
                    Amount = (IP_BASE_CH + (IP_RATE * (peakKwh - 1000))) + (IO_BASE_CH + (IO_RATE * (offPeakKwh - 1000)));
                }
            }

            if (rdBtnResidential.Checked)
            {
                lblKwh.Visible = true;
                txtKwh.Visible = true;
                lblPeakKwh.Visible = false;
                lblOffPeakKwh.Visible = false;
                txtPeakKwh.Visible = false;
                txtOffPeakKwh.Visible = false;
            }

            else if (rdBtnCommercial.Checked)
            {
                lblKwh.Visible = true;
                txtKwh.Visible = true;
                lblPeakKwh.Visible = false;
                lblOffPeakKwh.Visible = false;
                txtPeakKwh.Visible = false;
                txtOffPeakKwh.Visible = false;
            }

            else
            {
                lblKwh.Visible = false;
                txtKwh.Visible = false;
                lblPeakKwh.Visible = true;
                lblOffPeakKwh.Visible = true;
                txtPeakKwh.Visible = true;
                txtOffPeakKwh.Visible = true;
            }

            // display results
            lblAmount.Text = Amount.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKwh.Text = "";
            txtPeakKwh.Text = "";
            txtOffPeakKwh.Text = "";
            lblAmount.Text = "";
            txtKwh.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int accountno;
            string accountname;
            decimal chargeamount;
            char customertype;

            if (Validator.IsNonNegativeInt32(txtAccountNo, "Account No"))

            {
                // get data from text boxes
                accountno = Convert.ToInt32(txtAccountNo.Text);
                accountname = txtAccountName.Text;
                chargeamount = Convert.ToDecimal(lblAmount.Text);
                customertype = 'R';

                // create a customer object
                Customer c = new Customer(accountno, accountname, chargeamount, customertype);

                // add to list
                customer.Add(c);
                DisplayCustomer();
            }
        }

        private void DisplayCustomer()
        {
            lstData.Items.Clear();
            foreach (Customer c in customer)
                lstData.Items.Add(c); // implicitly calls ToString()
            lblNo.Text = customer.Count.ToString();
            lblTotalAmount.Text = CalculateCharge().ToString("c");
        }

        // save the data just before the form closes
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CustomerDB.SaveCustomer(customer);
        }

        // total charges for all customers 
        private decimal CalculateCharge()
        {
            decimal total = 0;
            foreach (Customer c in customer)
                total += c.ChargeAmount;
            return total;
        }
        // total charges for each type of customers
        //private decimal

     


    }
}
