using System;

namespace ClassLibrary
{
    public class    Clsproduct
    {
        public Clsproduct()
        {
        }

        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int ProductId { get; set; }
        public int CountyCode { get; set; }
        public string HouseNo { get; set; }
        public string Postcode { get; set; }
        public string Town { get; set; }
    }
}