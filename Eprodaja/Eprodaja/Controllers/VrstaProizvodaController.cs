using eprodaja.model;
using Eprodaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eprodaja.Controllers
{
	[ApiController]
	[Route("[controller]")]


	public class VrstaProizvodaController : ControllerBase
	{
		private readonly IVrstaProizvodaService service_;


		public VrstaProizvodaController(IVrstaProizvodaService service)
		{

			service_ = service;


		}




		[HttpGet]

		public IEnumerable<eprodaja.model.VrsteProizvodum> Get()
		{

			return service_.Get();
		}
		
		[HttpGet("{Id}")]
		
		public VrsteProizvodum GetById(int Id)
		{


			return service_.GetById(Id);

		}




	}
}
