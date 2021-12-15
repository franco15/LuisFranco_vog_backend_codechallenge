using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Models
{
	public class DepartmentModel
	{
		public DepartmentModel(int _id, string _name, Guid _address)
		{
			Id = _id;
			Name = _name;
			Address = _address;
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public Guid Address { get; set; }
	}
}
