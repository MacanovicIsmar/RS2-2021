using AutoMapper;
using eprodaja.model;
using Eprodaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eprodaja.Services
{
	public class VrstaProizvodaService : BaseReadService<eprodaja.model.VrsteProizvodum,Models.VrsteProizvodum>
	{
		public eProdajaContext contex { get; set; } //entity framework 
		protected readonly IMapper _mapper;         //automapper 


		public VrstaProizvodaService(eProdajaContext contex_, IMapper Maper)
		{
			contex = contex_;
			_mapper = Maper;

		}

		
	}
}
