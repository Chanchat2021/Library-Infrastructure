using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeuLibrary.Domain.Entity;

namespace NeuLibrary.Infrastructure.Configurations
{
    public class UserRolePermissionConfiguration : IEntityTypeConfiguration<UserRolePermission>
    {
        public void Configure(EntityTypeBuilder<UserRolePermission> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p => p.IsAdmin).HasDefaultValue(false);
        }
    }
}
