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


	public class JedinicaMjereController : BaseReadController<eprodaja.model.JedinicaMjere,object>
	{
		


		public JedinicaMjereController(IJedinicaMjereService service):base(service)
		{

			


		}




		




	}
}
