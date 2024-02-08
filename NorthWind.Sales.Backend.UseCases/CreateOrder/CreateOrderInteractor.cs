namespace NorthWind.Sales.Backend.UseCases.CreateOrder
{
    internal class CreateOrderInteractor(ICreateOrderOutputPort outputPort, 
        ICommandsRepository repository) : ICreateOrderInputPort
    {
        public async Task Handle(CreateOrderDto createOrderDto)
        {
            OrderAggregate Order = OrderAggregate.From(createOrderDto);
            await repository.CreateOrder(Order);
            await repository.SaveChanges();
            await outputPort.Handle(Order);
        }
    }
}
