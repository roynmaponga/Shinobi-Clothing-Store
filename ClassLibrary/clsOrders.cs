namespace ClassLibrary
{
    public class clsOrders
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public object OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public string DeliveryAddress { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsPaid { get; set; }
    }
}