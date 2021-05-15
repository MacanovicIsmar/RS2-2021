using eprodaja.model;
using Eprodaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eprodaja.Controllers
{
	//[ApiController]
	//[Route("[controller]")]


	public class VrstaProizvodaController : BaseReadController<eprodaja.model.VrsteProizvodum,object>
	{
		//private readonly IVrstaProizvodaService service_;


		public VrstaProizvodaController(IVrstaProizvodaService service):base(service)
		{

			


		}




		




	}
}
