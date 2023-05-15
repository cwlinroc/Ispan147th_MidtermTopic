using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMidtermTopic.Model
{
    public class CMerchandiseOrder
    {
        public List<Merchandise> list = new List<Merchandise>();
        public string orderId { get; set; }
        public bool payed { get; set; }
        public string customerId { get; set; }
        public int paymentMethod { get; set; }
        public class Merchandise : IMerchandise
        {
            public string id { get; set; }
            public string name { get; set; }
            public string category { get; set; }
            public int price { get; set; }
            public int amount { get; set; }
            public int quantity { get; set; }
        }
        public int totalPrice
        {
            get => list.Sum(o => o.price * o.quantity);           
        }
    }
}


