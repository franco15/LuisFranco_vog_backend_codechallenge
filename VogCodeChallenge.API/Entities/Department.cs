using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Entities
{
	public class Department
	{
		public Department(int _id, string _name, Guid _address)
		{
			Id = _id;
			Name = _name;
			Address = _address;
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public Guid Address { get; set; }
		public virtual List<Employee> Employees { get; set; }
	}
}
