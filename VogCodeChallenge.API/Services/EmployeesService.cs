using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Data;
using VogCodeChallenge.API.Entities;
using VogCodeChallenge.API.Interfaces;

namespace VogCodeChallenge.API.Services
{
	public class EmployeesService : IEmployeesService
	{
		public readonly VogDbContext _db;

		public EmployeesService(VogDbContext db)
		{
			_db = db;
		}

		public IEnumerable<Employee> GetAll()
		{
			return _db.Employees.AsEnumerable();
		}

		public IList<Employee> ListAll()
		{
			return _db.Employees.ToList();
		}

		public IEnumerable<Employee> GetAllByDepartmentId(Guid departmentId)
		{
			return _db.Employees.Where(x => x.DepartmentId == departmentId).AsEnumerable();
		}
	}
}
