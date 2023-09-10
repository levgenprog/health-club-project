using health_club.API.Models.Domain;

namespace health_club.API.Repositories
{
	public interface IRideRepository
    {
		Task<Ride> CreateAsync(Ride ride);
        Task<List<Ride>> GetAllAsync();
        Task<Ride?> GetByIdAsync(Guid id);
        Task<Ride?> UpdateAsync(Guid id, Ride ride);
        Task<Ride?> DeleteAsync(Guid id);
    }
}

