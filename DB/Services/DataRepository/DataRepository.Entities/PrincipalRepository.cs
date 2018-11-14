using DB.Services.Interfaces.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Services.DataRepository.DataRepository.Entities
{
   public class PrincipalRepository : Repository<principal>, IPrincipalRepository
    {
        public PrincipalRepository(Model1 dbcontext) : base(dbcontext) { }

        public Model1 GetData
        {
            get
            {
                return _dbContext as Model1;
            }
        }

        public Task<principal> LoginPrincipal(string email, string password)
        {
            return GetData.principals.FirstOrDefaultAsync(t => t.email == email && t.password == password);
        }
    }
}
