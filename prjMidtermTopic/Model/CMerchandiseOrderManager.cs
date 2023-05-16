using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace prjMidtermTopic.Model
{
	public class CMerchandiseOrderManager
	{
		private List<MerchandisOrderPto> orders= new List<MerchandisOrderPto>();
		public void load()
		{
			orders.Add(new MerchandisOrderPto()
			{
				orderID = 10001,
				customerID = "56421",
				paymentMethod = 1,
				payed = true
			});
			orders.Add(new MerchandisOrderPto()
			{
				orderID = 10002,
				customerID = "46521",
				paymentMethod = 1,
				payed = true
			});
			orders.Add(new MerchandisOrderPto()
			{
				orderID = 10003,
				customerID = "94267",
				paymentMethod = 2,
				payed = true
			});
			orders.Add(new MerchandisOrderPto()
			{
				orderID = 10004,
				customerID = "46521",
				paymentMethod = 3,
				payed = true
			});
			orders.Add(new MerchandisOrderPto()
			{
				orderID = 10005,
				customerID = "46521",
				paymentMethod = 2,
				payed = false
			});
		}

		public List<MerchandisOrderPto> search(int? orderID, string customerID)
		{
			var suborders = new List<MerchandisOrderPto>(orders);
			if (orderID.HasValue)
			{
				suborders = suborders.FindAll(o => o.orderID == orderID.Value);
			}
			if (!string.IsNullOrEmpty(customerID))
			{
				suborders = suborders.FindAll(o => o.customerID == customerID);
			}
			return suborders;
		}
				
		public void delete(int orderID)
		{
			var order = orders.FirstOrDefault(o => o.orderID == orderID);
			if(order!=null)orders.Remove(order);
		}

		public void add(int orderID, string customerID,
			int paymentMethod, bool payed )
		{
			orders.Add(new MerchandisOrderPto()
			{
				orderID = orderID,
				customerID = customerID,
				paymentMethod = paymentMethod,
				payed = payed
			});
		}

	}
}
