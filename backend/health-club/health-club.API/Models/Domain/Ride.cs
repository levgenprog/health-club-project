using System;
namespace health_club.API.Models.Domain
{
	public class Ride
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

        public string Price { get; set; }

        // Add "?" after "string" if want to make nullable
        public string? RideImageURL { get; set; }

        public Guid DifficultyId { get; set; }

		// Navigation properties
		// One-to-one realtion between Ride and Difficulty
		public Difficulty Difficulty { get; set; }
	}
}

