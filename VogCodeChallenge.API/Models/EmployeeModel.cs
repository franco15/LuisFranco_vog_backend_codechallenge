using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Models
{
	public class EmployeeModel
	{
		public EmployeeModel(int _id, string _firstName, string _lastName, string _jobTitle, string _address)
		{
			Id = _id;
			FirstName = _firstName;
			LastName = _lastName;
			JobTitle = _jobTitle;
			Address = _address;
		}

		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string JobTitle { get; set; }
		public string Address { get; set; }
	}
}
