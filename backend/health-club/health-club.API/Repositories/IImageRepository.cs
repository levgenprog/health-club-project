using health_club.API.Models.Domain;

namespace health_club.API.Repositories
{
	public interface IImageRepository
	{
		Task<Image> Upload(Image image);
	}
}

