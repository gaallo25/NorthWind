namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddScoped<ICommandsRepository, CommandsRepository>();

            return services;
        }
    }
}
