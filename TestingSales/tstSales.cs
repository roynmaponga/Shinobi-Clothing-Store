using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestingSales
{
    [TestClass]
    public class tstSales
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSales ASale = new clsSales();
            Assert.IsNotNull(ASale);
        }
        [TestMethod]
        public void SaleIDPropertyOK()
        {
            clsSales ASale = new clsSales();
            int TestData = 1;
            ASale.SaleID = TestData;
            Assert.AreEqual(ASale.SaleID, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsSales ASale = new clsSales();
            int TestData = 101;
            ASale.OrderID = TestData;
            Assert.AreEqual(ASale.OrderID, TestData);
        }

        [TestMethod]
        public void SaleDatePropertyOK()
        {
            clsSales ASale = new clsSales();
            DateTime TestData = DateTime.Now.Date;
            ASale.SaleDate = TestData;
            Assert.AreEqual(ASale.SaleDate, TestData);
        }

        [TestMethod]
        public void TotalAmountPropertyOK()
        {
            clsSales ASale = new clsSales();
            decimal TestData = 59.99m;
            ASale.TotalAmount = TestData;
            Assert.AreEqual(ASale.TotalAmount, TestData);
        }

        [TestMethod]
        public void PaymentMethodPropertyOK()
        {
            clsSales ASale = new clsSales();
            string TestData = "Card";
            ASale.PaymentMethod = TestData;
            Assert.AreEqual(ASale.PaymentMethod, TestData);
        }

        [TestMethod]
        public void SaleStatusPropertyOK()
        {
            clsSales ASale = new clsSales();
            string TestData = "Completed";
            ASale.SaleStatus = TestData;
            Assert.AreEqual(ASale.SaleStatus, TestData);
        }

        [TestMethod]
        public void IsRefundedPropertyOK()
        {
            clsSales ASale = new clsSales();
            bool TestData = false;
            ASale.IsRefunded = TestData;
            Assert.AreEqual(ASale.IsRefunded, TestData);
        }
    }
}