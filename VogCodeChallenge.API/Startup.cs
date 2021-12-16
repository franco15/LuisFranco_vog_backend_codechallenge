using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Data;
using VogCodeChallenge.API.Interfaces;
using VogCodeChallenge.API.Services;

namespace VogCodeChallenge.API
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			// suppose we are using sql server
			string cs = Configuration.GetConnectionString("DefaultConnection");
			if (string.IsNullOrWhiteSpace(cs))
				services.AddDbContext<VogDbContext>(o => o.UseInMemoryDatabase(databaseName: "Vog"));
			else
				services.AddDbContext<VogDbContext>(o =>
				{
					o.UseSqlServer(cs);
				});
			services.AddControllers().AddNewtonsoftJson(o => o.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
			services.AddScoped<IDbInit, DbInit>();
			services.AddScoped<IEmployeesService, EmployeesService>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IDbInit init)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});

			init.Initialize();
		}
	}
}
