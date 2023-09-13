using System;
using Microsoft.AspNetCore.Identity;

namespace health_club.API.Models.Domain
{
    public class Review
    {
        public Guid ReviewId { get; set; }
        public string Content { get; set; }

        public DateTime DatePosted { get; set; } = DateTime.Now;

        // Navigation properties
        public string UserId { get; set; } // Note: IdentityUser's Id is a string by default.
        public IdentityUser User { get; set; }
    }

}

