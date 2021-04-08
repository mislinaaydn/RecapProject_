using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            Thread.Sleep(1000);

            var result = _rentalService.GetRentalDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getcardetail")]
        public IActionResult GetCarDetailDtos()
        {

            var result = _rentalService.GetRentalDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getrentaldetailbycarId")]
        public IActionResult GetByCarId(int carId)
        {
            var result = _rentalService.GetByCarId(carId);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }



    }

    }