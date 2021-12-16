using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Data;
using VogCodeChallenge.API.Interfaces;

namespace VogCodeChallenge.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class EmployeesController : ControllerBase
	{

		private readonly VogDbContext _db;
		public readonly IEmployeesService _service;

		public EmployeesController(VogDbContext db, IEmployeesService service)
		{
			_db = db;
			_service = service;
		}

		[HttpGet]
		public IActionResult Get()
		{
			var employees = _service.GetAll();
			return Ok(employees);
		}

		[HttpGet("department/{departmentId}")]
		public IActionResult GetAllByDepartmentId(Guid departmentId)
		{
			var employees = _service.GetAllByDepartmentId(departmentId);
			return Ok(employees);
		}
	}
}
