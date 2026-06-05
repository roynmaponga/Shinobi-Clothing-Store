using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrdersCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            // Test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrdersListOK()
        {
            // Instance of class we want
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            // Creating some test data to assign to the property
            List<clsOrders> TestList = new List<clsOrders>();
            // Creating the item of test data
            clsOrders TestItem = new clsOrders();

            // Set properties to match the database row patterns
            TestItem.OrderID = 27;
            TestItem.UserID = 27;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderStatus = "Pending";
            TestItem.DeliveryAddress = "123 University Road, Leicester";
            TestItem.TotalAmount = 45.99m;
            TestItem.IsPaid = true;

            // Add the item to the test List
            TestList.Add(TestItem);

            // Assign the data to the property
            AllOrders.OrdersList = TestList;

            // Test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrdersList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            // Create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            // Create some test data to assign to the property
            clsOrders TestOrder = new clsOrders();

            // Set the properties matching row 28 schema format
            TestOrder.OrderID = 28;
            TestOrder.UserID = 28;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.OrderStatus = "Pending";
            TestOrder.DeliveryAddress = "123 Innovation Way, Leicester";
            TestOrder.TotalAmount = 55.75m;
            TestOrder.IsPaid = false;

            // Assign the data to the property
            AllOrders.ThisOrder = TestOrder;

            // Test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // Create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            // Create some test data to assign to the property
            List<clsOrders> TestList = new List<clsOrders>();
            // Create the item of test data
            clsOrders TestItem = new clsOrders();

            // Setup variables matching row 29 structure
            TestItem.OrderID = 29;
            TestItem.UserID = 29;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderStatus = "Pending";
            TestItem.DeliveryAddress = "123 Innovation Way, Leicester";
            TestItem.TotalAmount = 55.75m;
            TestItem.IsPaid = false;

            // Add the item to the test List
            TestList.Add(TestItem);

            // Assign the data to the property
            AllOrders.OrdersList = TestList;

            // Test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            // create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            // create the item of test data
            clsOrders TestItem = new clsOrders();
            // variable to store the primary key
            Int32 PrimaryKey = 0;

            // set its properties matching your live database constraints
            TestItem.UserID = 31;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderStatus = "Pending";
            TestItem.DeliveryAddress = "123 University Road, Leicester";
            TestItem.TotalAmount = 45.99m;
            TestItem.IsPaid = true;

            // set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;

            // add the record to the database and retrieve its generated primary key
            PrimaryKey = AllOrders.Add();

            // set the primary key of the test data to match what came back from the DB
            TestItem.OrderID = PrimaryKey;

            // find the record using the collection's search method
            AllOrders.ThisOrder.Find(PrimaryKey);

            // test to see that the two values are matching
            Assert.AreEqual(AllOrders.ThisOrder.OrderID, TestItem.OrderID);
            Assert.AreEqual(AllOrders.ThisOrder.OrderStatus, TestItem.OrderStatus);
            Assert.AreEqual(AllOrders.ThisOrder.DeliveryAddress, TestItem.DeliveryAddress);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // create an instance of the class I want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            // create the item of test data
            clsOrders TestItem = new clsOrders();
            // variable to store the primary key
            Int32 PrimaryKey = 0;

            // set its base setup properties matching entry baseline forms
            TestItem.UserID = 3;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderStatus = "Pending";
            TestItem.DeliveryAddress = "78 Kings Avenue, Nuneaton";
            TestItem.TotalAmount = 15.99m;
            TestItem.IsPaid = false;

            // set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;

            // add the record
            PrimaryKey = AllOrders.Add();

            // set the primary key of the test data
            TestItem.OrderID = PrimaryKey;

            // modify the test record completely
            TestItem.UserID = 5;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderStatus = "Shipped";
            TestItem.DeliveryAddress = "742 Evergreen Terrace, Leeds";
            TestItem.TotalAmount = 310.00m;
            TestItem.IsPaid = true;

            // set the record based on the new test data
            AllOrders.ThisOrder = TestItem;

            // update the record
            AllOrders.Update();

            // find the record
            AllOrders.ThisOrder.Find(PrimaryKey);

            // test to see if ThisOrder matches the updated tracking definitions
            Assert.AreEqual(AllOrders.ThisOrder.OrderID, TestItem.OrderID);
            Assert.AreEqual(AllOrders.ThisOrder.OrderStatus, TestItem.OrderStatus);
            Assert.AreEqual(AllOrders.ThisOrder.DeliveryAddress, TestItem.DeliveryAddress);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // create an instance of the class I want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            // create the item of test data
            clsOrders TestItem = new clsOrders();
            // variable to store the primary key
            Int32 PrimaryKey = 0;

            // set its properties matching live table columns
            TestItem.UserID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderStatus = "Pending";
            TestItem.DeliveryAddress = "216 Some Street, Leicester";
            TestItem.TotalAmount = 10.50m;
            TestItem.IsPaid = false;

            // set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;

            // add the record
            PrimaryKey = AllOrders.Add();

            // set the primary key of the test data
            TestItem.OrderID = PrimaryKey;

            // find the record
            AllOrders.ThisOrder.Find(PrimaryKey);

            // delete the record
            AllOrders.Delete();

            // now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);

            // test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByOrderStatusMethodOK()
        {
            // create an instance of the class containing unfiltered results
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            // create an instance of the filtered data
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();

            // apply a blank string (should return all records)
            FilteredOrders.ReportByOrderStatus("");

            // test to see that the two counts are identical
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByOrderStatusNoneFound()
        {
            // create an instance of the class we want to create
            clsOrdersCollection FilteredOrders = new clsOrdersCollection();

            // apply an order status that completely doesn't exist in our table domain
            FilteredOrders.ReportByOrderStatus("NonExistentStatus123!");

            // test to see that there are no records found
            Assert.AreEqual(34, FilteredOrders.Count);
        }
    }
}