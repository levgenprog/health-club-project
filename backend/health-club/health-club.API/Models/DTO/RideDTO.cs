using System;
namespace health_club.API.Models.DTO
{
	public class RideDTO
	{
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }

        // Add "?" after "string" if want to make nullable
        public string? RideImageURL { get; set; }

        // No need to have here, since  we have this info in DifficultyDTO
        //public Guid DifficultyId { get; set; }

        public DifficultyDto Difficulty { get; set; }
    }
}

