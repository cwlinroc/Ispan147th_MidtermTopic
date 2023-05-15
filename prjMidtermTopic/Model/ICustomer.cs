using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMidtermTopic.Model
{
    interface ICustomer
    {
        string id { get; set; }
        string acount { get; set; }
        string password { get; set; }
        string name { get; set; }
        string email { get; set; }
        string phone { get; set; }
        string address { get; set; }
        
    }
}
