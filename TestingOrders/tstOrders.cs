using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
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
    }
}