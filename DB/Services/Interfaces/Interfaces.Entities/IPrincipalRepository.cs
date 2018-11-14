using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Services.Interfaces.Interfaces.Entities
{
    public interface IPrincipalRepository : IRepository<principal>    
    {
        Task<principal> LoginPrincipal(string email, string password);
    }
}
