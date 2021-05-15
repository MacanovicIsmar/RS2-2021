using System;
using System.Collections.Generic;
using System.Text;

namespace eprodaja.model
{
	public class ProizvodiSearchObject
	{
		public string Naziv { get; set; }
		public int? VrstaId { get; set; }
		public int? JedinicaMjereId { get; set; }

		public bool? includejedinicamjere { get; set;}

		public string[] IncludeList{ get; set; }


	}
}
