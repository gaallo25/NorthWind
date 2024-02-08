namespace NorthWind.Sales.Backend.BusinessObjects.Aggregates
{
    public class OrderAggregate : Order
    {
        readonly List<OrderDetail> OrderDetailsField = [];
        public IReadOnlyCollection<OrderDetail> OrderDetails => OrderDetailsField;
        public void AddDetail(int productId, decimal unitPrice, short quantity)
        {
            //TODO: IMPLEMENTAR 
            var ExistingOrderDetail = OrderDetailsField.FirstOrDefault(x => x.ProductId == productId);
            if (ExistingOrderDetail != default) 
            {
                quantity += ExistingOrderDetail.Quantity;
                OrderDetailsField.Remove(ExistingOrderDetail);
            }
            OrderDetailsField.Add(new OrderDetail(productId, unitPrice, quantity));
        }

        public static OrderAggregate From(CreateOrderDto orderDto)
        {
            OrderAggregate OrderAggregate = new OrderAggregate
            {
                CustomerId = orderDto.CustomerId,
                Address = orderDto.Address,
                City = orderDto.City,
                Country = orderDto.Country,
                PostalCode = orderDto.PostalCode
            };

                       foreach(var item in  orderDto.OrderDetails)
            {
                OrderAggregate.AddDetail(item.ProductId, item.UnitPrice, item.Quantity);
            }
            return OrderAggregate;
        }
    }
}
