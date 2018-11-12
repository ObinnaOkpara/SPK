using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPK.AuthorizedUser
{
   static class AuthorizedUser<TEntity> where TEntity: class
    {
        public static TEntity CurrentUser;        
    }
}
