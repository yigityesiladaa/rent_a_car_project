using Business.Abstract;
using Entities.Concrete;
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
	public class RentalsController : ControllerBase
	{
		IRentalService _rentalService;

		public RentalsController(IRentalService rentalService)
		{
			_rentalService = rentalService;
		}

		[HttpGet("getAll")]
		public IActionResult GetAll()
		{
			var result = _rentalService.GetAll();

			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}



		[HttpGet("getById")]
		public IActionResult GetByBrandId(int id)
		{
			var result = _rentalService.GetById(id);

			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("getAllByCustomerId")]
		public IActionResult GetAllByCustomerId(int customerId)
		{
			var result = _rentalService.GetAllByCustomerId(customerId);

			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("getAllByCarId")]
		public IActionResult GetAllByCarId(int carId)
		{
			var result = _rentalService.GetAllByCarId(carId);

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
	}
}
