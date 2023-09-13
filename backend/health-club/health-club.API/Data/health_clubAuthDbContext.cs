using System;
using health_club.API.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace health_club.API.Data
{
    public class health_clubAuthDbContext : IdentityDbContext
    {
        public health_clubAuthDbContext(DbContextOptions<health_clubAuthDbContext> options) : base(options)
        {

        }

        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "266D413A-76D8-4050-B63E-F27F0E9B86E1";
            var writerRoleId = "B4DCF9F7-DA5C-40AB-8702-51CA2753B189";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = readerRoleId,
                    ConcurrencyStamp = readerRoleId,
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper()
                },
                new IdentityRole
                {
                    Id = writerRoleId,
                    ConcurrencyStamp = writerRoleId,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper()
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);

            builder.Entity<Review>()
            .HasOne(r => r.User) // Each review has one associated user
            .WithMany() // But each user can have many reviews
            .HasForeignKey(r => r.UserId);  // The foreign key in the Review table that establishes this relationship is 'UserId'
        }
    }
}