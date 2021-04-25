using AutoMapper;
using eprodaja.model.Requests;
using Eprodaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eprodaja.Services
{
	public class KorisniciService : IKorisniciService
	{
		public eProdajaContext contex { get; set; } //entity framework 
		protected readonly IMapper _mapper;         //automapper 


		public KorisniciService(eProdajaContext contex_, IMapper Maper)
		{
			contex = contex_;
			_mapper = Maper;


		}




		public List<eprodaja.model.Korisnici> Get()
		{
			//mapiranje
			return contex.Korisnicis.ToList().Select(X=> _mapper.Map<eprodaja.model.Korisnici>(X)).ToList();
		}

		public eprodaja.model.Korisnici insert(KorisniciInsertRequest request)
		{
			throw new NotImplementedException();
		}



		//private eprodaja.model.Korisnici converttomodel(Korisnici entity)
		//{

		//	return new eprodaja.model.Korisnici
		//	{
		//		KorisnikId = entity.KorisnikId,
		//		Ime = entity.Ime,
		//		Prezime = entity.Prezime,
		//		KorisnickoIme = entity.KorisnickoIme,
		//		Email = entity.Email,
		//		Telefon = entity.Telefon,



		//	};

		//   }
	}
}
