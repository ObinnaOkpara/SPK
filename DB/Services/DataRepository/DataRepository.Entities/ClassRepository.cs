using DB.Services.Interfaces.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Services.DataRepository.DataRepository.Entities
{
    public class ClassRepository : Repository<_class>, IClassRepository
    {
        public ClassRepository(Model1 dbcontext) : base(dbcontext) { }

        public Model1 GetData
        {
            get
            {
                return _dbContext as Model1;
            }
        }

        public bool CheckIfItExists(string class_name)
        {
            return GetData.classes.Any(ss => ss.classes == class_name);
        }
    }
}
