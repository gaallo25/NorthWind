namespace NorthWind.Sales.Entities.DTOs.CreateOrder
{
    public class CreateOrderDto(string customerId, string address, string city, string country, string postalCode, IEnumerable<CreateOrderDetailDto> orderDetails)
    {
        public string CustomerId => customerId;
        public string Address => address;
        public string City => city;
        public string Country => country;
        public string PostalCode => postalCode;
        public IEnumerable<CreateOrderDetailDto> OrderDetails => orderDetails;
    }
}
