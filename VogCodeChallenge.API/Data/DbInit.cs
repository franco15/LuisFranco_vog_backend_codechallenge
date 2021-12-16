using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Entities;
using VogCodeChallenge.API.Interfaces;

namespace VogCodeChallenge.API.Data
{
	public class DbInit : IDbInit
	{
		private readonly VogDbContext _db;

		public DbInit(VogDbContext db)
		{
			_db = db;
		}

		public void Initialize()
		{
			if (_db.Departments.Any())
				return;
			var departmentsFaker = new Faker<Department>()
				.RuleFor(x => x.Name, f => f.Name.Random.Word())
				.RuleFor(x => x.Address, f => f.Address.Random.Words())
				.Ignore(x => x.Id);
			var departments = departmentsFaker.Generate(2);
			_db.Departments.AddRange(departments);
			var employeesFaker = new Faker<Employee>()
				.RuleFor(x => x.FirstName, f => f.Name.FirstName())
				.RuleFor(x => x.LastName, f => f.Name.LastName())
				.RuleFor(x => x.JobTitle, f => f.Name.Random.Word())
				.RuleFor(x => x.Address, f => f.Address.Random.Words());
			var employees = departments.SelectMany(x => employeesFaker.RuleFor(e => e.DepartmentId, x.Id).Generate(3)).ToList();
			_db.Employees.AddRange(employees);
			_db.SaveChangesAsync();
		}
	}
}
