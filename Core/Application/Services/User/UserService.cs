using Domain.Common;

namespace Application.Services.User
{
    public class UserService : IUserService
    {
        public async Task<Response<string>> GetUserById(string userId)
        {
            return new Response<string>
            {
                ResponseCode = Domain.Enums.ResponseCodes.Successful,
                Data = $"User {userId} retrieved"
            };
        }

        public async Task<Response<string>> UpdateUser(string userId)
        {
            return new Response<string>
            {
                ResponseCode = Domain.Enums.ResponseCodes.Successful,
                Data = $"User {userId} updated"
            };
        }
    }
}
