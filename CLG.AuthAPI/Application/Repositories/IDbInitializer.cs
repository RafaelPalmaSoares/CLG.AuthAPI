namespace CLG.AuthAPI.Application.Repositories
{
    public interface IDbInitializer
    {
        public void Initialize();
        public void SeedData();
    }
}
