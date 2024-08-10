using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Tactsoft.Infrastructure.Persistence;
using Tactsoft.Infrastructure.Persistence.Interceptors;
using static Tactsoft.SharedKernel.Entities.Identities.IdentityModel;

namespace Tactsoft.Infrastructure;

public static class ServiceCollectionExtension
{
    public static IServiceCollection InfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton(configuration);

        services.AddScoped<AuditableEntitySaveChangesInterceptor>();
        services.AddDbContext<TactsoftDbContext>((serviceProvider, builder) =>
        {
            builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            builder.UseLoggerFactory(serviceProvider.GetRequiredService<ILoggerFactory>());
            builder.LogTo(Console.WriteLine, LogLevel.Debug);
        }, ServiceLifetime.Scoped);

        services.AddIdentity<User, Role>(o =>
        {
            o.Password.RequireDigit = false;
            o.Password.RequireLowercase = false;
            o.Password.RequireUppercase = false;
            o.Password.RequireNonAlphanumeric = false;
            o.User.RequireUniqueEmail = true;
            o.SignIn.RequireConfirmedEmail = true;

        }).AddEntityFrameworkStores<TactsoftDbContext>().AddDefaultTokenProviders();


        //services.AddMvc(config => config.Filters.Add(new AuthorizeFilter()));
        //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
        //{
        //    options.ExpireTimeSpan = TimeSpan.Zero;
        //    options.SlidingExpiration = false;
        //});
        //services.AddSession();

        return services;
    }
}
