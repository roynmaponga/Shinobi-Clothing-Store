using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestingSales
{
    [TestClass]
    public class tstSales
    {
        /****************** INSTANCE OF THE CLASS TEST ******************/

        [TestMethod]
        public void InstanceOK()
        {
            clsSales ASale = new clsSales();
            Assert.IsNotNull(ASale);
        }

        /****************** PROPERTY OK TESTS ******************/

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
            int TestData = 1;
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
            decimal TestData = 21.00m;
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

        /****************** FIND METHOD TEST ******************/

        [TestMethod]
        public void FindMethodOK()
        {
            clsSales ASale = new clsSales();
            Boolean Found = false;
            Int32 SaleID = 1;

            Found = ASale.Find(SaleID);

            Assert.IsTrue(Found);
        }

        /****************** PROPERTY DATA TESTS ******************/

        [TestMethod]
        public void TestSaleIDFound()
        {
            clsSales ASale = new clsSales();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SaleID = 1;

            Found = ASale.Find(SaleID);

            if (ASale.SaleID != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            clsSales ASale = new clsSales();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SaleID = 1;

            Found = ASale.Find(SaleID);

            if (ASale.OrderID != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSaleDateFound()
        {
            clsSales ASale = new clsSales();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SaleID = 1;

            Found = ASale.Find(SaleID);

            if (ASale.SaleDate != Convert.ToDateTime("10/05/2026"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalAmountFound()
        {
            clsSales ASale = new clsSales();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SaleID = 1;

            Found = ASale.Find(SaleID);

            if (ASale.TotalAmount != 21.00m)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentMethodFound()
        {
            clsSales ASale = new clsSales();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SaleID = 1;

            Found = ASale.Find(SaleID);

            if (ASale.PaymentMethod != "Card")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSaleStatusFound()
        {
            clsSales ASale = new clsSales();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SaleID = 1;

            Found = ASale.Find(SaleID);

            if (ASale.SaleStatus != "Completed")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsRefundedFound()
        {
            clsSales ASale = new clsSales();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SaleID = 1;

            Found = ASale.Find(SaleID);

            if (ASale.IsRefunded != false)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}