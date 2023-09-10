using health_club.API.Data;
using health_club.API.Models.Domain;
using health_club.API.Repositories;
using Microsoft.EntityFrameworkCore;

public class ReviewRepository : IReviewRepository
{
    private readonly health_clubDbContext dbContext;

    public ReviewRepository(health_clubDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<IEnumerable<Review>> GetAllReviewsAsync()
    {
        return await dbContext.Reviews.ToListAsync();
    }

    public async Task<Review> GetReviewByIdAsync(int id)
    {
        return await dbContext.Reviews.FindAsync(id);
    }

    public async Task AddReviewAsync(Review review)
    {
        await dbContext.Reviews.AddAsync(review);
        await dbContext.SaveChangesAsync();
    }

    public async Task UpdateReviewAsync(Review review)
    {
        dbContext.Entry(review).State = EntityState.Modified;
        await dbContext.SaveChangesAsync();
    }

    public async Task DeleteReviewAsync(Review review)
    {
        dbContext.Reviews.Remove(review);
        await dbContext.SaveChangesAsync();
    }

    public bool ReviewExists(int id)
    {
        return dbContext.Reviews.Any(e => e.Id == id);
    }
}
