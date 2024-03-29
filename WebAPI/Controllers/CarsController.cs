﻿using Business.Abstract;
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
	public class CarsController : ControllerBase
	{
		ICarService _carService;

		public CarsController(ICarService carService)
		{
			_carService = carService;
		}

		[HttpGet("getAll")]
		public IActionResult GetAll()
		{
			var result = _carService.GetAll();

			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("getCarDetails")]
		public IActionResult GetByBrandId()
		{
			var result = _carService.GetCarDetails();

			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}


		[HttpGet("getByBrandId")]
		public IActionResult GetByBrandId(int id)
		{
			var result = _carService.GetAllByBrandID(id);

			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("getByColorId")]
		public IActionResult GetByColorId(int id)
		{
			var result = _carService.GetAllByColorID(id);

			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpPost("add")]
		public IActionResult Add(Car car)
		{
			var result = _carService.Add(car);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

	}
}
