using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Entities;

namespace VogCodeChallenge.API.Interfaces
{
	public interface IEmployeesService
	{
		IEnumerable<Employee> GetAll();
		IList<Employee> ListAll();
		IEnumerable<Employee> GetAllByDepartmentId(Guid departmentId);
	}
}
