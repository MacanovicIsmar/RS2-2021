using Eprodaja.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eprodaja.Services
{
	public class ProizvodServiceold:ProizvodServisold
	{
		private static List<proizvod> Proizvodi;


		static ProizvodServiceold()
		{
			Proizvodi = new List<proizvod>()
			{

				new proizvod
				{
				  Id=0,
				  Name="laptop"


				}
				,
				new proizvod
				{
				Id=1,
				Name="Mis"


				}




			};



		}


		public IEnumerable<proizvod> Get()
		{



			return Proizvodi;
		}

		public proizvod GetById(int Id)
		{


			return Proizvodi.FirstOrDefault(X => X.Id == Id);







		}
		public proizvod Insert(proizvod pro)
		{

			Proizvodi.Add(pro);


			return pro;
		}
		public proizvod Update(int Id, proizvod pro)
		{

			var currentproizvod = Proizvodi.Where(X => X.Id == Id).FirstOrDefault();
			currentproizvod.Name = pro.Name;

			return currentproizvod;
		}


	}
	public class proizvod
	{
		public int Id { get; set; }

		public string Name { get; set; }



	}



}
