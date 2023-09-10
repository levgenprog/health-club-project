﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using health_club.API.Models.DTO;
using Microsoft.AspNetCore.Identity;
using health_club.API.Repositories;

namespace health_club.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly UserManager<IdentityUser> userManager;
		private readonly ITokenRepository tokenRepository;

        public AuthController(UserManager<IdentityUser> userManager, ITokenRepository tokenRepository)
		{
			this.userManager = userManager;
			this.tokenRepository = tokenRepository;

		}

		// POST: /api/Auth/Register
		[HttpPost]
		[Route("Register")]
		public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto)
		{
			var identityUser = new IdentityUser
			{
				UserName = registerRequestDto.Username,
				Email = registerRequestDto.Username
			};

			var identityResult = await userManager.CreateAsync(identityUser, registerRequestDto.Password);

			if  (identityResult.Succeeded)
			{
				if (registerRequestDto.Roles != null && registerRequestDto.Roles.Any())
				{
                    identityResult = await userManager.AddToRolesAsync(identityUser, registerRequestDto.Roles);

					if (identityResult.Succeeded)
					{
						return Ok("User was registered! Please login.");
					}
                }				
			}

			return BadRequest("Something went wrong");
		}

		// POST: /api/Auth/Login
		[HttpPost]
		[Route("Login")]
		public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequestDto)
		{
			var user = await userManager.FindByEmailAsync(loginRequestDto.Username);

			if (user != null)
			{
				var checkPasswordResult = await userManager.CheckPasswordAsync(user, loginRequestDto.Password);

				if (checkPasswordResult)
				{
					// Get Roles for this user
					var roles = await userManager.GetRolesAsync(user);

					if (roles != null)
					{
						// Create Token
						var jwtToken = tokenRepository.CreateJWTToken(user, roles.ToList());

						var respomse = new LoginResponseDto
						{
							JwtToken = jwtToken
						};

						return Ok(jwtToken);
                    }
				}
			}

			return BadRequest("Username or password is incorrect");
		}
		
	}
}

