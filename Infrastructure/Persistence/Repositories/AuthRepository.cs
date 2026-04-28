using Application.RepositoryInterfaces;
using Dapper;
using Persistence.Contexts;
namespace Persistence.Repositories
{
    public class AuthRepository(PostreSqlDbContext context) : IAuthRepository
    {
        public async Task<string> Login(string request)
        {
            string query = @"SELECT * FROM ""User"" where ""Email""= @Email and ""Password""= @Password and ""IsActive""= true";
            using (var conn = context.CreateConnection())
            {
                return await conn.QueryFirstOrDefaultAsync<string>(query, request);
            }
        }
    }
}
