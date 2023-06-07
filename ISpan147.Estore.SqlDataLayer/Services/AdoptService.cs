using ISpan147.Estore.SqlDataLayer.Dtos;
using ISpan147.Estore.SqlDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Services
{
    public class AdoptService
    {
        public int Create(AdoptDto dto)
        {
            return new AdoptRepositories().Create(dto);
        }
       
        public IEnumerable<AdoptDto> Search(int? AdoptID, int? PetID, DateTime? Application)
        {
            return new AdoptRepositories().Search(AdoptID,PetID,Application);
        }

        public int Update(AdoptDto dto)
        {
            return new AdoptRepositories().Update(dto);
        }

        public int Delete(AdoptDto dto)
        {
            return new AdoptRepositories().Delete(dto);
        }

    }
}
