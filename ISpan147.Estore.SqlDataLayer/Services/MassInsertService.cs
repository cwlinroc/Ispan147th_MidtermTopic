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
					NickName = (rng.RandomChance(80)) ? rng.RandomPetName().Substring(0, 2) : null,
					DateOfBirth = rng.RandomBirthDate(),
					Gender = rng.RandomBool(),
					Account = rng.RandomEnString(),
					Password = rng.RandomEnString().GetSaltedSha256(),
					Phone = rng.RandomPhone(),
					Address = (rng.RandomChance(70)) ? rng.RandomAddress() : null,
					Email = rng.RandomEmail(),
					//Avatar = (rng.RandomChance(70)) ? rng.RandomEnString() + ".jpg" : null
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


		public void CreateRandomForumAccount(int chance)
		{
			if (chance <= 0) return;
			if (chance > 100) chance = 100;

			var rng = new RandomGenerator();
			var repo = new MassInsertRepository();

			var dtos = repo.GetAllMemberDtos();

			foreach (var dto in dtos)
			{
				if (dto.ForumAccountID == null && rng.RandomChance(chance))
				{
					int forumID = repo.CreateForumAccount(new ForumAccountDto
					{
						ForumAccountName = (string.IsNullOrEmpty(dto.NickName)) ? dto.MemberName : dto.NickName
					});
					repo.UpdateForumAccountID(dto.MemberID, forumID);
				}
			}
		}


		public void CreateRandomThemeAndCommon(int total)
		{
			var rng = new RandomGenerator();
			var repo = new MassInsertRepository();

			var forumIDs = repo.GetAllForumAccountID();

			for (int i = 0; i < total; i++)
			{
				var dt = DateTime.Now.AddDays(-rng.RandomIntBetween(30, 365))
					.AddMinutes(rng.RandomIntBetween(0, 1440));
				int themeID = repo.CreateTheme(new ThemeDto
				{
					ThemeName = rng.RandomEnString(5, 11),
					ThemeDateTime = dt,
					ThemeContext = String.Concat(Enumerable
						.Repeat(rng.RandomSentance(), rng.RandomIntBetween(1, 3))),
					ForumAccountID = rng.RandomFrom(forumIDs)
				});
				if (rng.RandomChance(70))
				{
					for (int j = 0; j < rng.RandomIntBetween(2, 13); j++)
					{
						dt = dt.AddMinutes(rng.RandomIntBetween(0, 5000));
						repo.CreateCommon(new CommentDto
						{
							CommentTime = dt,
							ThemeID = themeID,
							CommentContext = String.Concat(Enumerable
						.Repeat(rng.RandomSentance(), rng.RandomIntBetween(1, 3))),
							ForumAccountID = rng.RandomFrom(forumIDs)
						});
					}
				}
			}
		}

		//todo [君韋] 隨機訂單金額過高
		public void CreateRandomOrderAndOrderList(int total)
		{
			var rng = new RandomGenerator();
			var repo = new MassInsertRepository();

			var memberIDs = repo.GetAllMemberID();
			var merchandiseIDs = repo.GetAllMerchandiseID();

			for (int i = 0; i < total; i++)
			{
				var dto = new OrderDto
				{
					MemberID = rng.RandomFrom(memberIDs),
					PaymentMethod = rng.RandomIntBetween(0, 3),
					Payed = rng.RandomBool(),
					PurchaseTime = DateTime.Now.AddDays(rng.RandomIntBetween(-365, -10))
						.AddMinutes(rng.RandomIntBetween(0, 1440)),
				};

				int orderID = repo.CreateOrder(dto);

				int scale = rng.RandomIntByWeight(0, 2, 5, 5, 3, 2, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1);

				for (int j = 0; j < rng.RandomIntBetween(1, scale); j++)
				{
					repo.CreateOrderList(new OrderListDto
					{
						OrderID = orderID,
						MerchandiseID = rng.RandomFrom(merchandiseIDs),
						Quantity = rng.RandomIntBetween(1, scale)
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

		public void OrganizeAllPayments()
		{
			var rng = new RandomGenerator();
			var repo = new MassInsertRepository();

			var ids = repo.GetAllOrderID();

			foreach (int id in ids)
			{
				bool calculated = rng.RandomChance(90);

				var dto = new OrderDto
				{
					OrderID = id,
					Payed = calculated && rng.RandomChance(95)
				};

				if (calculated)
				{
					dto.PaymentAmount = repo.GetTotalPrice(id);

					if (rng.RandomChance(50))
					{
						dto.PaymentAmount = dto.PaymentAmount * rng.RandomIntBetween(80, 100) / 100;
					}
				}
				repo.UpdateOrder(dto);
			}
		}
	}
}
