
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
        //---Order  ID----
        [TestMethod]
        public void OrderIDProperly()
        {
            clsOrders AnOrders = new clsOrders();
            int TestData = 1;
            AnOrders.OrderID = TestData;
            Assert.AreEqual(AnOrders.OrderID, TestData);
        }
        //----- UserID-----
        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsOrders AnOrders = new clsOrders();
            int TestData = 123;
            AnOrders.UserID = TestData;
            Assert.AreEqual(AnOrders.UserID, TestData);
        }
        //--OrderDate
        [TestMethod]
        public void OrderDatePropertOK()
        {
            clsOrders AnOrders = new clsOrders();
            DateTime TestDate = DateTime.Now.Date;
            AnOrders.OrderDate = TestDate;
            Assert.AreEqual(AnOrders.OrderDate, TestDate);

        }
        // ----- OrderStatus -----
        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            clsOrders AnOrders = new clsOrders();
            string TestData = "Pending";
            AnOrders.OrderStatus = TestData;
            Assert.AreEqual(AnOrders.OrderStatus, TestData);

        }
        // ----- DeliveryAddress -----
        [TestMethod]
        public void DeliveryAddressPropertyOK()
        {
            clsOrders AnOrders = new clsOrders();
            string TestData = "123 Main Street";
            AnOrders.DeliveryAddress = TestData;
            Assert.AreEqual(AnOrders.DeliveryAddress, TestData);
        }
        // ----- TotalAmount -----
        [TestMethod]
        public void TotalAmountPropertyOK()
        {
            clsOrders AnOrders = new clsOrders();
            // Using decimal type to match your SQL decimal backend design
            decimal TestData = 150.00m;
            AnOrders.TotalAmount = TestData;
            Assert.AreEqual(AnOrders.TotalAmount, TestData);
        }
        // ----- IsPaid -----
        [TestMethod]
        public void IsPaidPropertyOK()
        {
            clsOrders AnOrders = new clsOrders();
            bool TestData = true; // Maps directly to SQL 'bit'
            AnOrders.IsPaid = TestData;
            Assert.AreEqual(AnOrders.IsPaid, TestData);
        }
    }
}
