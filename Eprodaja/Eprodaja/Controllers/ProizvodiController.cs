using Eprodaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eprodaja.Controllers
{
	public class ProizvodiController : BaseReadController<eprodaja.model.Proizvodi,eprodaja.model.ProizvodiSearchObject>
	{
		public ProizvodiController(IProizvodeServis service):base(service)
		{ 
		
		
		
		}


	}
}
