using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMidtermTopic.Model
{
    interface IMerchandise
    {
        string id { get; set; }
        string name { get; set; }
        string category { get; set; }
        int price { get; set; }
        int amount { get; set; }
    }
}
