using Eprodaja.Filters;
using Eprodaja.Models;
using Eprodaja.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eprodaja
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


			//paket automapper ismar 
			services.AddAutoMapper(typeof(Startup));
			services.AddControllersWithViews();


			//dodajemo error filter /ismar
			services.AddControllers(x=> 
			{

				x.Filters.Add<Errorfilter>();
			
			
			
			});






			// nuget paket addswaggergen 
			services.AddSwaggerGen();

			//ismar dodano zive dok traje request
			//services.AddTransient<ProizvodServis, ProizvodService>();
			//services.AddScoped<ProizvodService, ProizvodServis>;
			//transijent svaki resolve kroz konstruktor dobija novu instancu 
			//scope dok je "request je ziv" 
			//singletone -za sve requeste ista instanca 


			//ismar dodano od mene
			services.AddDbContext<eProdajaContext>(options =>
				options.UseSqlServer(Configuration.GetConnectionString("DockerVM")));


			//ismar dodano od mene dependecy injection
			services.AddScoped<IKorisniciService, KorisniciService>();


		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{

			// Enable middleware to serve generated Swagger as a JSON endpoint.
			app.UseSwagger();

			// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
			// specifying the Swagger JSON endpoint.
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
			});







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
		}
	}
}
