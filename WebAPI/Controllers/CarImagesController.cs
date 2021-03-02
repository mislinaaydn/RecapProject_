using Business.Abstract;
using Core.Utilities.Helpers.FileHelper;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        private ICarImageService _carImageService;

        private IFileHelper _file;
        private IWebHostEnvironment _environment;
        public CarImagesController(ICarImageService carImageService, IFileHelper fileHelper, IWebHostEnvironment environment)
        {
            _carImageService = carImageService;
            _file = fileHelper;
            _environment = environment;
        }
        [HttpPost("postadd")]
        public IActionResult PostAdd([FromForm] IFormFile file, [FromForm] CarImage carImage)
        {
            var resultsGetById = _carImageService.GetById(carImage.CarId);
            if (resultsGetById.Data.Count <= 5)
            {
                var path = _environment.WebRootPath;
                string name = file.FileName;
                var newImage = _file.Upload(file, path, "Image");
                if (newImage.Success)
                {
                    carImage.ImagePath = newImage.Data;
                    var result2 = _carImageService.Add(carImage);
                    return Ok(result2.Message);
                }
                return BadRequest(newImage);
            }
            return BadRequest("bu arabaya ait maximum görüntü sayısına ulastınız");


        }
        [HttpDelete("deleted")]
        public IActionResult Deleted(int Id)
        {
            var path = _environment.WebRootPath;
            var result = _carImageService.Delete(path, Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
