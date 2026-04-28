using Application.Services.Authentication;
using Application.Services.User;
using Microsoft.Extensions.DependencyInjection;
namespace Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
