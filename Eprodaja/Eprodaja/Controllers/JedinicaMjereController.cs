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


	public class JedinicaMjereController : ControllerBase
	{
		private readonly IJedinicaMjereService service_;


		public JedinicaMjereController(IJedinicaMjereService service)
		{

			service_ = service;


		}




		[HttpGet]

		public IEnumerable<eprodaja.model.JedinicaMjere> Get()
		{

			return service_.Get();
		}
		
		[HttpGet("{Id}")]
		
		public JedinicaMjere GetById(int Id)
		{


			return service_.GetById(Id);

		}




	}
}
