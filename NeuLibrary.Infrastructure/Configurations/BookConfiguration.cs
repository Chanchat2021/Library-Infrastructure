using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeuLibrary.Domain.Entity;

namespace NeuLibrary.Infrastructure.Configurations
{
    public class BookConfiguration :IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
        builder.ToTable("Book").HasKey(e => e.Id);
        builder.Property(p => p.Author).IsRequired().HasMaxLength(30);
        builder.Property(p => p.Publisher).IsRequired().HasMaxLength(50);
        builder.Property(p => p.Title).IsRequired().HasMaxLength(30);
        builder.Property(p => p.IsReserved).HasDefaultValue(false);
            builder.HasOne(u => u.Reserve)
              .WithOne(u => u.Book)
              .HasForeignKey<Reserve>(u => u.BookId);
        }
    }
}
