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
using System.Xml.Linq;

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
				int species = rng.RandomIntBetween(1, 4);
				repo.CreatePet(new PetDto
				{
					SpeciesID = species,
					BreedID = rng.RandomFrom(breedIDs[species - 1]),
					PetName = rng.RandomPetName(),
					Gender = rng.RandomBool(),
					Age = rng.RandomIntBetween(0, 5),
					Location = rng.RandomAddress()
				});
			}
		}



		public void CreateRandomMerchandise(int total)
		{
			var rng = new RandomGenerator();
			var repo = new MassInsertRepository();

			for (int i = 0; i < total; i++)
			{
				repo.CreateMerchandise(rng.RandomMerchandise());
			}
		}


		public void CreateRandomThemeAndCommon(int total)
		{
			var rng = new RandomGenerator();
			var repo = new MassInsertRepository();

			for (int i = 0; i < total; i++)
			{
				var dt = DateTime.Now.AddDays(-rng.RandomIntBetween(30, 365))
					.AddMinutes(rng.RandomIntBetween(0, 1440));
				int themeID = repo.CreateTheme(new ThemeDto
				{
					ThemeName = rng.RandomEnString(5, 11),
					ThemeDateTime = dt,
					ThemeContext = String.Concat(Enumerable
						.Repeat(rng.RandomSentance(), rng.RandomIntBetween(1, 3)))
				});
				if (rng.RandomChance(70))
				{
					for (int j = 0; j < rng.RandomIntBetween(2, 13); j++)
					{
						dt = dt.AddMinutes(rng.RandomIntBetween(0, 5000));
						repo.CreateCommon(new CommonDto
						{
							CommonName = rng.RandomEnString(5, 11),
							CommonTime = dt,
							ThemeID = themeID,
							CommonContext = String.Concat(Enumerable
						.Repeat(rng.RandomSentance(), rng.RandomIntBetween(1, 3)))
						});
					}
				}
			}
		}




		public void CreateRandomOrderAndOrderList(int total)
		{
			var rng = new RandomGenerator();
			var repo = new MassInsertRepository();

			var memberIDs = repo.GetAllMemberID();
			var merchandiseIDs = repo.GetAllMerchandiseID();

			for (int i = 0; i < total; i++)
			{
				int orderID = repo.CreateOrder(new OrderDto
				{
					MemberID = rng.RandomFrom(memberIDs),
					PaymentMethod = rng.RandomIntBetween(0, 3),
					Payed = rng.RandomBool()
				});

				for(int j = 0;  j < rng.RandomIntBetween(1, 15); j++)
				{
					repo.CreateOrderList(new OrderListDto
					{
						OrderID = orderID,
						MerchandiseID = rng.RandomFrom(merchandiseIDs),
						Quantity = rng.RandomIntBetween(1, 15)
					});
				}
			}
		}

		public void CreateRandomAdopt(int total)
		{
			var rng = new RandomGenerator();
			var repo = new MassInsertRepository();

			var memberIDs = repo.GetAllMemberID();
			var petIDs = repo.GetAllPetID();

			for (int i = 0; i < total; i++)
			{
				repo.CreateAdopt(new AdoptDto
				{
					PetID = rng.RandomFrom(petIDs),
					MemberID = rng.RandomFrom(memberIDs),
					ApplicationTime = DateTime.Now.AddDays(rng.RandomIntBetween(-365, -10))
						.AddMinutes(rng.RandomIntBetween(0, 1440))
				});
			}
		}

	}
}
