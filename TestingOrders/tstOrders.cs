using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void InstanceOK()
        {
            tstOrders AnOrders = new tstOrders();   
            Assert.IsNotNull(AnOrders);

        }
    }
}
