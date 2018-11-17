using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Services.Interfaces.Interfaces.Entities
{
    public interface IUserRepository : IRepository<user>
    {
        Task<user> LoginAdmin(string email, string password);
    }
}
