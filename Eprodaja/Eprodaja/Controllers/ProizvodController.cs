using Eprodaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eprodaja.Controllers
{
	// ova klasa moze upravljati sa requestima
	[ApiController]
	[Route("[controller]")]


	public class ProizvodController : ControllerBase
	{
		
		public ProizvodServis proizvodservis { get; set;}

		public ProizvodController(ProizvodServis proizvodservis_)
		{

			proizvodservis = proizvodservis_;
		
		
		
		}


		[HttpGet]
		public IEnumerable<proizvod> Get()
		{



			return proizvodservis.Get();
		}



		[HttpGet("{Id}")]

		public proizvod GetById(int Id)
		{


			return proizvodservis.GetById(Id);







		}

		[HttpPost]
		public proizvod Insert(proizvod pro)
		{

			proizvodservis.Insert(pro);


			return pro;
		}

		[HttpPut("{Id}")]

		public proizvod Update(int Id, proizvod pro)
		{

			return proizvodservis.Update(Id,pro);
			
		}










	}

	



}
