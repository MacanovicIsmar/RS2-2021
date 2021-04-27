using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eprodaja.Services
{
	public interface IReadService<T> 
	{
		public IEnumerable<T> Get();

		public T GetById(int Id);
	}
}
