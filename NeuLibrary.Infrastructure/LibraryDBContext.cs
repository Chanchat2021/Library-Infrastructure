using Microsoft.EntityFrameworkCore;
using NeuLibrary.Domain.Entity;
using System.Reflection;

namespace NeuLibrary.Infrastructure
{
    public class LibraryDBContext : DbContext
    {
        public DbSet<Book> Book { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Reserve> Reserve { get; set; }
        public DbSet<UserRolePermission> UserRolePermission { get; set; }

        public LibraryDBContext(DbContextOptions<LibraryDBContext> contextOptions) : base(contextOptions)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
