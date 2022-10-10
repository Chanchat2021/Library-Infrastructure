using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeuLibrary.Domain.Entity;

namespace NeuLibrary.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User").HasKey(e => e.Id);
            builder.Property(p => p.Email).IsRequired().HasMaxLength(30);
            builder.Property(p => p.Password).IsRequired().HasMaxLength(100);
            builder.HasOne(u => u.UserRolePermission)
               .WithOne(u => u.User)
               .HasForeignKey<UserRolePermission>(u => u.UserId);
            builder.HasMany(u => u.Reserve)
               .WithOne(u => u.User)
               .HasForeignKey(u => u.UserId);
        }
    }
}
