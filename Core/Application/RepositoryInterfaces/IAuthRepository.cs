namespace Application.RepositoryInterfaces
{
    public interface IAuthRepository
    {
        Task<string> Login(string request);
    }
}
