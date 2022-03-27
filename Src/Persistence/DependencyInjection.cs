



namespace Persistence;
public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection service)
    {
        service.AddScoped<IAppDbContext, AppDbContext>();
        return service;
    }
}