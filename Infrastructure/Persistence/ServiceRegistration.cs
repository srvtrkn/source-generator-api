using Application.RepositoryInterfaces;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;
namespace Persistence
{
    public static class ServiceRegistration
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddSingleton<PostreSqlDbContext>();
            services.AddTransient<IAuthRepository, AuthRepository>();
        }
    }
}
