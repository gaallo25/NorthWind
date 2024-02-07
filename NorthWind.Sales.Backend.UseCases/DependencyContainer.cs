namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddScoped<ICreateOrderInputPort, CreateOrderInteractor>();

            return services;
        }
    }
}
