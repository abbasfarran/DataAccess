using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities;
using DataEntities.Entities.Common;

namespace DataAccess.Repositories
{
    public class GovernorateRepository
    {
        private MyContext _db;

        public GovernorateRepository(MyContext db)
        {
            _db = db;
        }

        public List<Governorate> Governorates()
        {
            return _db.Governorates.ToList();
        }
    }
}
