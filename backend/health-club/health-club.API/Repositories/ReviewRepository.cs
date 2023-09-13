using System;
using health_club.API.Data;
using health_club.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace health_club.API.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly health_clubAuthDbContext authDbContext;

        public ReviewRepository(health_clubAuthDbContext authDbContext)
        {
            this.authDbContext = authDbContext;
        }

        
        public async Task<Review> CreateAsync(Review review)
        {
            await authDbContext.Reviews.AddAsync(review);
            await authDbContext.SaveChangesAsync();
            return review;
        }

        public async Task<List<Review>> GetAllAsync()
        {
            return await authDbContext.Reviews.ToListAsync();
        }

        public async Task<Review?> GetByIdAsync(Guid id)
        {
            return await authDbContext.Reviews.FirstOrDefaultAsync(x => x.ReviewId == id); ;
        }

        public async Task<List<Review>> GetByUserIdAsync(string userId)
        {
            return await authDbContext.Reviews.Where(r => r.UserId == userId).ToListAsync();
        }

        public async Task<Review?> DeleteAsync(Guid id)
        {
            var review = await GetByIdAsync(id);
            if (review == null)
            {
                return null;
            }

            authDbContext.Reviews.Remove(review);
            await authDbContext.SaveChangesAsync();
            return review;
        }

    }
}

