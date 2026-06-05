using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
        // good test data
        // create some test data to pass the method
        static string UserID = "123";
        static string OrderDate = DateTime.Now.ToShortDateString();
        static string OrderStatus = "Pending";
        static string DeliveryAddress = "123 Main Street";
        static string TotalAmount = "55.50";
        static string DeliveryStatus = "Processing";

        [TestMethod]
        public void InstanceOK()
        {
            //
            clsOrders AnOrders = new clsOrders();
            Assert.IsNotNull(AnOrders);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            // create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            // Boolean variable to store the result of the validation
            Boolean Found = false;
            // create some test data to use with the method
            Int32 OrderID = 1;
            // invoke the method
            Found = AnOrders.Find(OrderID);
            // test to see that the result is true
            Assert.IsTrue(Found);
        }

        //------ Order ID ------
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrders AnOrders = new clsOrders();
            Int32 TestData = 1;
            AnOrders.OrderID = TestData;
            Assert.AreEqual(AnOrders.OrderID, TestData);
        }

        //------ User ID ------
        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsOrders AnOrders = new clsOrders();
            Int32 TestData = 123;
            AnOrders.UserID = TestData;
            Assert.AreEqual(AnOrders.UserID, TestData);
        }

        //------ OrderStatus ------
        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            clsOrders AnOrders = new clsOrders();
            string TestData = "Pending";
            AnOrders.OrderStatus = TestData;
            Assert.AreEqual(AnOrders.OrderStatus, TestData);
        }

        //------ DeliveryAddress ------
        [TestMethod]
        public void DeliveryAddressPropertyOK()
        {
            clsOrders AnOrders = new clsOrders();
            string TestData = "123 Main Street";
            AnOrders.DeliveryAddress = TestData;
            Assert.AreEqual(AnOrders.DeliveryAddress, TestData);
        }

        // Find methods 

        [TestMethod]
        public void FindOrderIDOK()
        {
            clsOrders AnOrders = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrders.Find(OrderID);
            if (AnOrders.OrderID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindUserIDOK()
        {
            clsOrders AnOrders = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrders.Find(OrderID);
            if (AnOrders.UserID != 123)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindOrderDateOK()
        {
            clsOrders AnOrders = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrders.Find(OrderID);
            if (Convert.ToDateTime(AnOrders.OrderDate) != Convert.ToDateTime("18/05/2026"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindOrderStatusOK()
        {
            clsOrders AnOrders = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrders.Find(OrderID);
            if (AnOrders.OrderStatus != "Pending")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindDeliveryAddressOK()
        {
            clsOrders AnOrders = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrders.Find(OrderID);
            if (AnOrders.DeliveryAddress != "123 Main Street")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindTotalAmountOK()
        {
            clsOrders AnOrders = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrders.Find(OrderID);
            if (AnOrders.TotalAmount != 55.50m)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindIsPaidOK()
        {
            clsOrders AnOrders = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrders.Find(OrderID);
            if (AnOrders.IsPaid != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FindDeliveryStatusOK()
        {
            clsOrders AnOrders = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrders.Find(OrderID);
            if (Convert.ToString(AnOrders.DeliveryStatus) != "Processing")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        
        // NEW VALIDATION TESTS FOR MIDDLE LAYER
       

        [TestMethod]
        public void ValidMethodOK()
        {
            // create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            // string variable to store any error message
            String Error = "";
            Error = AnOrders.Valid(UserID, OrderDate, OrderStatus, DeliveryAddress, TotalAmount, DeliveryStatus);
            Assert.AreEqual("", Error);
        }

        // ------ DeliveryAddress Validation Tests ------

        [TestMethod]
        public void DeliveryAddressMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            // string variable to store any error message
            String Error = "";
            // create some test data to pass to the method
            string DeliveryAddress = ""; // this should trigger an error
            // invoke the method
            Error = AnOrders.Valid(UserID, OrderDate, OrderStatus, DeliveryAddress, TotalAmount, DeliveryStatus);
            // test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void DeliveryAddressMin()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string DeliveryAddress = "a"; 
            Error = AnOrders.Valid(UserID, OrderDate, OrderStatus, DeliveryAddress, TotalAmount, DeliveryStatus);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void DeliveryAddressMax()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(50, 'a'); // boundary check
            Error = AnOrders.Valid(UserID, OrderDate, OrderStatus, DeliveryAddress, TotalAmount, DeliveryStatus);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void DeliveryAddressMaxPlusOne()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(51, 'a'); // this should fail
            Error = AnOrders.Valid(UserID, OrderDate, OrderStatus, DeliveryAddress, TotalAmount, DeliveryStatus);
            Assert.AreNotEqual("", Error);
        }

        // ------ OrderDate Validation Tests ------

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrders AnOrders = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = TestDate.ToString();
            Error = AnOrders.Valid(UserID, OrderDate, OrderStatus, DeliveryAddress, TotalAmount, DeliveryStatus);
            Assert.AreNotEqual("", Error);
        }
    }
}