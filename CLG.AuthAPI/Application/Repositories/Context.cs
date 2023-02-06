using Microsoft.EntityFrameworkCore;
using System;

namespace CLG.AuthAPI.Application.Repositories
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
    }
}
