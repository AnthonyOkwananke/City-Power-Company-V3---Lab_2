using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerData;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerData.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        //constructor with zero Kwh used (Residential Customer)
        [TestMethod()]
        public void CustomerTest()
        {
            // Arrange
            Customer res; // reference variable
            int a = 1;
            string n = "kkkk";
            decimal baseCharge = 0;
            decimal expectedCharge = 6;
            decimal actualCharge;


            //Act
            res = new Customer(a, n, baseCharge, 'R');
            actualCharge = res.ChargeAmount;



            // Assert
            Assert.AreEqual(expectedCharge, actualCharge);

        }

        //constructor with positive Kwh used(Residential Customer)
        [TestMethod()]
        public void CustomerTest2()
        {
            // Arrange
            Customer res; // reference variable
            decimal baseCharge = 6;
            decimal expectedCharge = 6.05m;
            decimal actualCharge;

            // Act
            res = new Customer(baseCharge);
            actualCharge = res.ChargeAmount;


            // Assert
            Assert.AreEqual(expectedCharge, actualCharge);

        }

        //constructor with positive Kwh used less than 1000Kwh(Commercial Customer)
        [TestMethod()]
        public void CustomerTest3()
        {
            // Arrange
            Customer res; // reference variable
            decimal baseCharge = 60.00m;
            decimal expectedCharge = 60.00m;
            decimal actualCharge;

            // Act
            res = new Customer(baseCharge);
            actualCharge = res.ChargeAmount;


            // Assert
            Assert.AreEqual(expectedCharge, actualCharge);

        }

        //constructor with positive Kwh used more than 1000Kwh(Commercial Customer)
        [TestMethod()]
        public void CustomerTest4()
        {
            // Arrange
            Customer res; // reference variable
            int Kwh = 1;
            decimal baseCharge = 60.00m;
            decimal expectedCharge = 60.045m;
            decimal actualCharge;

            // Act
            res = new Customer(baseCharge);
            actualCharge = res.ChargeAmount;


            // Assert
            Assert.AreEqual(expectedCharge, actualCharge);

        }

        //constructor with zero Kwh used (Residential Customer)

        [TestMethod()]
        public void CalculateChargeTest()
        {
            //Arrange
            int a = 1;
            string n = "kkkk";
            decimal usage = 0;
            Customer res = new Customer(a,n,usage, 'R'); // reference variable
            
            decimal expectedCharge = 6;
            decimal actualCharge;


            //Act
            res.CalculateCharge('R', usage);
            actualCharge = res.ChargeAmount;



            // Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }

        //constructor with positive Kwh used (Residential Customer)

        [TestMethod()]
        public void CalculateChargeTest2()
        {
            //Arrange
            int a = 1;
            string n = "kkkk";
            decimal usage = 1;
            decimal R_RATE = 0.052m;
            Customer res = new Customer(a, n, usage, 'R'); // reference variable

            decimal expectedCharge = 6;
            decimal actualCharge;


            //Act
            res.CalculateCharge('R', usage);
            actualCharge = res.ChargeAmount;



            // Assert
            Assert.AreEqual(expectedCharge, actualCharge);
        }
    }
}



