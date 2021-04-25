using eprodaja.model.Requests;
using Eprodaja.Models;
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


	public class KorisnikController : ControllerBase
	{


		private readonly IKorisniciService service_;


		public KorisnikController(IKorisniciService service)
		{

			service_ = service;
		
		
		}


		[HttpGet]

		public IEnumerable<eprodaja.model.Korisnici> Get()
		{

			return service_.Get();
		}

		[HttpPost]
		public eprodaja.model.Korisnici insert([FromBody]KorisniciInsertRequest requestkorisnici)
		{

			return service_.insert(requestkorisnici);


		}


	}
}
