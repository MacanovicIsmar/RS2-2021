using AutoMapper;
using eprodaja.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Eprodaja.Maping
{
	public class EprodajaProfil:Profile
	{
		public EprodajaProfil()
		{
			CreateMap<Models.Korisnici, eprodaja.model.Korisnici>();
		}


	}
}
