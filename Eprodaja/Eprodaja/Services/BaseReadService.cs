using AutoMapper;
using Eprodaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eprodaja.Services
{
	public class BaseReadService<T,TDB> : IReadService<T> where T : class where TDB :class
	{
		public eProdajaContext contex { get; set; } //entity framework 
		protected readonly IMapper _mapper;         //automapper 


		public BaseReadService(eProdajaContext contex_, IMapper Maper)
		{
			contex = contex_;
			_mapper = Maper;

		}




		public IEnumerable<T> Get()
		{


			var entity = contex.Set<TDB>();

			var list = entity.ToList();


			return _mapper.Map<List<T>>(list);
		}

		public T GetById(int Id)
		{
			var set = contex.Set<TDB>();

			var entity = set.Find(Id);

			return _mapper.Map<T>(entity);
		}
	}
}
