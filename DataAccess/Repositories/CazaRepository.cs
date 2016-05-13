using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities;
using DataEntities.Entities.Common;

namespace DataAccess.Repositories
{
   public class CazaRepository
   {
       private MyContext _db;

       public CazaRepository(MyContext mct)
       {
           _db = mct;
       }

       public List<Caza> Cazas()
       {
           return _db.Cazas.ToList();
       }
        public List<Caza> CazasByGovernorate(int governorateId)
        {
            return _db.Cazas.Where(x=>x.GovernorateId==governorateId).ToList();

        }

    }
}
