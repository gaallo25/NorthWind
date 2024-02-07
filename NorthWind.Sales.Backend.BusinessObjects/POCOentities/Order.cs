
namespace NorthWind.Sales.Backend.BusinessObjects.POCOentities
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerId{ get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public ShippingType ShippingType { get; set; } = ShippingType.Road;
        public DiscountType DiscountType { get; set; } = DiscountType.Percentage;
        public double Discount { get; set; } = 10;
        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}
