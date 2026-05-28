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

            // Use an OrderID that is not already used in tblSales
            TestItem.OrderID = 4;
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
    }
}