using System;
using System.ComponentModel.DataAnnotations;

namespace health_club.API.Models.DTO
{
	public class UpdateRideRequestDto
	{
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        [MinLength(9)]
        public string Price { get; set; }

        // Add "?" after "string" if want to make nullable
        public string? RideImageURL { get; set; }

        [Required]
        public Guid DifficultyId { get; set; }
    }
}

