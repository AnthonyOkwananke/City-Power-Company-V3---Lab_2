using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{

    public class Customer
    {
        const decimal R_BASE_CH = 6.00m; //residential user base charge
        const decimal R_RATE = 0.052m;   //residential user rate/kwh
        const decimal C_BASE_CH = 60.00m; //commercial user base charge for first 1000 kwh
        const decimal C_RATE = 0.045m; //commercial user rate/kwh after first 1000 kwh
        const decimal IP_BASE_CH = 76.00m; //industrial user peak period base charge for first 1000 kwh
        const decimal IP_RATE = 0.065m; //industrial user peak period rate/kwh after first 1000 kwh 
        const decimal IO_BASE_CH = 40.00m; //industrial user off peak period base charge for first 1000 kwh
        const decimal IO_RATE = 0.028m; //industrial user off peak period rate/kwh after first 1000 kwh

        decimal kwh = 0; //kwh used
        decimal peakKwh = 0;
        decimal offPeakKwh = 0;
     

        // Public properties
        public int AccountNo { get; set; }
        public string AccountName { get; set; }
        public char CustomerType { get; set; }
        public static object Count { get; set; }

        public decimal ChargeAmount;
        private decimal baseCharge;

        

        public Customer(decimal chargeamount, int accountno, string accountname, char customertype) { } 

        public Customer(int accountno, string accountname, decimal chargeamount, char customertype)
        {
            AccountNo = accountno;
            AccountName = accountname;
            ChargeAmount = chargeamount;
            CustomerType = customertype;
        }

        public Customer(decimal baseCharge)
        {
            this.baseCharge = baseCharge;
        }

        public Customer()
        {

        }

        //public operations
        public decimal CalculateCharge(char CustomerType, decimal kwh)
        {
            if (CustomerType == 'R')
                ChargeAmount = R_BASE_CH + (R_RATE * kwh);
            //return ChargeAmount;

            if (CustomerType == 'C')
                if (kwh <= 1000)
                {
                    ChargeAmount = C_BASE_CH;

                }

                else
                {
                    ChargeAmount = C_BASE_CH + (C_RATE * (kwh - 1000));

                }
            //return ChargeAmount;

            if (CustomerType == 'I')
                if ((peakKwh < 1000) && (offPeakKwh < 1000))
                {
                    ChargeAmount = IP_BASE_CH + IO_BASE_CH;
                }

                else if ((peakKwh > 1000) && (offPeakKwh < 1000))
                {
                    ChargeAmount = (IP_BASE_CH + (IP_RATE * (peakKwh - 1000))) + IO_BASE_CH;
                }

                else if (peakKwh < 1000 && offPeakKwh > 1000)
                {
                    ChargeAmount = (IP_BASE_CH + IO_BASE_CH + (IO_RATE * (offPeakKwh - 1000)));
                }

                else
                {
                    ChargeAmount = (IP_BASE_CH + (IP_RATE * (peakKwh - 1000))) + (IO_BASE_CH + (IO_RATE * (offPeakKwh - 1000)));
                }
            return ChargeAmount;
        }   

        public override string ToString() // for display
        {
            return AccountName + ": " + AccountNo.ToString() + "," + CustomerType.ToString() + "," + ChargeAmount.ToString("c");
        }

        public string ToCSV()// for writing CSV file - no formatting
        {
            return AccountName + ", " + AccountNo.ToString() + "," + CustomerType.ToString() + "," + ChargeAmount.ToString();
        }

   
    }
   
   
}
