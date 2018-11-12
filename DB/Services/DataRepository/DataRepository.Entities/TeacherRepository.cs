using DB.Services.Interfaces.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Services.DataRepository.DataRepository.Entities
{
    public class TeacherRepository : Repository<teacher>, ITeacherRepository
    {
        public TeacherRepository(Model1 dbcontext) : base(dbcontext) { }

        public Model1 GetData
        {
            get
            {
                return _dbContext as Model1;
            }
        }
        public IQueryable<teacher> GetTeacherByName(string name)
        {
            return GetData.teachers.Where(t=> t.firstname == name || t.lastname == name );
        }
    }
}
