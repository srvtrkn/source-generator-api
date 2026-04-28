using Application.RepositoryInterfaces;
using Domain.Common;
using Domain.Enums;

namespace Application.Services.Authentication
{
    public class AuthService(IAuthRepository authRepository) : IAuthService
    {
        public async Task<Response<string>> Login()
        {
            string request = string.Empty;
            var data = await authRepository.Login(request);
            if (data != null)
            {
                return new Response<string> { ResponseCode = ResponseCodes.Successful, Data = data };
            }
            else return new Response<string> { ResponseCode = ResponseCodes.ServiceError, ResponseMessage = "Email ve şifrenizi kontrol ederek tekrar giriş yapmayı deneyin" };
        }
    }
}
