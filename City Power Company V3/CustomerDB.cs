using CustomerData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace City_Power_Company_V3
{
    public static class CustomerDB
    {
        const string path = "customer.txt"; // located in bin/Debug folder

        public static List<Customer> ReadCustomer()
        {
            List<Customer> custList = new List<Customer>(); // create empty list
            Customer c; // for reading customer
            string line; // next line from the file
            string[] fields; // line broken into fields
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)// while there is still unread data
                    {
                        line = sr.ReadLine();
                        fields = line.Split(',');// split where the commas are
                        c = new Customer(); // create customer and fill with data
                        c.AccountName = fields[0];
                        c.AccountNo = Convert.ToInt32(fields[1]);
                        c.ChargeAmount = Convert.ToDecimal(fields[2]);
                        
                        custList.Add(c); // add it to the list
                    }
                } // closes sr and recycles
            } // closes fs and recycles
            return custList;
        }

        public static void SaveCustomer(List<Customer> customerList)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (Customer c in customerList)
                    {
                        sw.WriteLine(c.ToCSV());
                    }
                } // closes the sw and recyles
            }// closes the fs and recycles
        }
    }
}

