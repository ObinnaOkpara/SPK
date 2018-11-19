using DB.Services.Interfaces.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Services.DataRepository.DataRepository.Entities
{
    public class School_SubjectsRepository : Repository<school_subjects>, ISchool_SubjectsRepository
    {
        public School_SubjectsRepository(Model1 dbcontext) : base(dbcontext) { }

        public Model1 GetData
        {
            get
            {
                return _dbContext as Model1;
            }
        }

        public bool CheckIfItExists(string subject_name)
        {
          return  GetData.school_subjects.Any(ss => ss.subjects == subject_name);
        }
    }
}
