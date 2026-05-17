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
            TestItem.PaymentMethod = "Card";
            TestItem.SaleStatus = "Completed";
            TestItem.IsRefunded = false;

            TestList.Add(TestItem);

            AllSales.SalesList = TestList;

            Assert.AreEqual(AllSales.SalesList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsSalesCollection AllSales = new clsSalesCollection();
            Int32 SomeCount = 1;

            AllSales.Count = SomeCount;

            Assert.AreEqual(AllSales.Count, SomeCount);
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
            TestSale.PaymentMethod = "Card";
            TestSale.SaleStatus = "Completed";
            TestSale.IsRefunded = false;

            AllSales.ThisSale = TestSale;

            Assert.AreEqual(AllSales.ThisSale, TestSale);
        }
    }
}