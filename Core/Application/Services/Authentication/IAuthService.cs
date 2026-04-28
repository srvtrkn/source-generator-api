using Application.Attributes;
using Domain.Common;

namespace Application.Services.Authentication;

[GenerateApiEndpoint(RoutePrefix = "api/auth", Tag = "Auth")]
public interface IAuthService
{
    Task<Response<string>> Login();
}
