using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tactsoft.Application;
using Tactsoft.Infrastructure;
using Tactsoft.SharedKernel.Core.EmailService;
using Tactsoft.SharedKernel.Core.FileExtentions;
using static Tactsoft.SharedKernel.Core.PaymentGateway.SSLCommerzGateway;

namespace Tactsoft.IoC.Configuration;

public static class ServiceCollectionExtension
{
    public static IServiceCollection ServiceRegistation(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllersWithViews();
        services.AddRazorPages();

        // Add services to the container.

        services.InfrastructureServices(configuration);
        services.ApplicationServices(configuration);
        services.AddAuthorizationBuilder().AddPolicy("DebugPolicy", policy => policy.RequireAssertion(context => true));



        services.Configure<SSLCommerzSetting>(configuration.GetSection("SSLCommerzSetting"));
        services.Configure<MailSetting>(configuration.GetSection("MailSetting"));

        services.AddScoped<MailService, MailService>();
        services.AddScoped<IFileStorageService, FileStorageService>();

        return services;
    }
}
