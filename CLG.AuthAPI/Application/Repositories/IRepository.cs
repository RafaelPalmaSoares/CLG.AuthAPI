namespace CLG.AuthAPI.Application.Repositories
{
    public interface IRepository<T>
    {
        T Get(string username, string password);
    }
}
