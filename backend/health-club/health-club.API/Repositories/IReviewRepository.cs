using System;
using health_club.API.Models.Domain;

namespace health_club.API.Repositories
{
    public interface IReviewRepository
    {
        Task<Review> CreateAsync(Review review);
        Task<List<Review>> GetAllAsync();
        Task<Review?> GetByIdAsync(Guid id);
        Task<List<Review>?> GetByUserIdAsync(string userId);
        Task<Review?> DeleteAsync(Guid id);
    }
}

