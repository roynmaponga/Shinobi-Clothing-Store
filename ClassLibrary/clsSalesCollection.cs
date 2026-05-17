using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSalesCollection
    {
        public List<clsSales> SalesList { get; set; }
        public int Count { get; set; }
        public clsSales ThisSale { get; set; }
    }
}