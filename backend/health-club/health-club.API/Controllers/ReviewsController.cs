using System;
using System.Security.Claims;
using AutoMapper;
using health_club.API.Models.Domain;
using health_club.API.Models.DTO;
using health_club.API.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace health_club.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewRepository reviewRepository;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IMapper mapper;

        public ReviewsController(IMapper mapper, IReviewRepository reviewRepository, UserManager<IdentityUser> userManager)
        {
            this.reviewRepository = reviewRepository;
            this.userManager = userManager;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ReviewDto reviewDto)
        {
            var userId = userManager.GetUserId(User); // Get ID of currently logged-in user
            if (userId != null)
            {
                var review = new Review
                 {
                     Content = reviewDto.Content,
                     UserId = userId
                 };

                var createdReview = await reviewRepository.CreateAsync(review);

                return Ok(createdReview);
            }
            return BadRequest("User not found");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var reviews = await reviewRepository.GetAllAsync();
            return Ok(reviews);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var review = await reviewRepository.GetByIdAsync(id);
            if (review == null)
                return NotFound();

            return Ok(review);
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetByUserId(string userId)
        {
            var reviews = await reviewRepository.GetByUserIdAsync(userId);
            return Ok(reviews);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var deletedReview = await reviewRepository.DeleteAsync(id);
            if (deletedReview == null)
                return NotFound();

            return Ok(deletedReview);
        }
    }
}

