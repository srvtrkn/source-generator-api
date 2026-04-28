using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace Persistence.Contexts
{
    public class PostreSqlDbContext
    {
        private readonly string connectionString;
        private readonly IConfiguration configuration;
        public PostreSqlDbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
            connectionString = GetConnectionString();
        }
        public IDbConnection CreateConnection()
            => new NpgsqlConnection(connectionString);
        private string GetConnectionString()
        {
            IEnumerable<IConfigurationSection> connectionStrings = configuration.GetSection("ConnectionStrings").GetChildren();
            return connectionStrings.FirstOrDefault(config => config.Key == "postreConnStr")?.Value ?? "";
        }
    }
}
