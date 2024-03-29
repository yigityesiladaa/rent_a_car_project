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
	public class CustomersController : ControllerBase
	{
		ICustomerService _customerService;

		public CustomersController(ICustomerService customerService)
		{
			_customerService = customerService;
		}

		[HttpGet("getAll")]
		public IActionResult GetAll()
		{
			var result = _customerService.GetAll();

			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}



		[HttpGet("getById")]
		public IActionResult GetByBrandId(int id)
		{
			var result = _customerService.GetById(id);

			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}


		[HttpPost("add")]
		public IActionResult Add(Customer customer)
		{
			var result = _customerService.Add(customer);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}
