

namespace Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection service)
    {
        service.AddTransient<IPlatfromQueryService, PlatfromQueryService>();
        service.AddTransient<IPlatfromCommandService, PlatfromCommandService>();
        service.AddMediatR(Assembly.GetExecutingAssembly());
        service.AddAutoMapper(Assembly.GetExecutingAssembly());
        return service;
    }
}