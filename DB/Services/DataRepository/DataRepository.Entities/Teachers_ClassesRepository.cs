using DB.Services.Interfaces.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Services.DataRepository.DataRepository.Entities
{
    class Teachers_ClassesRepository : Repository<teachers_classes>, ITeachers_ClassesRepository
    {
        public Teachers_ClassesRepository(Model1 dbcontext) : base(dbcontext) { }

        public Model1 GetData
        {
            get
            {
                return _dbContext as Model1;
            }
        }

    }
}
