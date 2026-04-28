using Application.Attributes;
using Domain.Common;

namespace Application.Services.User;

[GenerateApiEndpoint(RoutePrefix = "api/user", Tag = "User")]
public interface IUserService
{
    Task<Response<string>> GetUserById(string userId);
    Task<Response<string>> UpdateUser(string userId);
}
