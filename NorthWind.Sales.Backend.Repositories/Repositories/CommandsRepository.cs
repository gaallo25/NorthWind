namespace NorthWind.Sales.Backend.Repositories.Repositories
{
    internal class CommandsRepository(INorthWindSalesCommandsDataContext context) : ICommandsRepository
    {
        public async Task CreateOrder(OrderAggregate order)
        {
            await context.AddOrderAsync(order);
            await context.AddOrderDetailAsync(
                order.OrderDetails
                .Select(x => new Entities.OrderDetail
                {
                    Order = order,
                    ProductId = x.ProductId,
                    Quantity = x.Quantity,
                    UnitPrice = x.UnitPrice
                }).ToArray());
        }

        public Task SaveChanges() => context.SaveChangesAsync();
       
    }
}
