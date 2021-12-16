using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Entities
{
	public class Department : Entity
	{
		public string Name { get; set; }
		public string Address { get; set; }
		public virtual List<Employee> Employees { get; set; }
	}
}
