using Microsoft.EntityFrameworkCore;
using health_club.API.Models.Domain;

namespace health_club.API.Data
{
    public class health_clubDbContext : DbContext
    {
        public health_clubDbContext(DbContextOptions<health_clubDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Ride> Rides { get; set; }

        public DbSet<Image> Images { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data  for Difficulties
            // Easy, Medium, Hard

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("F903E81C-7BE0-4F1F-A1BF-75645E618028"),
                    Name = "Easy",
                },
                new Difficulty()
                {
                    Id = Guid.Parse("DDFDF227-2CFE-484C-A911-04756F9CAC34"),
                    Name = "Medium",
                },
                new Difficulty()
                {
                    Id = Guid.Parse("98404C19-BCA0-4421-BB17-1A64360890DE"),
                    Name = "Hard",
                }
            };

            // Seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);


        }
    }
}