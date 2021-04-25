using eprodaja.model.Requests;
using Eprodaja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eprodaja.Services
{
	public interface IKorisniciService
	{

		public List<eprodaja.model.Korisnici> Get();

		eprodaja.model.Korisnici insert(KorisniciInsertRequest request);
	}
}
