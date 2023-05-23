using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.ExtMethods;
using ISpan147.Estore.SqlDataLayer.Repositories;
using ISpan147.Estore.SqlDataLayer.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Services
{
	public class MassInsertService
	{
		public void CreateRandomMembers(int total)
		{
			var rng = new RandomGenerator();
			var repo = new MassInsertRepository();

			for (int i = 0; i < total; i++)
			{
				repo.CreateMember(new MemberDto
				{
					MemberName = rng.RandomName(),
					DateOfBirth = rng.RandomBirthDate(),
					Gender = rng.RandomBool(),
					Account = rng.RandomEnString(),
					Password = rng.RandomEnString().GetSaltedSha256(),
					Phone = rng.RandomPhone(),
					Address = rng.RandomAddress(),
					Email = rng.RandomEmail(),
					Avatar = rng.RandomEnString() + ".jpg"
				});
			}
		}

		public void CreateRandomPets(int total)
		{
			var rng = new RandomGenerator();
			var repo = new MassInsertRepository();


			List<List<int>> breedIDs = new List<List<int>>();

			for (int i = 1; i <= 4; i++)
			{
				breedIDs.Add(repo.GetBreedIDs(i).ToList());
			}


			for (int i = 0; i < total; i++)
			{
				int species = rng.RandonIntBetween(1, 4);
				repo.CreatePet(new PetDto
				{
					SpeciesID = species,
					BreedID = rng.RandomFrom(breedIDs[species - 1]),
					PetName = rng.RandomPetName(),
					Gender = rng.RandomBool(),
					Age = rng.RandonIntBetween(0, 5),
					Location = rng.RandomAddress()
				});
			}
		}



	}
}
