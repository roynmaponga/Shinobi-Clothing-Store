using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Testing2
{
    [TestClass]
    public class tstproductCollection
    {


        [TestMethod]
        public void InstanceOK()
        {
            ClsproductCollection Allproducts = new ClsproductCollection();
            Assert.IsNotNull(Allproducts);
        }
        [TestMethod]
        public void ProductListOK()
        {
            ClsproductCollection Allproducts = new ClsproductCollection();
            List<clsproduct> TestList = new List<clsproduct>();
            clsproduct TestItem = new clsproduct();
            TestItem.Productname = "Test Product";
            TestItem.price = 9.99m;
            TestItem.StockQuantity = 100;
            TestItem.size = "Medium";
            TestItem.color = "Red";
            TestItem.Active = true;
            TestList.Add(TestItem);
            Allproducts.ProductList = TestList;
            Assert.AreEqual(Allproducts.ProductList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            ClsproductCollection Allproducts = new ClsproductCollection();
            Int32 SomeCount = 2;
            Allproducts.Count = SomeCount;
            Assert.AreEqual(Allproducts.Count, SomeCount);
        }
        public void ThisProductPropertyOK()
        {
            ClsproductCollection Allproducts = new ClsproductCollection();
            clsproduct TestProduct = new clsproduct();
            TestProduct.Productname = "Test Product";
            TestProduct.price = 9.99m;
            TestProduct.StockQuantity = 100;
            TestProduct.size = "Medium";
            TestProduct.color = "Red";
            TestProduct.Active = true;
            Allproducts.Thisproduct = TestProduct;
            Assert.AreEqual(Allproducts.Thisproduct, TestProduct);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            ClsproductCollection Allproducts = new ClsproductCollection();
            List<clsproduct> TestList = new List<clsproduct>();
            clsproduct TestItem = new clsproduct();
            TestItem.Productname = "Test Product";
            TestItem.price = 9.99m;
            TestItem.StockQuantity = 100;
            TestItem.size = "Medium";
            TestItem.color = "Red";
            TestItem.Active = true;
            TestList.Add(TestItem);
            Allproducts.ProductList = TestList;
            Assert.AreEqual(Allproducts.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            ClsproductCollection Allproducts = new ClsproductCollection();
            Assert.AreEqual(2, Allproducts.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            ClsproductCollection Allproducts = new ClsproductCollection();
            clsproduct TestItem = new clsproduct();

            Int32 PrimaryKey = 0;

            TestItem.Productname = "Test Product";
            TestItem.price = 9.99m;
            TestItem.StockQuantity = 100;
            TestItem.size = "Medium";
            TestItem.color = "Red";
            TestItem.Active = true;

            Allproducts.Thisproduct = TestItem;
            PrimaryKey = Allproducts.Add();

            TestItem.ProductID = PrimaryKey;
            Allproducts.Thisproduct.Find(PrimaryKey);

            Assert.AreEqual(Allproducts.Thisproduct, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            ClsproductCollection Allproducts = new ClsproductCollection();
            clsproduct TestItem = new clsproduct();
            Int32 PrimaryKey = 0;
            TestItem.Productname = "Test Product";
            TestItem.price = 9.99m;
            TestItem.StockQuantity = 100;
            TestItem.size = "Medium";
            TestItem.color = "Red";
            TestItem.Active = true;
            Allproducts.Thisproduct = TestItem;
            PrimaryKey = Allproducts.Add();
            TestItem.ProductID = PrimaryKey;
            TestItem.Productname = "Updated Product";
            TestItem.price = 19.99m;
            TestItem.StockQuantity = 50;
            TestItem.size = "Large";
            TestItem.color = "Blue";
            TestItem.Active = false;
            Allproducts.Thisproduct = TestItem;
            Allproducts.Update();
            Allproducts.Thisproduct.Find(PrimaryKey);
            Assert.AreEqual(Allproducts.Thisproduct, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            ClsproductCollection Allproduct = new ClsproductCollection();
            clsproduct TestItem = new clsproduct();
            Int32 PrimaryKey = 0;
            TestItem.Productname = "Test Product";
            TestItem.price = 9.99m;
            TestItem.StockQuantity = 100;
            TestItem.size = "Medium";
            TestItem.color = "Red";
            TestItem.Active = true;
            Allproduct.Thisproduct = TestItem;
            PrimaryKey = Allproduct.Add();
            TestItem.ProductID = PrimaryKey;
            Allproduct.Thisproduct.Find(PrimaryKey);
            Allproduct.Delete();
            Boolean Found = Allproduct.Thisproduct.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByPostCode()
        {
            ClsproductCollection Allproduct = new ClsproductCollection();
            ClsproductCollection FilterProduct = new ClsproductCollection();
            FilterProduct.ReportByPostCode("");
            Assert.AreEqual(Allproduct.Count, FilterProduct.Count);
        }

    }
}
