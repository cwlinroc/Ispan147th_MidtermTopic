using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Repositories
{
	public class OrderListRepositoryLinq : IOrderListRepositoy
	{
		public int Create(OrderListDto dto)
		{
			if (dto == null) throw new ArgumentNullException(nameof(dto));
			var db = new AppDbContext();
			var obj = dto.ToEF();
			db.OrderLists.Add(obj);
			db.SaveChanges();
			return obj.OrderListID;
		}

		public int Delete(int orderListID)
		{
			var db = new AppDbContext();
			var obj = db.OrderLists.Where(o => o.OrderListID == orderListID).FirstOrDefault();
			if (obj == null) return 0;
			db.OrderLists.Remove(obj);
			db.SaveChanges();
			return obj.OrderListID;
		}

		public OrderListDto Get(int orderListID)
		{
			var db = new AppDbContext();
			var obj = db.OrderLists.Where(o => o.OrderListID == orderListID).FirstOrDefault();
			if (db == null) return null;
			return obj.ToDto();
		}

		public List<OrderListGridDto> Search(
			int? id = null,
			int? orderID = null,
			int? merchandiseID = null,
			int? quantity = null)
		{
			var db = new AppDbContext();

			var query = (
				from t1 in db.OrderLists
				join t2 in db.Merchandises on t1.MerchandiseID equals t2.MerchandiseID
				select new OrderListGridDto()
				{
					OrderListID = t1.OrderListID,
					MerchandiseID = t1.MerchandiseID,
					MerchandiseName = t2.MerchandiseName,
					OrderID = t1.OrderID,
					Quantity = t1.Quantity
				}
				);

			if (id != null) query = query.Where(o => o.OrderListID == id);
			if (orderID != null) query = query.Where(o => o.OrderID == orderID);
			if (merchandiseID != null) query = query.Where(o => o.MerchandiseID == merchandiseID);
			if (quantity != null) query = query.Where(o => o.Quantity == quantity);

			return query.ToList();
		}

		public int Update(OrderListDto dto)
		{
			var db = new AppDbContext();
			var obj = db.OrderLists.Where(o => o.OrderListID == dto.OrderListID).FirstOrDefault();
			if (obj == null) return 0;
			obj.ChangeByDto(dto);
			db.SaveChanges();
			return obj.OrderListID;
		}
				
	}
}
