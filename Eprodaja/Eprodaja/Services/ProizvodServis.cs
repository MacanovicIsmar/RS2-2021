using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eprodaja.Services
{
	public interface ProizvodServis
	{
		public IEnumerable<proizvod> Get();
		public proizvod GetById(int Id);
		public proizvod Insert(proizvod pro);
		public proizvod Update(int Id, proizvod pro);




	}
}
