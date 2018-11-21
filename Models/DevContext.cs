using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HelloApi.Models
{
    public partial class DevContext : DbContext
    {
        public DevContext()
        {
        }

        public DevContext(DbContextOptions<DevContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.User)
                    .HasColumnName("user")
                    .HasColumnType("varchar(100)");
            });
        }
    }
}
