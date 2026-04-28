using Microsoft.Extensions.DependencyInjection;
namespace Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            //services.AddSingleton<ICacheManager, CacheManager>();
            //services.AddScoped<IMailService, MailService>();
        }
    }
}
