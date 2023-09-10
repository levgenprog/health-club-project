using System;
using health_club.API.Models.Domain;
using health_club.API.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using health_club.API.Data;
using Microsoft.EntityFrameworkCore;
using health_club.API.Repositories;

namespace health_club.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewRepository reviewRepository;

        public ReviewsController(IReviewRepository reviewRepository)
        {
            this.reviewRepository = reviewRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review>>> GetReviews()
        {
            return Ok(await reviewRepository.GetAllReviewsAsync());
        }

        [HttpPost]
        //[Authorize(Roles = "Reader")]
        public async Task<ActionResult<Review>> PostReview(ReviewDto reviewDto)
        {
            var review = new Review
            {
                Content = reviewDto.Content,
                DatePosted = DateTime.UtcNow,
                PostedBy = User.Identity.Name
            };

            await reviewRepository.AddReviewAsync(review);
            return CreatedAtAction("GetReview", new { id = review.Id }, review);
        }

        [HttpPut("{id}")]
        //[Authorize(Roles = "Reader")]
        public async Task<IActionResult> PutReview(int id, ReviewDto reviewDto)
        {
            if (!reviewRepository.ReviewExists(id))
            {
                return NotFound();
            }

            var review = await reviewRepository.GetReviewByIdAsync(id);
            review.Content = reviewDto.Content;
            review.DatePosted = DateTime.UtcNow;

            await reviewRepository.UpdateReviewAsync(review);
            return NoContent();
        }

        [HttpDelete("{id}")]
        //[Authorize(Roles = "Reader")]
        public async Task<ActionResult<Review>> DeleteReview(int id)
        {
            var review = await reviewRepository.GetReviewByIdAsync(id);
            if (review == null)
            {
                return NotFound();
            }

            await reviewRepository.DeleteReviewAsync(review);
            return review;
        }
    }


}

