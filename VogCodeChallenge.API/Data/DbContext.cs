using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Data
{
	public class VogDbContext : DbContext
	{
		public VogDbContext(DbContextOptions<VogDbContext> options) : base(options) { }

		public DbSet<Entities.Department> Departments { get; set; }
		public DbSet<Entities.Employee> Employees { get; set; }
	}
}
