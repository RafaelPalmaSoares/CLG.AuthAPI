using CLG.AuthAPI.Application.Mappings;
using CLG.AuthAPI.Application.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CLG.AuthAPI.Application.Repositories
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            //modelBuilder.Entity<User>().ToTable("User").HasData(new User { Id = Guid.NewGuid(), Username = "admin", Password = "admin" });
        }
    }
}
