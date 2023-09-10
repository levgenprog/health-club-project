using System;
namespace health_club.API.Models.Domain
{
	public class Review
	{
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime DatePosted { get; set; }
        public string PostedBy { get; set; }
    }
}

