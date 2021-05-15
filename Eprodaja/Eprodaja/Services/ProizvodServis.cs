using AutoMapper;
using eprodaja.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eprodaja.Services
{
	public class ProizvodServis :BaseReadService<eprodaja.model.Proizvodi,Models.Proizvodi,eprodaja.model.ProizvodiSearchObject>,
		IProizvodeServis
	{
		public ProizvodServis(Models.eProdajaContext contex ,IMapper mapper):base(contex,mapper)
		{ 
		
		
		
		}

		public override IEnumerable<Proizvodi> Get(ProizvodiSearchObject search = null)
		{
			var entity = contex.Set<Models.Proizvodi>().AsQueryable();

			//never do this 
			//entity=entity.ToList()



			if (string.IsNullOrWhiteSpace(search?.Naziv))
			{

				entity = entity.Where(X => X.Naziv.Contains(search.Naziv));
			
			}
			if (search.JedinicaMjereId.HasValue)
			{

				entity = entity.Where(X => X.JedinicaMjereId == search.JedinicaMjereId);

			}
			if (search.VrstaId.HasValue)
			{

				entity = entity.Where(X => X.VrstaId == search.VrstaId);

			}
			if (search?.includejedinicamjere==true)
			{

				entity = entity.Include("JedinicaMjere");
			
			
			}
			if (search?.IncludeList.Length> 0)
			{

				foreach (var item in search.IncludeList)
				{

					entity = entity.Include(item);
				}
			
			
			
			}





			var list = entity.ToList();


			return _mapper.Map<List<eprodaja.model.Proizvodi>>(list);
		}



	}
}
