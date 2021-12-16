using AutoFixture;
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

		public async Task Initialize()
		{
			if (_db.Departments.Any())
				return;
			var fixture = new Fixture();
			var departments = fixture.Build<Department>()
				.Without(x => x.Id)
				.CreateMany(2);
			_db.Departments.AddRange(departments);
			//await _db.SaveChangesAsync();
			var employees = departments.SelectMany(x => fixture.Build<Employee>()
				.With(y => y.DepartmentId, x.Id).CreateMany(3));
			_db.Employees.AddRange(employees);
			await _db.SaveChangesAsync();
		}
	}
}
