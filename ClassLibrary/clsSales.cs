using System;

namespace ClassLibrary
{
    public class clsSales
    {
        public int SaleID { get; set; }
        public int OrderID { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string SaleStatus { get; set; }
        public bool IsRefunded { get; set; }
    }
}