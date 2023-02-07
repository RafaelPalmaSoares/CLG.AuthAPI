using CLG.AuthAPI.Application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CLG.AuthAPI.Application.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(nameof(User))
                .HasKey(p => p.Id);
            builder.Property(p => p.Username).HasMaxLength(20);
            builder.Property(p => p.Password).HasMaxLength(50);

            //builder.HasData(new User { Id = Guid.NewGuid(), Username = "admin", Password = "admin" });
        }
    }
}
