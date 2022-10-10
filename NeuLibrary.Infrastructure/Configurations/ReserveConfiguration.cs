using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeuLibrary.Domain.Entity;

namespace NeuLibrary.Infrastructure.Configurations
{
    public class ReserveConfiguration : IEntityTypeConfiguration<Reserve>
    {
        public void Configure(EntityTypeBuilder<Reserve> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p => p.BookId).IsRequired();
        }
    }
}
