using Microsoft.EntityFrameworkCore;
using SOLID.SRP.Models;

namespace SOLID.SRP.Context
{
    public class SRPContext : DbContext
    {
        public SRPContext(DbContextOptions<SRPContext> options) : base(options) { }

        DbSet<User> Users {  get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Table
            modelBuilder.Entity<User>().ToTable("Users");
            #endregion

            #region Primary Key
            modelBuilder.Entity<User>().HasKey(f => f.Id);
            #endregion

            #region Property
            modelBuilder.Entity<User>().Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(50);
            #endregion
        }

    }
}
