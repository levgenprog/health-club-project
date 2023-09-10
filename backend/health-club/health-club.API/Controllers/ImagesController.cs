using health_club.API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using health_club.API.Models.Domain;
using health_club.API.Repositories;

namespace health_club.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]

	public class ImagesController : ControllerBase
	{
		private readonly IImageRepository imageRepository;


        public ImagesController(IImageRepository imageRepository)
		{
			this.imageRepository = imageRepository;
		}

		// POST: /api/Images/Upload
		[HttpPost]
		[Route("Upload")]
		public async Task<IActionResult> Upload([FromForm] ImageUploadRequestDto request)
		{
			ValidateFileUpload(request);

			if (ModelState.IsValid)
			{
				// Convert Dto to Domain model
				var imageDomainModel = new Image
				{
					File = request.File,
					FileExtension = Path.GetExtension(request.File.FileName),
					FileSizeInBytes = request.File.Length,
					FileName = request.FileName,
					FileDescription = request.FileDescription,
				};

				// Use repository to upload image
				await imageRepository.Upload(imageDomainModel);

				return Ok(imageDomainModel);
			}

			return BadRequest(ModelState);
		}


		private void ValidateFileUpload(ImageUploadRequestDto request)
		{
			var allowedExtensions = new string[] { ".jpg", ".jpeg", ".png", ".JPG" };

			if (!allowedExtensions.Contains(Path.GetExtension(request.File.FileName)))
			{
				ModelState.AddModelError("file", "Unsupported file extension");
			}

			// 10 megabytes
			if (request.File.Length > 10485760)
			{
				ModelState.AddModelError("file", "File size more than 10mb, please upload a smaller size file.");
			}
		}
	}
}

