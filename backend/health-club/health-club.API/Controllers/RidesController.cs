using AutoMapper;
using health_club.API.Models.Domain;
using health_club.API.Models.DTO;
using health_club.API.Repositories;
using health_club.API.CustomActionFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Text.Json;

namespace health_club.API.Controllers
{
    // /api/rides
    [Route("api/[controller]")]
    [ApiController]
    
    public class RidesController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IRideRepository rideRepository;
        private readonly ILogger<RidesController> logger;

        public RidesController(IMapper mapper, IRideRepository rideRepository, ILogger<RidesController> logger)
        {
            this.mapper = mapper;
            this.rideRepository = rideRepository;
            this.logger = logger;
        }

        // CREATE Ride
        // POST: /api/rides
        [Authorize(Roles = "Writer")]
        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] AddRideRequestDTO addRideRequestDTO)
        {

            // Map DTO to Domain Model
            var rideDomainModel = mapper.Map<Ride>(addRideRequestDTO);

            await rideRepository.CreateAsync(rideDomainModel);

            // Map Domain model to DTO

            return Ok(mapper.Map<RideDTO>(rideDomainModel));

        }

        // GET Rides
        // GET: /api/rides
        [Authorize(Roles = "Reader,Writer")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            //logger.LogInformation("GetAllRides Action Method was invoked");

            //logger.LogWarning("This is a warning log");

            //logger.LogError("This is an error log");

            //try
            //{
            //    throw new Exception("This is a custom exception");

            var ridesDomainModel = await rideRepository.GetAllAsync();

            //logger.LogInformation($"Finished GetAllRides request with data: {JsonSerializer.Serialize(ridesDomainModel)}");

            // Map Domain Model to DTO

            return Ok(mapper.Map<List<RideDTO>>(ridesDomainModel));
            //}
            //catch (Exception ex)
            //{
            //    logger.LogError(ex, ex.Message);
            //    throw;
            //}

        }

        // Get Ride by Id
        // GET: /api/rides/{id}
        [Authorize(Roles = "Reader,Writer")]
        [HttpGet]
        [Route("{id:Guid}")]       
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var rideDomainModel = await rideRepository.GetByIdAsync(id);

            if (rideDomainModel == null)
            {
                return NotFound();
            }

            // Map Domain Model to DTO
            return Ok(mapper.Map<RideDTO>(rideDomainModel));
        }

        // Update Walk By Id
        // Rut: /api/Walks/{id}
        [HttpPut]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Writer")]
        [ValidateModel]
        public async Task<IActionResult> Update([FromRoute] Guid id, UpdateRideRequestDto updateRideRequestDto)
        {
            // Map DTO to Domain Model
            var rideDomainModel = mapper.Map<Ride>(updateRideRequestDto);

            rideDomainModel = await rideRepository.UpdateAsync(id, rideDomainModel);

            if (rideDomainModel == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<RideDTO>(rideDomainModel));
        }

        // Delete a Walk by Id
        // DELETE: /api/Rides/{id}
        [Authorize(Roles = "Writer")]
        [HttpDelete]
        [Route("{id:Guid}")]
        //[Authorize(Roles = "Writer")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var deletedRideDomainModel = await rideRepository.DeleteAsync(id);

            if (deletedRideDomainModel == null)
            {
                return NotFound();
            }

            // Map Domain Model to DTO
            return Ok(mapper.Map<RideDTO>(deletedRideDomainModel));
        }

    }
}