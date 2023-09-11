using Microsoft.EntityFrameworkCore;
using health_club.API.Models.Domain;
using health_club.API.Data;

namespace health_club.API.Repositories
{
    public class SQLRideRepository : IRideRepository
    {
        private readonly health_clubDbContext dbContext;

        public SQLRideRepository(health_clubDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Ride> CreateAsync(Ride ride)
        {
            await dbContext.Rides.AddAsync(ride);
            await dbContext.SaveChangesAsync();
            return ride;
        }

        public async Task<List<Ride>> GetAllAsync()
        {
            // Type safe
            //return await dbContext.Rides.Include(x => x.Difficulty).ToListAsync();

            return await dbContext.Rides.Include("Difficulty").ToListAsync();
        }

        public async Task<Ride?> GetByIdAsync(Guid id)
        {
            return await dbContext.Rides.Include("Difficulty").FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Ride?> UpdateAsync(Guid id, Ride ride)
        {
            var existingRide = await dbContext.Rides.FirstOrDefaultAsync(x => x.Id == id);

            if (existingRide == null)
            {
                return null;
            }

            existingRide.Name = ride.Name;
            existingRide.Description = ride.Description;
            existingRide.Price = ride.Price;
            existingRide.RideImageURL = ride.RideImageURL;
            existingRide.DifficultyId = ride.DifficultyId;

            await dbContext.SaveChangesAsync();

            return existingRide;
        }

        public async Task<Ride?> DeleteAsync(Guid id)
        {
            var existingRide = await dbContext.Rides.FirstOrDefaultAsync(x => x.Id == id);

            if (existingRide == null)
            {
                return null;
            }

            dbContext.Rides.Remove(existingRide);
            await dbContext.SaveChangesAsync();
            return existingRide;
        }

    }
}