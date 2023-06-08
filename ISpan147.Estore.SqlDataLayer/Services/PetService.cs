using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Services
{
	public class PetService
	{
		private readonly IPetRepo _repo;

		public PetService(IPetRepo repo)
		{
			_repo = repo;
		}

		public int Create(PetDto dto)
		{
			var dtoInDb = _repo.GetByName(dto.PetName);
			if(dtoInDb != null)
			{
				throw new Exception("此寵物名稱已經被使用，新增無效");
			}
			
			//新增一筆資料
			int newID = _repo.Create(dto);

			return newID;
		}

		public int Update(PetDto dto)
		{
			//var dtoInDb = _repo.GetByName(dto.PetName);
			//if(dtoInDb != null && dtoInDb.PetID != dto.PetID)
			//{
			//	throw new Exception("此寵物名稱已經被使用，無法修改");
			//}
			
			//更新資料
			int rows = _repo.Update(dto);

			return rows;
		}

		public int Delete(int petID)
		{
			return _repo.Delete(petID);
		}

		public List<SpeciesDto> SearchSpescies(int? speciesID = null)
		{
			return _repo.SearchSpecies(speciesID);
		}

		public List<BreedDto> SearchBreed(int? breedID = null)
		{
			return _repo.SearchBreed(breedID);
		}
	}
}
