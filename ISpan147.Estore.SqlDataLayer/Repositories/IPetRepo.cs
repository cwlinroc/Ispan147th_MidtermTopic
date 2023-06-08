using ISpan147.Estore.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public interface IPetRepo
	{
		PetDto GetByID(int id);
		PetDto GetByName(string name);
		int Create(PetDto dto);
		int Update(PetDto dto);
		int Delete(int petID);
		List<SpeciesDto> SearchSpecies(int? speciesID);
		List<BreedDto> SearchBreed(int? breedID);
	}
}
