using AutoMapper;
using eprodaja.model;
using Eprodaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eprodaja.Services
{
	public class JedinicaMjereService :BaseReadService<eprodaja.model.JedinicaMjere,Models.JediniceMjere,object> 
		,IJedinicaMjereService
	{
		


		public JedinicaMjereService(eProdajaContext contex_, IMapper Maper):base(contex_,Maper)
		{
			

		}

		
		
	}
}
