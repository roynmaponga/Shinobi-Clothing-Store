using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ClassLibrary;

namespace TestingSales
{
    [TestClass]
    public class tstSalesCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSalesCollection AllSales = new clsSalesCollection();
            Assert.IsNotNull(AllSales);
        }

        [TestMethod]
        public void SalesListOK()
        {
            clsSalesCollection AllSales = new clsSalesCollection();

            List<clsSales> TestList = new List<clsSales>();

            clsSales TestItem = new clsSales();

            TestItem.SaleID = 1;
            TestItem.OrderID = 1;
            TestItem.SaleDate = DateTime.Now.Date;
            TestItem.TotalAmount = 21.00m;
            TestItem.PaymentMethod = "card";
            TestItem.SaleStatus = "completed";
            TestItem.IsRefunded = false;

            TestList.Add(TestItem);

            AllSales.SalesList = TestList;

            Assert.AreEqual(TestList, AllSales.SalesList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsSalesCollection AllSales = new clsSalesCollection();

            List<clsSales> TestList = new List<clsSales>();

            clsSales TestItem = new clsSales();

            TestItem.SaleID = 1;
            TestItem.OrderID = 1;
            TestItem.SaleDate = DateTime.Now.Date;
            TestItem.TotalAmount = 21.00m;
            TestItem.PaymentMethod = "card";
            TestItem.SaleStatus = "completed";
            TestItem.IsRefunded = false;

            TestList.Add(TestItem);

            AllSales.SalesList = TestList;

            Assert.AreEqual(TestList.Count, AllSales.Count);
        }

        [TestMethod]
        public void ThisSalePropertyOK()
        {
            clsSalesCollection AllSales = new clsSalesCollection();

            clsSales TestSale = new clsSales();

            TestSale.SaleID = 1;
            TestSale.OrderID = 1;
            TestSale.SaleDate = DateTime.Now.Date;
            TestSale.TotalAmount = 21.00m;
            TestSale.PaymentMethod = "card";
            TestSale.SaleStatus = "completed";
            TestSale.IsRefunded = false;

            AllSales.ThisSale = TestSale;

            Assert.AreEqual(TestSale, AllSales.ThisSale);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsSalesCollection AllSales = new clsSalesCollection();

            List<clsSales> TestList = new List<clsSales>();

            clsSales TestItem = new clsSales();

            TestItem.SaleID = 1;
            TestItem.OrderID = 1;
            TestItem.SaleDate = DateTime.Now.Date;
            TestItem.TotalAmount = 21.00m;
            TestItem.PaymentMethod = "card";
            TestItem.SaleStatus = "completed";
            TestItem.IsRefunded = false;

            TestList.Add(TestItem);

            AllSales.SalesList = TestList;

            Assert.AreEqual(TestList.Count, AllSales.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsSalesCollection AllSales = new clsSalesCollection();

            clsSales TestItem = new clsSales();

            Int32 PrimaryKey = 0;

            // Use a fresh unused OrderID
            TestItem.OrderID = 22;
            TestItem.SaleDate = DateTime.Now.Date;
            TestItem.TotalAmount = 21.00m;
            TestItem.PaymentMethod = "card";
            TestItem.SaleStatus = "completed";
            TestItem.IsRefunded = false;

            AllSales.ThisSale = TestItem;

            PrimaryKey = AllSales.Add();

            TestItem.SaleID = PrimaryKey;

            AllSales.ThisSale.Find(PrimaryKey);

            Assert.AreEqual(TestItem.SaleID, AllSales.ThisSale.SaleID);
            Assert.AreEqual(TestItem.OrderID, AllSales.ThisSale.OrderID);
            Assert.AreEqual(TestItem.SaleDate, AllSales.ThisSale.SaleDate);
            Assert.AreEqual(TestItem.TotalAmount, AllSales.ThisSale.TotalAmount);
            Assert.AreEqual(TestItem.PaymentMethod, AllSales.ThisSale.PaymentMethod);
            Assert.AreEqual(TestItem.SaleStatus, AllSales.ThisSale.SaleStatus);
            Assert.AreEqual(TestItem.IsRefunded, AllSales.ThisSale.IsRefunded);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSalesCollection AllSales = new clsSalesCollection();

            clsSales TestItem = new clsSales();

            Int32 PrimaryKey = 0;

            // First fresh unused OrderID for insert
            TestItem.OrderID = 24;
            TestItem.SaleDate = DateTime.Now.Date;
            TestItem.TotalAmount = 21.00m;
            TestItem.PaymentMethod = "card";
            TestItem.SaleStatus = "completed";
            TestItem.IsRefunded = false;

            AllSales.ThisSale = TestItem;

            PrimaryKey = AllSales.Add();

            TestItem.SaleID = PrimaryKey;

            // Second fresh unused OrderID for update
            TestItem.OrderID = 25;
            TestItem.SaleDate = DateTime.Now.Date;
            TestItem.TotalAmount = 25.00m;
            TestItem.PaymentMethod = "cash";
            TestItem.SaleStatus = "pending";
            TestItem.IsRefunded = true;

            AllSales.ThisSale = TestItem;

            AllSales.Update();

            AllSales.ThisSale.Find(PrimaryKey);

            Assert.AreEqual(TestItem.SaleID, AllSales.ThisSale.SaleID);
            Assert.AreEqual(TestItem.OrderID, AllSales.ThisSale.OrderID);
            Assert.AreEqual(TestItem.SaleDate, AllSales.ThisSale.SaleDate);
            Assert.AreEqual(TestItem.TotalAmount, AllSales.ThisSale.TotalAmount);
            Assert.AreEqual(TestItem.PaymentMethod, AllSales.ThisSale.PaymentMethod);
            Assert.AreEqual(TestItem.SaleStatus, AllSales.ThisSale.SaleStatus);
            Assert.AreEqual(TestItem.IsRefunded, AllSales.ThisSale.IsRefunded);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSalesCollection AllSales = new clsSalesCollection();

            clsSales TestItem = new clsSales();

            Int32 PrimaryKey = 0;
            Boolean Found = false;

            // Use a fresh unused OrderID
            TestItem.OrderID = 20;
            TestItem.SaleDate = DateTime.Now.Date;
            TestItem.TotalAmount = 21.00m;
            TestItem.PaymentMethod = "card";
            TestItem.SaleStatus = "completed";
            TestItem.IsRefunded = false;

            // Add the record
            AllSales.ThisSale = TestItem;

            PrimaryKey = AllSales.Add();

            // Set the primary key
            TestItem.SaleID = PrimaryKey;

            // Set ThisSale again with the correct SaleID
            AllSales.ThisSale = TestItem;

            // Delete the record
            AllSales.Delete();

            // Use a new Sales object to check if the record still exists
            clsSales DeletedSale = new clsSales();

            Found = DeletedSale.Find(PrimaryKey);

            // The deleted record should not be found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportBySaleStatusMethodOK()
        {
            clsSalesCollection AllSales = new clsSalesCollection();

            AllSales.ReportBySaleStatus("");

            Assert.IsNotNull(AllSales);
        }

        [TestMethod]
        public void ReportBySaleStatusNoneFound()
        {
            clsSalesCollection FilteredSales = new clsSalesCollection();

            FilteredSales.ReportBySaleStatus("xxxxxxx");

            Assert.AreEqual(0, FilteredSales.Count);
        }

        [TestMethod]
        public void ReportBySaleStatusTestDataFound()
        {
            clsSalesCollection FilteredSales = new clsSalesCollection();

            Boolean OK = true;

            FilteredSales.ReportBySaleStatus("completed");

            if (FilteredSales.Count == 0)
            {
                OK = false;
            }

            foreach (clsSales ASale in FilteredSales.SalesList)
            {
                if (ASale.SaleStatus.ToLower().Contains("completed") == false)
                {
                    OK = false;
                }
            }

            Assert.IsTrue(OK);
        }
    }
}