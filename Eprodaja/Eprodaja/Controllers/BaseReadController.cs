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



	public class BaseReadController<T,Tsearch> : ControllerBase where T:class where Tsearch:class
	{


		protected readonly IReadService<T, Tsearch> service_;


		public BaseReadController(IReadService<T, Tsearch> service)
		{

			service_ = service;


		}




		[HttpGet]

		public virtual IEnumerable<T> Get([FromQuery] Tsearch search)
		{

			return service_.Get(search);
		}

		[HttpGet("{Id}")]

		public virtual T GetById(int Id)
		{


			return service_.GetById(Id);

		}
	}
}
