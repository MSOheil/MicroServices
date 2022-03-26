using System.Reflection;

namespace Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection service)
    {
        service.AddScoped<IPlatfromCommandService, PlatfromCommandService>();
        service.AddScoped<IPlatfromQueryService, PlatfromQueryService>();
        service.AddMediatR(Assembly.GetExecutingAssembly());
        service.AddAutoMapper(Assembly.GetExecutingAssembly());
        return service;
    }
}