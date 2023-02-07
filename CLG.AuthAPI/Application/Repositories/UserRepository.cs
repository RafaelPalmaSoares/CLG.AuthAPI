using CLG.AuthAPI.Application.Models;

namespace CLG.AuthAPI.Application.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly Context _context;
        public UserRepository(Context context)
        {
            _context = context;
        }
        public User Get(string username, string password)
        {
            return _context.Users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
        }

    }
}
