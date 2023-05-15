using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMidtermTopic.Model
{
    interface IPet
    {
        string id { get; set; }
        string name { get; set; }
        int speciesId { get; set; }
        int breedId { get; set; }
        int genderId { get; set; }
        string age { get; set; }
        string location { get; set; }

    }
}
