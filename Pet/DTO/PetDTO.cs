using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.DTO
{
	public class PetDTO
	{
		public int ID { get; set; }
		public int SpeciesId { get; set; }
		public int VarietyId { get; set; }
		public string Name { get; set; }
		public bool Gender { get; set; }
		public int Age { get; set; }
		public string Introduction { get; set; }
		public string Location { get; set; }
	}
}
