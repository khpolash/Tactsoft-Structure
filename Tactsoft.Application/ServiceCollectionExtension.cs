using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tactsoft.Application.Repositories.Helpers;
using Tactsoft.Infrastructure.Interfaces.BaseRepo;
using Tactsoft.Infrastructure.Interfaces.Helpers;

namespace Tactsoft.Application;

public static class ServiceCollectionExtension
{
    public static IServiceCollection ApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        ArgumentNullException.ThrowIfNull(configuration);

        services.Scan(scan => scan.FromAssemblyOf<IApplication>()
        .AddClasses(classes => classes.AssignableTo<IApplication>())
        .AddClasses(classes => classes.AssignableTo(typeof(IBaseRepository<>)))
        .AsSelfWithInterfaces()
        .WithScopedLifetime());

        services.AddScoped<IUserResolverService, UserResolverService>();

        services.AddValidatorsFromAssembly(typeof(IApplication).Assembly);
        services.AddAutoMapper(x => x.AddMaps(typeof(IApplication).Assembly));

        return services;
    }
}
