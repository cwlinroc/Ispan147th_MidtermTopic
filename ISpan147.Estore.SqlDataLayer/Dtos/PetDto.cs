using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class PetDto
	{
        public int PetID { get; set; }
        public int SpeciesID { get; set; }
        public int BreedID { get; set; }
        public string PetName { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
		public string PetAvatar { get; set; }
	}
}
