using AutoMapper;
using eprodaja.model;
using Eprodaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eprodaja.Services
{
	public class JedinicaMjereService : IJedinicaMjereService
	{
		public eProdajaContext contex { get; set; } //entity framework 
		protected readonly IMapper _mapper;         //automapper 


		public JedinicaMjereService(eProdajaContext contex_, IMapper Maper)
		{
			contex = contex_;
			_mapper = Maper;

		}


		public IEnumerable<JedinicaMjere> Get()
		{
			return contex.JediniceMjeres.ToList().Select(X => _mapper.Map<JedinicaMjere>(X)).ToList();
		}

		public JedinicaMjere GetById(int Id)
		{
			var entity = contex.JediniceMjeres.Find(Id);

			return _mapper.Map<JedinicaMjere>(entity);

		}
	}
}
