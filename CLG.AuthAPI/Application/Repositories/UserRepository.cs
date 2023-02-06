using CLG.AuthAPI.Application.Models;

namespace CLG.AuthAPI.Application.Repositories
{
    public class UserRepository : IRepository<User>
    {
        //private readonly Context _context;
        //public UserRepository(Context context)
        //{

        //    _context = context;
        //    using (var _context = new Context())
        //    {
        //        _context.Add(new User { Id = Guid.NewGuid(), Username = "admin", Password = "admin" });
        //        _context.SaveChanges();
        //    }
        //}
        public User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = Guid.NewGuid(), Username = "admin", Password = "admin" });

            //using (var _context = new Context())
            //{
            //    return _context.Users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
            //}

            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
        }

    }
}
