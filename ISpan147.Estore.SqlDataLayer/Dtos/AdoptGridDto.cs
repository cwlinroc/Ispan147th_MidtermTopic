using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
    public class AdoptGridDto
    {
        public int AdoptID { get; set; }
        public int PetID { get; set; }
        public int MemberID { get; set; }
        public DateTime ApplicationTime { get; set; }
        public string MemberName { get; set; }
        public string PetName { get; set; }
    }
}
