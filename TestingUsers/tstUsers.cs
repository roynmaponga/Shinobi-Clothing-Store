using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing1;

namespace TestingUsers
{
    [TestClass]
    public class tstUsers
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsUsers AUser = new clsUsers();

            Assert.IsNotNull(AUser);
        }
    }
}

namespace Testing1
{
    class clsUsers
    {
    }
}