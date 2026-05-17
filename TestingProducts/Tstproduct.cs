using ClassLibrary;
using FsCheck;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class Tstproduct : TstproductBase
    {

        [TestMethod]
        public void InstanceOk()
        {
            Clsproduct Aproduct = new Clsproduct();

            Assert.IsNotNull(Aproduct);
        }
        [TestMethod]
        public void ActivePropertyOk()
        {
            Clsproduct Aproduct = new Clsproduct();
            Boolean TestData = true;
            Aproduct.Active = TestData;
            Assert.AreEqual(Aproduct.Active, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOk()
        {
            Clsproduct Aproduct = new Clsproduct();
            DateTime TestData = DateTime.Now.Date;
            Aproduct.DateAdded = TestData;
            Assert.AreEqual(Aproduct.DateAdded, TestData);
        }

        [TestMethod]
        public void ProductIdPropertyOk()

        {
            Clsproduct Aproduct = new Clsproduct();
            int TestData = 1;
            Aproduct.ProductId = TestData;
            Assert.AreEqual(Aproduct.ProductId, TestData);
        }
        [TestMethod]
        public void CountyCodePropertyOk()
        {
            Clsproduct Aproduct = new Clsproduct();
            Int32 TestData = 1;
            Aproduct.CountyCode = TestData;
            Assert.AreEqual(Aproduct.CountyCode, TestData);

        }
        [TestMethod]

        public void HouseNoPropertyOk()
        {
            Clsproduct Aproduct = new Clsproduct();
            string TestData = "21b";
            Aproduct.HouseNo = TestData;
            Assert.AreEqual(Aproduct.HouseNo, TestData);

        }
        [TestMethod]
        public void PostcodePropertyOk()
        {
            Clsproduct Aproduct = new Clsproduct();
            string TestData = "le1 1fl";
            Aproduct.Postcode = TestData;
            Assert.AreEqual(Aproduct.Postcode, TestData);
        }
        [TestMethod]
        public void TownPropertyOk()
        {
            Clsproduct Aproduct = new Clsproduct();
            string TestData = "leicester";
            Aproduct.Town = TestData;
            Assert.AreEqual(Aproduct.Town, TestData);
        }
    }
    }
       
    

 