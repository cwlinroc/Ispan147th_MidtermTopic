using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class PetSearchDto
	{
		public int? PetID { get; set; }
		public string PetName { get; set;}
		public int? SpeciesID { get; set; }
		public int? BreedID { get; set; }
	}
}
