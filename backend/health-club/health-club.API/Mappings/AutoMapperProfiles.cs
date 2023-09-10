using AutoMapper;
using health_club.API.Models.Domain;
using health_club.API.Models.DTO;
namespace health_club.API.Mappings
{
	public class AutoMapperProfiles : Profile
	{
		public AutoMapperProfiles()
		{
			CreateMap<AddRideRequestDTO, Ride>().ReverseMap();
			CreateMap<Ride, RideDTO>().ReverseMap();
			CreateMap<Difficulty, DifficultyDto>().ReverseMap();
			CreateMap<UpdateRideRequestDto, Ride>().ReverseMap();
		}
	}
}

