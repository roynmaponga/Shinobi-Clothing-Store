using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using ClassLibrary;



namespace TestingSales

{

    [TestClass]

    public class tstSales

    {

        // good test data

        string SaleDate = DateTime.Now.Date.ToString();

        string TotalAmount = "21.00";

        string PaymentMethod = "Card";

        string SaleStatus = "Completed";



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



        /****************** VALID METHOD TEST ******************/



        [TestMethod]

        public void ValidMethodOK()

        {

            clsSales ASale = new clsSales();

            String Error = "";



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreEqual("", Error);

        }



        /****************** SALE DATE TESTS ******************/



        [TestMethod]

        public void SaleDateExtremeMin()

        {

            clsSales ASale = new clsSales();

            String Error = "";

            DateTime TestDate;



            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-100);



            string SaleDate = TestDate.ToString();



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreNotEqual("", Error);

        }



        [TestMethod]

        public void SaleDateMinLessOne()

        {

            clsSales ASale = new clsSales();

            String Error = "";

            DateTime TestDate;



            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(-1);



            string SaleDate = TestDate.ToString();



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreNotEqual("", Error);

        }



        [TestMethod]

        public void SaleDateMin()

        {

            clsSales ASale = new clsSales();

            String Error = "";

            DateTime TestDate;



            TestDate = DateTime.Now.Date;



            string SaleDate = TestDate.ToString();



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreEqual("", Error);

        }



        [TestMethod]

        public void SaleDateMinPlusOne()

        {

            clsSales ASale = new clsSales();

            String Error = "";

            DateTime TestDate;



            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(1);



            string SaleDate = TestDate.ToString();



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreNotEqual("", Error);

        }



        [TestMethod]

        public void SaleDateExtremeMax()

        {

            clsSales ASale = new clsSales();

            String Error = "";

            DateTime TestDate;



            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(100);



            string SaleDate = TestDate.ToString();



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreNotEqual("", Error);

        }



        [TestMethod]

        public void SaleDateInvalidData()

        {

            clsSales ASale = new clsSales();

            String Error = "";



            string SaleDate = "this is not a date";



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreNotEqual("", Error);

        }



        /****************** TOTAL AMOUNT TESTS ******************/



        [TestMethod]

        public void TotalAmountMinLessOne()

        {

            clsSales ASale = new clsSales();

            String Error = "";



            string TotalAmount = "0";



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreNotEqual("", Error);

        }



        [TestMethod]

        public void TotalAmountMin()

        {

            clsSales ASale = new clsSales();

            String Error = "";



            string TotalAmount = "0.01";



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreEqual("", Error);

        }



        [TestMethod]

        public void TotalAmountMid()

        {

            clsSales ASale = new clsSales();

            String Error = "";



            string TotalAmount = "50.00";



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreEqual("", Error);

        }



        [TestMethod]

        public void TotalAmountInvalidData()

        {

            clsSales ASale = new clsSales();

            String Error = "";



            string TotalAmount = "not money";



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreEqual("", Error);

        }



        /****************** PAYMENT METHOD TESTS ******************/



        [TestMethod]

        public void PaymentMethodMinLessOne()

        {

            clsSales ASale = new clsSales();

            String Error = "";



            string PaymentMethod = "";



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreEqual("", Error);

        }



        [TestMethod]

        public void PaymentMethodMin()

        {

            clsSales ASale = new clsSales();

            String Error = "";



            string PaymentMethod = "a";



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreEqual("", Error);

        }



        [TestMethod]

        public void PaymentMethodMax()

        {

            clsSales ASale = new clsSales();

            String Error = "";



            string PaymentMethod = "";

            PaymentMethod = PaymentMethod.PadRight(50, 'a');



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreEqual("", Error);

        }



        [TestMethod]

        public void PaymentMethodMaxPlusOne()

        {

            clsSales ASale = new clsSales();

            String Error = "";



            string PaymentMethod = "";

            PaymentMethod = PaymentMethod.PadRight(51, 'a');



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreNotEqual("", Error);

        }



        [TestMethod]

        public void PaymentMethodMid()

        {

            clsSales ASale = new clsSales();

            String Error = "";



            string PaymentMethod = "";

            PaymentMethod = PaymentMethod.PadRight(25, 'a');



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreEqual("", Error);

        }



        /****************** SALE STATUS TESTS ******************/



        [TestMethod]

        public void SaleStatusMinLessOne()

        {

            clsSales ASale = new clsSales();

            String Error = "";



            string SaleStatus = "";



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreNotEqual("", Error);

        }



        [TestMethod]

        public void SaleStatusMin()

        {

            clsSales ASale = new clsSales();

            String Error = "";



            string SaleStatus = "a";



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreEqual("", Error);

        }



        [TestMethod]

        public void SaleStatusMax()

        {

            clsSales ASale = new clsSales();

            String Error = "";



            string SaleStatus = "";

            SaleStatus = SaleStatus.PadRight(50, 'a');



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreEqual("", Error);

        }



        [TestMethod]

        public void SaleStatusMaxPlusOne()

        {

            clsSales ASale = new clsSales();

            String Error = "";



            string SaleStatus = "";

            SaleStatus = SaleStatus.PadRight(51, 'a');



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreNotEqual("", Error);

        }



        [TestMethod]

        public void SaleStatusMid()

        {

            clsSales ASale = new clsSales();

            String Error = "";



            string SaleStatus = "";

            SaleStatus = SaleStatus.PadRight(25, 'a');



            Error = ASale.Valid(SaleDate, TotalAmount, PaymentMethod, SaleStatus);



            Assert.AreEqual("", Error);

        }

    }

}